﻿using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace WindowsFormsApp1
{
    // Enum to represent supported database types
    public enum DatabaseType
    {
        SqlServer,
        PostgreSQL,
        MySQL
    }

    public class DatabaseHandler
    {
        private readonly DatabaseType _dbType;
        private readonly string _connectionString;
        private readonly int _commandTimeout; // Command timeout in seconds

        public DatabaseHandler(DatabaseType dbType, string connectionString, int commandTimeout = 60 * 60 * 6)
        {
            _dbType = dbType;
            _connectionString = connectionString;
            _commandTimeout = commandTimeout;
        }


        public DatabaseHandler(DatabaseType dbType, string server, string database, string user, string password,int connectionTimeout = 5, int commandTimeout = 60 * 60 * 6)
            : this(dbType, BuildConnectionString(dbType, server, database, user, password, connectionTimeout), commandTimeout: commandTimeout)
        {}

        // Method to check if the database connection is successful
        public bool CheckConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true; // Connection successful
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Connection failed: {ex.Message}");
                return false; // Connection failed
            }
        }

        // Factory method to get the appropriate connection based on the database type
        private IDbConnection GetConnection()
        {
            switch (_dbType)
            {
                case DatabaseType.SqlServer:
                    return new SqlConnection(_connectionString);
                case DatabaseType.PostgreSQL:
                    return new NpgsqlConnection(_connectionString);
                case DatabaseType.MySQL:
                    return new MySqlConnection(_connectionString);
                default:
                    throw new ArgumentException("Unsupported database type.");
            }
        }

        // Method to execute a non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandTimeout = _commandTimeout; // Set command timeout
                    AddParameters(command, parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Method to execute a scalar query (returns a single value)
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandTimeout = _commandTimeout; // Set command timeout
                    AddParameters(command, parameters);
                    return command.ExecuteScalar();
                }
            }
        }

        // Method to execute a query and return a DataTable
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandTimeout = _commandTimeout; // Set command timeout
                    AddParameters(command, parameters);

                    DataTable dataTable = new DataTable();
                    switch (_dbType)
                    {
                        case DatabaseType.SqlServer:
                            using (var adapter = new SqlDataAdapter((SqlCommand)command))
                            {
                                adapter.Fill(dataTable);
                            }
                            break;
                        case DatabaseType.PostgreSQL:
                            using (var adapter = new NpgsqlDataAdapter((NpgsqlCommand)command))
                            {
                                adapter.Fill(dataTable);
                            }
                            break;
                        case DatabaseType.MySQL:
                            using (var adapter = new MySqlDataAdapter((MySqlCommand)command))
                            {
                                adapter.Fill(dataTable);
                            }
                            break;
                        default:
                            throw new ArgumentException("Unsupported database type.");
                    }

                    return dataTable;
                }
            }
        }

        // Helper method to add parameters to the command
        private void AddParameters(IDbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    var dbParameter = command.CreateParameter();
                    dbParameter.ParameterName = param.Key;
                    dbParameter.Value = param.Value ?? DBNull.Value;
                    command.Parameters.Add(dbParameter);
                }
            }
        }

        // Static method to build a connection string dynamically with a connection timeout
        public static string BuildConnectionString(DatabaseType dbType, string server, string database, string user, string password, int connectionTimeout)
        {
            switch (dbType)
            {
                case DatabaseType.SqlServer:
                    var sqlBuilder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = database,
                        UserID = user,
                        Password = password,
                        ConnectTimeout = connectionTimeout // Connection timeout in seconds
                    };
                    return sqlBuilder.ConnectionString;

                case DatabaseType.PostgreSQL:
                    var npgsqlBuilder = new NpgsqlConnectionStringBuilder
                    {
                        Host = server,
                        Database = database,
                        Username = user,
                        Password = password,
                        Timeout = connectionTimeout // Connection timeout in seconds
                    };
                    return npgsqlBuilder.ConnectionString;

                case DatabaseType.MySQL:
                    var mysqlBuilder = new MySqlConnectionStringBuilder
                    {
                        Server = server,
                        Database = database,
                        UserID = user,
                        Password = password,
                        ConnectionTimeout = (uint)connectionTimeout // Connection timeout in seconds
                    };
                    return mysqlBuilder.ConnectionString;

                default:
                    throw new ArgumentException("Unsupported database type.");
            }
        }
    }
}

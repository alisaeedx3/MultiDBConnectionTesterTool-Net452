using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isServerModified = false;
        private bool isDatabaseModified = false;
        private bool isUserModified = false;
        private bool isPasswordModified = false;
        private bool isPortModified = false;
        private bool isProgrammaticChange = false;

        public Form1()
        {
            InitializeComponent();

            radoSQLServer.Tag = DatabaseType.SqlServer;
            radoMySQL.Tag = DatabaseType.MySQL;
            radoPG.Tag = DatabaseType.PostgreSQL;
            radoOracle.Tag = DatabaseType.Oracle;
            radoSqlServerWindowsAuth.Tag = DatabaseType.SqlServerWindowsAuth;

            radoSQLServer.Checked = true;

            // Attach CheckedChanged event to all radio buttons
            radoSQLServer.CheckedChanged += RadioButtons_CheckedChanged;
            radoMySQL.CheckedChanged += RadioButtons_CheckedChanged;
            radoPG.CheckedChanged += RadioButtons_CheckedChanged;
            radoOracle.CheckedChanged += RadioButtons_CheckedChanged;
            radoSqlServerWindowsAuth.CheckedChanged += RadioButtons_CheckedChanged;

            RadioButtons_CheckedChanged(radoSQLServer, null);

            // Attach TextChanged event to track user modifications
            txtServer.TextChanged += TextBoxes_TextChanged;
            txtDatabse.TextChanged += TextBoxes_TextChanged;
            txtUser.TextChanged += TextBoxes_TextChanged;
            txtPassword.TextChanged += TextBoxes_TextChanged;
            txtPort.TextChanged += TextBoxes_TextChanged;
        }

        private void Cleare()
        {
            txtResult.Text = "";
            dataGridView1.DataSource = null;
        }

        private DatabaseHandler GetDatabaseHandler()
        {
            DatabaseType dbType =
                (DatabaseType)Controls.OfType<RadioButton>().First(c => c.Checked == true).Tag;

            return new DatabaseHandler(dbType,
                txtServer.Text,
                txtDatabse.Text,
                txtUser.Text,
                txtPassword.Text,
                port: int.TryParse(txtPort.Text, out int p) ? p : 0);
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this, GetDatabaseHandler().CheckConnection() ? "OK" : "Faile");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnExecuteNonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Cleare();
                txtResult.Text = GetDatabaseHandler().ExecuteNonQuery(txtSQL.Text).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnExecuteScalar_Click(object sender, EventArgs e)
        {
            try
            {
                Cleare();
                txtResult.Text = GetDatabaseHandler().ExecuteScalar(txtSQL.Text)?.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Cleare();
                dataGridView1.DataSource = GetDatabaseHandler().ExecuteQuery(txtSQL.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isProgrammaticChange) // Only mark as modified if not a programmatic change
                {
                    if (sender == txtServer) isServerModified = true;
                    else if (sender == txtDatabse) isDatabaseModified = true;
                    else if (sender == txtUser) isUserModified = true;
                    else if (sender == txtPassword) isPasswordModified = true;
                    else if (sender == txtPort) isPortModified = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is RadioButton radioButton && radioButton.Checked)
                {
                    DatabaseType dbType = (DatabaseType)radioButton.Tag;

                    isProgrammaticChange = true; // Start programmatic change
                    switch (dbType)
                    {
                        case DatabaseType.SqlServer:
                            if (!isServerModified) txtServer.Text = "localhost";
                            if (!isDatabaseModified) txtDatabse.Text = "master";
                            if (!isUserModified) txtUser.Text = "sa";
                            if (!isPasswordModified) txtPassword.Text = "password";
                            if (!isPortModified) txtPort.Text = "1433";
                            break;

                        case DatabaseType.MySQL:
                            if (!isServerModified) txtServer.Text = "localhost";
                            if (!isDatabaseModified) txtDatabse.Text = "test";
                            if (!isUserModified) txtUser.Text = "root";
                            if (!isPasswordModified) txtPassword.Text = "password";
                            if (!isPortModified) txtPort.Text = "3306";
                            break;

                        case DatabaseType.PostgreSQL:
                            if (!isServerModified) txtServer.Text = "localhost";
                            if (!isDatabaseModified) txtDatabse.Text = "postgres";
                            if (!isUserModified) txtUser.Text = "postgres";
                            if (!isPasswordModified) txtPassword.Text = "password";
                            if (!isPortModified) txtPort.Text = "5432";
                            break;

                        case DatabaseType.Oracle:
                            if (!isServerModified) txtServer.Text = "localhost";
                            if (!isDatabaseModified) txtDatabse.Text = "orcl";
                            if (!isUserModified) txtUser.Text = "system";
                            if (!isPasswordModified) txtPassword.Text = "oracle";
                            if (!isPortModified) txtPort.Text = "1521";
                            break;

                        case DatabaseType.SqlServerWindowsAuth:
                            if (!isServerModified) txtServer.Text = "localhost";
                            if (!isDatabaseModified) txtDatabse.Text = "master";
                            txtUser.Text = ""; // Windows Authentication, so clear user and password
                            txtPassword.Text = "";
                            if (!isPortModified) txtPort.Text = "1433";
                            break;
                    }
                    isProgrammaticChange = false; // End programmatic change
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

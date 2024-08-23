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
        public Form1()
        {
            InitializeComponent();
        }

        private void Cleare()
        {
            txtResult.Text = "";
            dataGridView1.DataSource = null;
        }

        private DatabaseHandler GetDatabaseHandler()
        {
            DatabaseType dbType = radoPG.Checked ? DatabaseType.PostgreSQL : radoMySQL.Checked ? DatabaseType.MySQL : DatabaseType.SqlServer;
            return new DatabaseHandler(dbType, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(GetDatabaseHandler().CheckConnection() ? "OK" : "Faile");
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
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
    }
}

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

        private DatabaseHandler GetDatabaseHandler()
        {
            DatabaseType dbType = rasoPG.Checked ? DatabaseType.PostgreSQL : radoMySQL.Checked ? DatabaseType.MySQL : DatabaseType.SqlServer;
            return new DatabaseHandler(dbType, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetDatabaseHandler().CheckConnection() ? "OK" : "Faile");
        }
    }
}

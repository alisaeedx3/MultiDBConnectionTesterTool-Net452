namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radoPG = new System.Windows.Forms.RadioButton();
            this.radoSQLServer = new System.Windows.Forms.RadioButton();
            this.radoMySQL = new System.Windows.Forms.RadioButton();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.btnExecuteNonQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.radoOracle = new System.Windows.Forms.RadioButton();
            this.radoSqlServerWindowsAuth = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radoPG
            // 
            this.radoPG.AutoSize = true;
            this.radoPG.Checked = true;
            this.radoPG.Location = new System.Drawing.Point(12, 10);
            this.radoPG.Name = "radoPG";
            this.radoPG.Size = new System.Drawing.Size(81, 17);
            this.radoPG.TabIndex = 0;
            this.radoPG.TabStop = true;
            this.radoPG.Tag = "0";
            this.radoPG.Text = "PostgreSQL";
            this.radoPG.UseVisualStyleBackColor = true;
            // 
            // radoSQLServer
            // 
            this.radoSQLServer.AutoSize = true;
            this.radoSQLServer.Location = new System.Drawing.Point(296, 10);
            this.radoSQLServer.Name = "radoSQLServer";
            this.radoSQLServer.Size = new System.Drawing.Size(71, 17);
            this.radoSQLServer.TabIndex = 1;
            this.radoSQLServer.Tag = "3";
            this.radoSQLServer.Text = "SqlServer";
            this.radoSQLServer.UseVisualStyleBackColor = true;
            // 
            // radoMySQL
            // 
            this.radoMySQL.AutoSize = true;
            this.radoMySQL.Location = new System.Drawing.Point(115, 10);
            this.radoMySQL.Name = "radoMySQL";
            this.radoMySQL.Size = new System.Drawing.Size(58, 17);
            this.radoMySQL.TabIndex = 2;
            this.radoMySQL.Tag = "1";
            this.radoMySQL.Text = "MySQL";
            this.radoMySQL.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(53, 28);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(120, 20);
            this.txtServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "database";
            // 
            // txtDatabse
            // 
            this.txtDatabse.Location = new System.Drawing.Point(388, 28);
            this.txtDatabse.Name = "txtDatabse";
            this.txtDatabse.Size = new System.Drawing.Size(120, 20);
            this.txtDatabse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "user";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(53, 51);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(13, 77);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(512, 23);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(12, 138);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(513, 96);
            this.txtSQL.TabIndex = 12;
            this.txtSQL.Text = "";
            // 
            // btnExecuteNonQuery
            // 
            this.btnExecuteNonQuery.Location = new System.Drawing.Point(12, 240);
            this.btnExecuteNonQuery.Name = "btnExecuteNonQuery";
            this.btnExecuteNonQuery.Size = new System.Drawing.Size(189, 23);
            this.btnExecuteNonQuery.TabIndex = 13;
            this.btnExecuteNonQuery.Text = "ExecuteNonQuery";
            this.btnExecuteNonQuery.UseVisualStyleBackColor = true;
            this.btnExecuteNonQuery.Click += new System.EventHandler(this.btnExecuteNonQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 247);
            this.dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Result Table";
            // 
            // radoOracle
            // 
            this.radoOracle.AutoSize = true;
            this.radoOracle.Location = new System.Drawing.Point(207, 10);
            this.radoOracle.Name = "radoOracle";
            this.radoOracle.Size = new System.Drawing.Size(56, 17);
            this.radoOracle.TabIndex = 16;
            this.radoOracle.Tag = "2";
            this.radoOracle.Text = "Oracle";
            this.radoOracle.UseVisualStyleBackColor = true;
            // 
            // radoSqlServerWindowsAuth
            // 
            this.radoSqlServerWindowsAuth.AutoSize = true;
            this.radoSqlServerWindowsAuth.Location = new System.Drawing.Point(388, 10);
            this.radoSqlServerWindowsAuth.Name = "radoSqlServerWindowsAuth";
            this.radoSqlServerWindowsAuth.Size = new System.Drawing.Size(137, 17);
            this.radoSqlServerWindowsAuth.TabIndex = 17;
            this.radoSqlServerWindowsAuth.Tag = "4";
            this.radoSqlServerWindowsAuth.Text = "SqlServerWindowsAuth";
            this.radoSqlServerWindowsAuth.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Write SQL";
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(207, 240);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(175, 23);
            this.btnExecuteScalar.TabIndex = 21;
            this.btnExecuteScalar.Text = "ExecuteScalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            this.btnExecuteScalar.Click += new System.EventHandler(this.btnExecuteScalar_Click);
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(388, 240);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(137, 23);
            this.btnExecuteQuery.TabIndex = 22;
            this.btnExecuteQuery.Text = "ExecuteQuery";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(53, 281);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(473, 20);
            this.txtResult.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "PORT";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(207, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(117, 20);
            this.txtPort.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 590);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radoSqlServerWindowsAuth);
            this.Controls.Add(this.radoOracle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExecuteNonQuery);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatabse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.radoMySQL);
            this.Controls.Add(this.radoSQLServer);
            this.Controls.Add(this.radoPG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radoPG;
        private System.Windows.Forms.RadioButton radoSQLServer;
        private System.Windows.Forms.RadioButton radoMySQL;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.Button btnExecuteNonQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radoOracle;
        private System.Windows.Forms.RadioButton radoSqlServerWindowsAuth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExecuteScalar;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort;
    }
}


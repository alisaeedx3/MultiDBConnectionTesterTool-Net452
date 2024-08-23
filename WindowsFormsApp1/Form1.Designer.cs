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
            this.rasoPG = new System.Windows.Forms.RadioButton();
            this.radoSQLServer = new System.Windows.Forms.RadioButton();
            this.radoMySQL = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExecSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rasoPG
            // 
            this.rasoPG.AutoSize = true;
            this.rasoPG.Checked = true;
            this.rasoPG.Location = new System.Drawing.Point(13, 13);
            this.rasoPG.Name = "rasoPG";
            this.rasoPG.Size = new System.Drawing.Size(81, 17);
            this.rasoPG.TabIndex = 0;
            this.rasoPG.TabStop = true;
            this.rasoPG.Text = "PostgreSQL";
            this.rasoPG.UseVisualStyleBackColor = true;
            // 
            // radoSQLServer
            // 
            this.radoSQLServer.AutoSize = true;
            this.radoSQLServer.Location = new System.Drawing.Point(109, 12);
            this.radoSQLServer.Name = "radoSQLServer";
            this.radoSQLServer.Size = new System.Drawing.Size(71, 17);
            this.radoSQLServer.TabIndex = 1;
            this.radoSQLServer.Text = "SqlServer";
            this.radoSQLServer.UseVisualStyleBackColor = true;
            // 
            // radoMySQL
            // 
            this.radoMySQL.AutoSize = true;
            this.radoMySQL.Location = new System.Drawing.Point(213, 13);
            this.radoMySQL.Name = "radoMySQL";
            this.radoMySQL.Size = new System.Drawing.Size(58, 17);
            this.radoMySQL.TabIndex = 2;
            this.radoMySQL.TabStop = true;
            this.radoMySQL.Text = "MySQL";
            this.radoMySQL.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "database";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "user";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 20);
            this.textBox4.TabIndex = 9;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(13, 130);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(258, 23);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btnExecSQL
            // 
            this.btnExecSQL.Location = new System.Drawing.Point(12, 261);
            this.btnExecSQL.Name = "btnExecSQL";
            this.btnExecSQL.Size = new System.Drawing.Size(255, 23);
            this.btnExecSQL.TabIndex = 13;
            this.btnExecSQL.Text = "Execute SQL";
            this.btnExecSQL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.btnExecSQL);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radoMySQL);
            this.Controls.Add(this.radoSQLServer);
            this.Controls.Add(this.rasoPG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rasoPG;
        private System.Windows.Forms.RadioButton radoSQLServer;
        private System.Windows.Forms.RadioButton radoMySQL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExecSQL;
    }
}


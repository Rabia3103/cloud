namespace Assignment3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CreateClient_Click = new System.Windows.Forms.Button();
            this.textBox1_PrimaryKey = new System.Windows.Forms.TextBox();
            this.textBox1_URI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2_tableToCreate = new System.Windows.Forms.TextBox();
            this.textBox1_DBtoCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Authentication";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.btn_CreateClient_Click);
            this.groupBox1.Controls.Add(this.textBox1_PrimaryKey);
            this.groupBox1.Controls.Add(this.textBox1_URI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // btn_CreateClient_Click
            // 
            this.btn_CreateClient_Click.Location = new System.Drawing.Point(204, 262);
            this.btn_CreateClient_Click.Name = "btn_CreateClient_Click";
            this.btn_CreateClient_Click.Size = new System.Drawing.Size(351, 46);
            this.btn_CreateClient_Click.TabIndex = 4;
            this.btn_CreateClient_Click.Text = "Create Cosmos Client";
            this.btn_CreateClient_Click.UseVisualStyleBackColor = true;
            this.btn_CreateClient_Click.Click += new System.EventHandler(this.btn_CosmosClient_Click);
            // 
            // textBox1_PrimaryKey
            // 
            this.textBox1_PrimaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_PrimaryKey.Location = new System.Drawing.Point(188, 162);
            this.textBox1_PrimaryKey.Name = "textBox1_PrimaryKey";
            this.textBox1_PrimaryKey.ReadOnly = true;
            this.textBox1_PrimaryKey.Size = new System.Drawing.Size(530, 30);
            this.textBox1_PrimaryKey.TabIndex = 3;
            // 
            // textBox1_URI
            // 
            this.textBox1_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_URI.Location = new System.Drawing.Point(131, 74);
            this.textBox1_URI.Name = "textBox1_URI";
            this.textBox1_URI.ReadOnly = true;
            this.textBox1_URI.Size = new System.Drawing.Size(587, 30);
            this.textBox1_URI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primery Key :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Databases and Tables";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2_tableToCreate);
            this.groupBox2.Controls.Add(this.textBox1_DBtoCreate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 318);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Database";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create in Cloud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2_tableToCreate
            // 
            this.textBox2_tableToCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_tableToCreate.Location = new System.Drawing.Point(408, 71);
            this.textBox2_tableToCreate.Name = "textBox2_tableToCreate";
            this.textBox2_tableToCreate.Size = new System.Drawing.Size(141, 30);
            this.textBox2_tableToCreate.TabIndex = 3;
            // 
            // textBox1_DBtoCreate
            // 
            this.textBox1_DBtoCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_DBtoCreate.Location = new System.Drawing.Point(129, 71);
            this.textBox1_DBtoCreate.Name = "textBox1_DBtoCreate";
            this.textBox1_DBtoCreate.Size = new System.Drawing.Size(174, 30);
            this.textBox1_DBtoCreate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1_PrimaryKey;
        private System.Windows.Forms.TextBox textBox1_URI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateClient_Click;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2_tableToCreate;
        private System.Windows.Forms.TextBox textBox1_DBtoCreate;
    }
}


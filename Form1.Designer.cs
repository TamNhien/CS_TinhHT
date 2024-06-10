namespace CS_TinhHT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtKQ1 = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtKQ2 = new System.Windows.Forms.TextBox();
            this.btnTinh1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDT = new System.Windows.Forms.CheckBox();
            this.chkCV = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(108, 26);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 21);
            this.txtR.TabIndex = 1;
            // 
            // txtKQ1
            // 
            this.txtKQ1.Location = new System.Drawing.Point(108, 72);
            this.txtKQ1.Name = "txtKQ1";
            this.txtKQ1.Size = new System.Drawing.Size(100, 21);
            this.txtKQ1.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(108, 126);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 36);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Location = new System.Drawing.Point(411, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(17, 59);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(38, 17);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "DT";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(17, 21);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(38, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "CV";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(240, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtKQ2
            // 
            this.txtKQ2.Location = new System.Drawing.Point(240, 72);
            this.txtKQ2.Name = "txtKQ2";
            this.txtKQ2.Size = new System.Drawing.Size(100, 21);
            this.txtKQ2.TabIndex = 1;
            // 
            // btnTinh1
            // 
            this.btnTinh1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh1.Location = new System.Drawing.Point(478, 180);
            this.btnTinh1.Name = "btnTinh1";
            this.btnTinh1.Size = new System.Drawing.Size(75, 36);
            this.btnTinh1.TabIndex = 2;
            this.btnTinh1.Text = "Tính 1";
            this.btnTinh1.UseVisualStyleBackColor = true;
            this.btnTinh1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDT);
            this.groupBox2.Controls.Add(this.chkCV);
            this.groupBox2.Location = new System.Drawing.Point(635, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select";
            // 
            // chkDT
            // 
            this.chkDT.AutoSize = true;
            this.chkDT.Location = new System.Drawing.Point(27, 59);
            this.chkDT.Name = "chkDT";
            this.chkDT.Size = new System.Drawing.Size(39, 17);
            this.chkDT.TabIndex = 0;
            this.chkDT.Text = "DT";
            this.chkDT.UseVisualStyleBackColor = true;
            // 
            // chkCV
            // 
            this.chkCV.AutoSize = true;
            this.chkCV.Location = new System.Drawing.Point(27, 21);
            this.chkCV.Name = "chkCV";
            this.chkCV.Size = new System.Drawing.Size(39, 17);
            this.chkCV.TabIndex = 0;
            this.chkCV.Text = "CV";
            this.chkCV.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(704, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tính 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTinh1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKQ2);
            this.Controls.Add(this.txtKQ1);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtKQ1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtKQ2;
        private System.Windows.Forms.Button btnTinh1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDT;
        private System.Windows.Forms.CheckBox chkCV;
        private System.Windows.Forms.Button button2;
    }
}


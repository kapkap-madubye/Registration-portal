namespace Registration_Application
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chckBAY03A1 = new System.Windows.Forms.CheckBox();
            this.chckCMN03A1 = new System.Windows.Forms.CheckBox();
            this.chckIFS03A1 = new System.Windows.Forms.CheckBox();
            this.chckDSW013A = new System.Windows.Forms.CheckBox();
            this.lstSomething = new System.Windows.Forms.ListBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTheCost = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(34, 68);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 18);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(142, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(35, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.rdFemale);
            this.groupBox2.Controls.Add(this.rdMale);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(394, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(28, 68);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(81, 22);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.RdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(28, 35);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(62, 22);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.RdMale_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Controls.Add(this.chckBAY03A1);
            this.groupBox3.Controls.Add(this.chckCMN03A1);
            this.groupBox3.Controls.Add(this.chckIFS03A1);
            this.groupBox3.Controls.Add(this.chckDSW013A);
            this.groupBox3.Location = new System.Drawing.Point(35, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modules";
            // 
            // chckBAY03A1
            // 
            this.chckBAY03A1.AutoSize = true;
            this.chckBAY03A1.Location = new System.Drawing.Point(557, 36);
            this.chckBAY03A1.Name = "chckBAY03A1";
            this.chckBAY03A1.Size = new System.Drawing.Size(72, 17);
            this.chckBAY03A1.TabIndex = 3;
            this.chckBAY03A1.Text = "BAY03A1";
            this.chckBAY03A1.UseVisualStyleBackColor = true;
            this.chckBAY03A1.CheckedChanged += new System.EventHandler(this.ChckBAY03A1_CheckedChanged);
            // 
            // chckCMN03A1
            // 
            this.chckCMN03A1.AutoSize = true;
            this.chckCMN03A1.Location = new System.Drawing.Point(374, 36);
            this.chckCMN03A1.Name = "chckCMN03A1";
            this.chckCMN03A1.Size = new System.Drawing.Size(75, 17);
            this.chckCMN03A1.TabIndex = 2;
            this.chckCMN03A1.Text = "CMN03A1";
            this.chckCMN03A1.UseVisualStyleBackColor = true;
            this.chckCMN03A1.CheckedChanged += new System.EventHandler(this.ChckCMN03A1_CheckedChanged);
            // 
            // chckIFS03A1
            // 
            this.chckIFS03A1.AutoSize = true;
            this.chckIFS03A1.Location = new System.Drawing.Point(191, 36);
            this.chckIFS03A1.Name = "chckIFS03A1";
            this.chckIFS03A1.Size = new System.Drawing.Size(67, 17);
            this.chckIFS03A1.TabIndex = 1;
            this.chckIFS03A1.Text = "IFS03A1";
            this.chckIFS03A1.UseVisualStyleBackColor = true;
            this.chckIFS03A1.CheckedChanged += new System.EventHandler(this.ChckIFS03A1_CheckedChanged);
            // 
            // chckDSW013A
            // 
            this.chckDSW013A.AutoSize = true;
            this.chckDSW013A.Location = new System.Drawing.Point(17, 36);
            this.chckDSW013A.Name = "chckDSW013A";
            this.chckDSW013A.Size = new System.Drawing.Size(77, 17);
            this.chckDSW013A.TabIndex = 0;
            this.chckDSW013A.Text = "DSW03A1";
            this.chckDSW013A.UseVisualStyleBackColor = true;
            this.chckDSW013A.CheckedChanged += new System.EventHandler(this.ChckDSW013A_CheckedChanged);
            // 
            // lstSomething
            // 
            this.lstSomething.FormattingEnabled = true;
            this.lstSomething.Location = new System.Drawing.Point(35, 337);
            this.lstSomething.Name = "lstSomething";
            this.lstSomething.Size = new System.Drawing.Size(684, 95);
            this.lstSomething.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(372, 460);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(68, 18);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost(R)";
            // 
            // lblTheCost
            // 
            this.lblTheCost.AutoSize = true;
            this.lblTheCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheCost.Location = new System.Drawing.Point(702, 460);
            this.lblTheCost.Name = "lblTheCost";
            this.lblTheCost.Size = new System.Drawing.Size(17, 18);
            this.lblTheCost.TabIndex = 9;
            this.lblTheCost.Text = "0";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(35, 460);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 33);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblTheCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lstSomething);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chckBAY03A1;
        private System.Windows.Forms.CheckBox chckCMN03A1;
        private System.Windows.Forms.CheckBox chckIFS03A1;
        private System.Windows.Forms.CheckBox chckDSW013A;
        private System.Windows.Forms.ListBox lstSomething;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTheCost;
        private System.Windows.Forms.Button btnRegister;
    }
}


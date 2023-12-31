namespace ThongTinSV
{
    partial class frmStudent
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.ckEn = new System.Windows.Forms.CheckBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ckFre = new System.Windows.Forms.CheckBox();
            this.ckKr = new System.Windows.Forms.CheckBox();
            this.ckChinese = new System.Windows.Forms.CheckBox();
            this.ckOther = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 2;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(99, 91);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(169, 90);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Vietnam",
            "England",
            "Australia",
            "Japan",
            "China",
            "United States",
            "United Kingdom",
            "Brazil",
            "Taiwan",
            "Korea",
            "Russia",
            "Thailan",
            "Laos"});
            this.cboCountry.Location = new System.Drawing.Point(99, 113);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(167, 21);
            this.cboCountry.TabIndex = 5;
            this.cboCountry.Text = "Select your country:";
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(99, 140);
            this.txtAdr.Multiline = true;
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(167, 43);
            this.txtAdr.TabIndex = 6;
            // 
            // ckEn
            // 
            this.ckEn.AutoSize = true;
            this.ckEn.Location = new System.Drawing.Point(99, 190);
            this.ckEn.Name = "ckEn";
            this.ckEn.Size = new System.Drawing.Size(60, 17);
            this.ckEn.TabIndex = 7;
            this.ckEn.Text = "English";
            this.ckEn.UseVisualStyleBackColor = true;
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(357, 23);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(240, 290);
            this.lstName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address:";
            // 
            // ckFre
            // 
            this.ckFre.AutoSize = true;
            this.ckFre.Location = new System.Drawing.Point(176, 190);
            this.ckFre.Name = "ckFre";
            this.ckFre.Size = new System.Drawing.Size(59, 17);
            this.ckFre.TabIndex = 14;
            this.ckFre.Text = "French";
            this.ckFre.UseVisualStyleBackColor = true;
            // 
            // ckKr
            // 
            this.ckKr.AutoSize = true;
            this.ckKr.Location = new System.Drawing.Point(99, 213);
            this.ckKr.Name = "ckKr";
            this.ckKr.Size = new System.Drawing.Size(60, 17);
            this.ckKr.TabIndex = 15;
            this.ckKr.Text = "Korean";
            this.ckKr.UseVisualStyleBackColor = true;
            // 
            // ckChinese
            // 
            this.ckChinese.AutoSize = true;
            this.ckChinese.Location = new System.Drawing.Point(176, 215);
            this.ckChinese.Name = "ckChinese";
            this.ckChinese.Size = new System.Drawing.Size(64, 17);
            this.ckChinese.TabIndex = 16;
            this.ckChinese.Text = "Chinese";
            this.ckChinese.UseVisualStyleBackColor = true;
            // 
            // ckOther
            // 
            this.ckOther.AutoSize = true;
            this.ckOther.Location = new System.Drawing.Point(99, 237);
            this.ckOther.Name = "ckOther";
            this.ckOther.Size = new System.Drawing.Size(52, 17);
            this.ckOther.TabIndex = 17;
            this.ckOther.Text = "Other";
            this.ckOther.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Language:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(84, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 26);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 26);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(357, 319);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(240, 22);
            this.btQuit.TabIndex = 22;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ckOther);
            this.panel1.Controls.Add(this.ckChinese);
            this.panel1.Controls.Add(this.ckKr);
            this.panel1.Controls.Add(this.ckFre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ckEn);
            this.panel1.Controls.Add(this.txtAdr);
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 314);
            this.panel1.TabIndex = 23;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.lstName);
            this.Name = "frmStudent";
            this.ShowIcon = false;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.CheckBox ckEn;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckFre;
        private System.Windows.Forms.CheckBox ckKr;
        private System.Windows.Forms.CheckBox ckChinese;
        private System.Windows.Forms.CheckBox ckOther;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Panel panel1;
    }
}


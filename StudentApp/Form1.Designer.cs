namespace StudentApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBatch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.chkFrech = new System.Windows.Forms.CheckBox();
            this.chkRussia = new System.Windows.Forms.CheckBox();
            this.chkChinese = new System.Windows.Forms.CheckBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(269, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 112);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(269, 70);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Sex";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(466, 61);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 8;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(520, 61);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 9;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Class";
            // 
            // cboBatch
            // 
            this.cboBatch.FormattingEnabled = true;
            this.cboBatch.Items.AddRange(new object[] {
            "BASF19001",
            "BASF2001",
            "BASF2002",
            "BSAF19090"});
            this.cboBatch.Location = new System.Drawing.Point(463, 86);
            this.cboBatch.Name = "cboBatch";
            this.cboBatch.Size = new System.Drawing.Size(121, 21);
            this.cboBatch.TabIndex = 11;
            this.cboBatch.Text = "Batch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Student Lang";
            // 
            // chkEnglish
            // 
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(466, 114);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(60, 17);
            this.chkEnglish.TabIndex = 13;
            this.chkEnglish.Text = "English";
            this.chkEnglish.UseVisualStyleBackColor = true;
            // 
            // chkFrech
            // 
            this.chkFrech.AutoSize = true;
            this.chkFrech.Location = new System.Drawing.Point(466, 137);
            this.chkFrech.Name = "chkFrech";
            this.chkFrech.Size = new System.Drawing.Size(59, 17);
            this.chkFrech.TabIndex = 14;
            this.chkFrech.Text = "French";
            this.chkFrech.UseVisualStyleBackColor = true;
            // 
            // chkRussia
            // 
            this.chkRussia.AutoSize = true;
            this.chkRussia.Location = new System.Drawing.Point(466, 160);
            this.chkRussia.Name = "chkRussia";
            this.chkRussia.Size = new System.Drawing.Size(58, 17);
            this.chkRussia.TabIndex = 15;
            this.chkRussia.Text = "Russia";
            this.chkRussia.UseVisualStyleBackColor = true;
            // 
            // chkChinese
            // 
            this.chkChinese.AutoSize = true;
            this.chkChinese.Location = new System.Drawing.Point(466, 183);
            this.chkChinese.Name = "chkChinese";
            this.chkChinese.Size = new System.Drawing.Size(64, 17);
            this.chkChinese.TabIndex = 16;
            this.chkChinese.Text = "Chinese";
            this.chkChinese.UseVisualStyleBackColor = true;
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Location = new System.Drawing.Point(466, 206);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(57, 17);
            this.chkOthers.TabIndex = 17;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(102, 188);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(296, 188);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 237);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkOthers);
            this.Controls.Add(this.chkChinese);
            this.Controls.Add(this.chkRussia);
            this.Controls.Add(this.chkFrech);
            this.Controls.Add(this.chkEnglish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboBatch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEnglish;
        private System.Windows.Forms.CheckBox chkFrech;
        private System.Windows.Forms.CheckBox chkRussia;
        private System.Windows.Forms.CheckBox chkChinese;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuit;
    }
}


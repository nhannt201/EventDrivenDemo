namespace ThongTinSV
{
    partial class frmInfo
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
            this.lb_lang = new System.Windows.Forms.Label();
            this.lb_adr = new System.Windows.Forms.Label();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_lang
            // 
            this.lb_lang.AutoSize = true;
            this.lb_lang.Location = new System.Drawing.Point(17, 131);
            this.lb_lang.Name = "lb_lang";
            this.lb_lang.Size = new System.Drawing.Size(58, 13);
            this.lb_lang.TabIndex = 24;
            this.lb_lang.Text = "Language:";
            // 
            // lb_adr
            // 
            this.lb_adr.AutoSize = true;
            this.lb_adr.Location = new System.Drawing.Point(24, 108);
            this.lb_adr.Name = "lb_adr";
            this.lb_adr.Size = new System.Drawing.Size(48, 13);
            this.lb_adr.TabIndex = 23;
            this.lb_adr.Text = "Address:";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Location = new System.Drawing.Point(26, 85);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(46, 13);
            this.lb_country.TabIndex = 22;
            this.lb_country.Text = "Country:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(27, 62);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(45, 13);
            this.lb_gender.TabIndex = 21;
            this.lb_gender.Text = "Gender:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(34, 39);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 13);
            this.lb_name.TabIndex = 20;
            this.lb_name.Text = "Name: ";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(17, 15);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(64, 13);
            this.lb_id.TabIndex = 19;
            this.lb_id.Text = "Student ID: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_lang);
            this.panel1.Controls.Add(this.lb_adr);
            this.panel1.Controls.Add(this.lb_country);
            this.panel1.Controls.Add(this.lb_gender);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.lb_id);
            this.panel1.Location = new System.Drawing.Point(48, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 173);
            this.panel1.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(48, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(270, 22);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 234);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Name = "frmInfo";
            this.Text = "Show Information";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_lang;
        private System.Windows.Forms.Label lb_adr;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}
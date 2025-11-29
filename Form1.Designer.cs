namespace QRGen
{
    partial class frmsimQRgen
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.LinkLabel();
            this.lblCopyrightsDiodor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(200, 165);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(145, 20);
            this.txtLink.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(225, 213);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate QR";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(372, 125);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(196, 196);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;
            this.picQR.Click += new System.EventHandler(this.picQR_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save .png";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Bookman Old Style", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbltitle.Location = new System.Drawing.Point(186, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(417, 84);
            this.lbltitle.TabIndex = 5;
            this.lbltitle.Text = "simQRgen";
            // 
            // lblGithub
            // 
            this.lblGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.lblGithub.AutoSize = true;
            this.lblGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.lblGithub.Location = new System.Drawing.Point(209, 80);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(113, 13);
            this.lblGithub.TabIndex = 6;
            this.lblGithub.TabStop = true;
            this.lblGithub.Text = "github.com/DiodorEos";
            this.lblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGithub_LinkClicked);
            // 
            // lblCopyrightsDiodor
            // 
            this.lblCopyrightsDiodor.AutoSize = true;
            this.lblCopyrightsDiodor.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCopyrightsDiodor.Location = new System.Drawing.Point(12, 415);
            this.lblCopyrightsDiodor.Name = "lblCopyrightsDiodor";
            this.lblCopyrightsDiodor.Size = new System.Drawing.Size(189, 12);
            this.lblCopyrightsDiodor.TabIndex = 7;
            this.lblCopyrightsDiodor.Text = "©2025, HashWatch v0.1, Created by DiodorEos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "This work is licensed under the";
            // 
            // lblLicense
            // 
            this.lblLicense.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLicense.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.lblLicense.Location = new System.Drawing.Point(133, 428);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(339, 12);
            this.lblLicense.TabIndex = 9;
            this.lblLicense.TabStop = true;
            this.lblLicense.Text = "Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter a link below:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(352, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 287);
            this.panel1.TabIndex = 12;
            // 
            // frmsimQRgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCopyrightsDiodor);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtLink);
            this.Name = "frmsimQRgen";
            this.Text = "simQRgen";
            this.Load += new System.EventHandler(this.frmsimQRgen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.LinkLabel lblGithub;
        private System.Windows.Forms.Label lblCopyrightsDiodor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
    }
}


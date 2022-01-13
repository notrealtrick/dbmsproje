namespace dbmsproje
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.maskedid = new System.Windows.Forms.MaskedTextBox();
            this.labelsifre = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(483, 286);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(141, 49);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUye.Location = new System.Drawing.Point(195, 286);
            this.btnYeniUye.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(133, 49);
            this.btnYeniUye.TabIndex = 15;
            this.btnYeniUye.Text = "YENİ ÜYE";
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(257, 223);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.MaxLength = 11;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.Size = new System.Drawing.Size(411, 41);
            this.txtSifre.TabIndex = 13;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParola_KeyPress);
            // 
            // maskedid
            // 
            this.maskedid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedid.Location = new System.Drawing.Point(257, 172);
            this.maskedid.Margin = new System.Windows.Forms.Padding(4);
            this.maskedid.Mask = "00000000000";
            this.maskedid.Name = "maskedid";
            this.maskedid.Size = new System.Drawing.Size(411, 41);
            this.maskedid.TabIndex = 12;
            this.maskedid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxtTC_MaskInputRejected);
            this.maskedid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtxtTC_KeyPress);
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsifre.Location = new System.Drawing.Point(36, 235);
            this.labelsifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(68, 25);
            this.labelsifre.TabIndex = 10;
            this.labelsifre.Text = "Parola";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelid.Location = new System.Drawing.Point(36, 182);
            this.labelid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(118, 25);
            this.labelid.TabIndex = 9;
            this.labelid.Text = "Kullanıcı TC";
            this.labelid.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(252, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "KALİTENİN ADRESİ";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(749, 417);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.maskedid);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aybar Rent a Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.MaskedTextBox maskedid;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
    }
}


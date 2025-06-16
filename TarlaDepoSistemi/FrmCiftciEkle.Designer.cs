namespace TarlaDepoSistemi
{
    partial class FrmCiftciEkle
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEkle = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.AliceBlue;
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.Location = new Point(111, 103);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(183, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.AliceBlue;
            txtSoyad.BorderStyle = BorderStyle.None;
            txtSoyad.Location = new Point(111, 172);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(183, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.AliceBlue;
            txtTelefon.BorderStyle = BorderStyle.None;
            txtTelefon.Location = new Point(111, 236);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(183, 23);
            txtTelefon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 106);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 175);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 239);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 6;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 307);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 7;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = SystemColors.ControlText;
            btnEkle.Location = new Point(111, 417);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(183, 64);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "➕ Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AliceBlue;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(111, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 22);
            label5.Name = "label5";
            label5.Size = new Size(322, 46);
            label5.TabIndex = 10;
            label5.Text = "➕ Yeni Çiftçi Ekle";
            // 
            // FrmCiftciEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(354, 518);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmCiftciEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCiftciEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEkle;
        private TextBox txtEmail;
        private Label label5;
    }
}
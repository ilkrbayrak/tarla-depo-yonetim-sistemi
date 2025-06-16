namespace TarlaDepoSistemi
{
    partial class FrmCiftciGuncelle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            btnKaydet = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 142);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 204);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 261);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 319);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.AliceBlue;
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.Location = new Point(126, 139);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 23);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.AliceBlue;
            txtSoyad.BorderStyle = BorderStyle.None;
            txtSoyad.Location = new Point(126, 201);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(177, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.AliceBlue;
            txtTelefon.BorderStyle = BorderStyle.None;
            txtTelefon.Location = new Point(126, 258);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(177, 23);
            txtTelefon.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AliceBlue;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(126, 316);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(126, 402);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(177, 68);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "💾 Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(34, 38);
            label5.Name = "label5";
            label5.Size = new Size(321, 31);
            label5.TabIndex = 9;
            label5.Text = "✏️ Çiftçi Bilgilerini Güncelle";
            // 
            // FrmCiftciGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(375, 518);
            Controls.Add(label5);
            Controls.Add(btnKaydet);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmCiftciGuncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCiftciGuncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private Button btnKaydet;
        private Label label5;
    }
}
namespace TarlaDepoSistemi
{
    partial class FrmUrunEkle
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
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbUrunTuru = new ComboBox();
            txtSaklamaSuresi = new TextBox();
            txtUrunAdi = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(185, 365);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(170, 79);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "➕ Ekle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 133);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 205);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 2;
            label2.Text = "Saklama Süresi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 275);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 3;
            label3.Text = "Ürün Türü";
            // 
            // cmbUrunTuru
            // 
            cmbUrunTuru.BackColor = Color.AliceBlue;
            cmbUrunTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunTuru.FormattingEnabled = true;
            cmbUrunTuru.Location = new Point(185, 272);
            cmbUrunTuru.Name = "cmbUrunTuru";
            cmbUrunTuru.Size = new Size(170, 31);
            cmbUrunTuru.TabIndex = 4;
            cmbUrunTuru.SelectedIndexChanged += cmbUrunTuru_SelectedIndexChanged;
            cmbUrunTuru.DropDownStyleChanged += FrmUrunEkle_Load;
            // 
            // txtSaklamaSuresi
            // 
            txtSaklamaSuresi.BackColor = Color.AliceBlue;
            txtSaklamaSuresi.BorderStyle = BorderStyle.None;
            txtSaklamaSuresi.Location = new Point(185, 202);
            txtSaklamaSuresi.Name = "txtSaklamaSuresi";
            txtSaklamaSuresi.Size = new Size(169, 23);
            txtSaklamaSuresi.TabIndex = 5;
            txtSaklamaSuresi.TextChanged += txtSaklamaSuresi_TextChanged;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.AliceBlue;
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Location = new Point(185, 130);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(169, 23);
            txtUrunAdi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(67, 33);
            label4.Name = "label4";
            label4.Size = new Size(317, 46);
            label4.TabIndex = 7;
            label4.Text = "\U0001f9fa Yeni Ürün Ekle";
            // 
            // FrmUrunEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(441, 518);
            Controls.Add(label4);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtSaklamaSuresi);
            Controls.Add(cmbUrunTuru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmUrunEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUrunEkle";
            Load += FrmUrunEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbUrunTuru;
        private TextBox txtSaklamaSuresi;
        private TextBox txtUrunAdi;
        private Label label4;
    }
}
namespace TarlaDepoSistemi
{
    partial class FrmUrunGuncelle
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
            button1 = new Button();
            cmbUrunTuru = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUrunAdi = new TextBox();
            txtSaklamaSuresi = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(208, 375);
            button1.Name = "button1";
            button1.Size = new Size(170, 74);
            button1.TabIndex = 0;
            button1.Text = "💾 Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbUrunTuru
            // 
            cmbUrunTuru.BackColor = Color.AliceBlue;
            cmbUrunTuru.FormattingEnabled = true;
            cmbUrunTuru.Location = new Point(208, 296);
            cmbUrunTuru.Name = "cmbUrunTuru";
            cmbUrunTuru.Size = new Size(170, 31);
            cmbUrunTuru.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 299);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 2;
            label1.Text = "Ürün Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 215);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 3;
            label2.Text = "Saklama Süresi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 139);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 4;
            label3.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BackColor = Color.AliceBlue;
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Location = new Point(208, 139);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(169, 23);
            txtUrunAdi.TabIndex = 5;
            // 
            // txtSaklamaSuresi
            // 
            txtSaklamaSuresi.BackColor = Color.AliceBlue;
            txtSaklamaSuresi.BorderStyle = BorderStyle.None;
            txtSaklamaSuresi.Location = new Point(208, 215);
            txtSaklamaSuresi.Name = "txtSaklamaSuresi";
            txtSaklamaSuresi.Size = new Size(169, 23);
            txtSaklamaSuresi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 34);
            label4.Name = "label4";
            label4.Size = new Size(427, 41);
            label4.TabIndex = 7;
            label4.Text = "✏️ Ürün Bilgilerini Güncelle";
            // 
            // FrmUrunGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(446, 518);
            Controls.Add(label4);
            Controls.Add(txtSaklamaSuresi);
            Controls.Add(txtUrunAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUrunTuru);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmUrunGuncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUrunGuncelle";
            Load += FrmUrunGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cmbUrunTuru;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUrunAdi;
        private TextBox txtSaklamaSuresi;
        private Label label4;
    }
}
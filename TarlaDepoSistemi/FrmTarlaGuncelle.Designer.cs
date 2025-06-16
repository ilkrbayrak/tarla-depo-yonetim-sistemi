namespace TarlaDepoSistemi
{
    partial class FrmTarlaGuncelle
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
            cmbCiftci = new ComboBox();
            txtKonum = new TextBox();
            txtTarlaAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(200, 370);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(170, 88);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "💾 Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbCiftci
            // 
            cmbCiftci.BackColor = Color.AliceBlue;
            cmbCiftci.FormattingEnabled = true;
            cmbCiftci.Location = new Point(200, 290);
            cmbCiftci.Name = "cmbCiftci";
            cmbCiftci.Size = new Size(170, 31);
            cmbCiftci.TabIndex = 1;
            // 
            // txtKonum
            // 
            txtKonum.BackColor = Color.AliceBlue;
            txtKonum.BorderStyle = BorderStyle.None;
            txtKonum.Location = new Point(200, 206);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(170, 23);
            txtKonum.TabIndex = 2;
            // 
            // txtTarlaAdi
            // 
            txtTarlaAdi.BackColor = Color.AliceBlue;
            txtTarlaAdi.BorderStyle = BorderStyle.None;
            txtTarlaAdi.Location = new Point(200, 125);
            txtTarlaAdi.Name = "txtTarlaAdi";
            txtTarlaAdi.Size = new Size(170, 23);
            txtTarlaAdi.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 128);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 4;
            label1.Text = "Tarla Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 209);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 5;
            label2.Text = "Konum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 293);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 6;
            label3.Text = "Çiftçi seçmek için";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 37);
            label4.Name = "label4";
            label4.Size = new Size(408, 38);
            label4.TabIndex = 7;
            label4.Text = "✏️ Tarla Bilgilerini Güncelle";
            // 
            // FrmTarlaGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(423, 518);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTarlaAdi);
            Controls.Add(txtKonum);
            Controls.Add(cmbCiftci);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmTarlaGuncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmTarlaGuncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private ComboBox cmbCiftci;
        private TextBox txtKonum;
        private TextBox txtTarlaAdi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
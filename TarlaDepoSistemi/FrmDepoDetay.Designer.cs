namespace TarlaDepoSistemi
{
    partial class FrmDepoDetay
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
            cbCiftci = new ComboBox();
            cbUrun = new ComboBox();
            cbTarla = new ComboBox();
            cbDepo = new ComboBox();
            cbIslemTuru = new ComboBox();
            nudMiktar = new NumericUpDown();
            dtpTarih = new DateTimePicker();
            btnIslemEkle = new Button();
            dgvDepoDetay = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rtbStokDurumu = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepoDetay).BeginInit();
            SuspendLayout();
            // 
            // cbCiftci
            // 
            cbCiftci.BackColor = Color.AliceBlue;
            cbCiftci.FormattingEnabled = true;
            cbCiftci.Location = new Point(163, 117);
            cbCiftci.Name = "cbCiftci";
            cbCiftci.Size = new Size(151, 28);
            cbCiftci.TabIndex = 0;
            cbCiftci.SelectedIndexChanged += cbCiftci_SelectedIndexChanged;
            // 
            // cbUrun
            // 
            cbUrun.BackColor = Color.AliceBlue;
            cbUrun.FormattingEnabled = true;
            cbUrun.Location = new Point(164, 151);
            cbUrun.Name = "cbUrun";
            cbUrun.Size = new Size(151, 28);
            cbUrun.TabIndex = 1;
            // 
            // cbTarla
            // 
            cbTarla.BackColor = Color.AliceBlue;
            cbTarla.FormattingEnabled = true;
            cbTarla.Location = new Point(163, 185);
            cbTarla.Name = "cbTarla";
            cbTarla.Size = new Size(151, 28);
            cbTarla.TabIndex = 2;
            // 
            // cbDepo
            // 
            cbDepo.BackColor = Color.AliceBlue;
            cbDepo.FormattingEnabled = true;
            cbDepo.Location = new Point(163, 219);
            cbDepo.Name = "cbDepo";
            cbDepo.Size = new Size(151, 28);
            cbDepo.TabIndex = 3;
            // 
            // cbIslemTuru
            // 
            cbIslemTuru.BackColor = Color.AliceBlue;
            cbIslemTuru.FormattingEnabled = true;
            cbIslemTuru.Location = new Point(164, 253);
            cbIslemTuru.Name = "cbIslemTuru";
            cbIslemTuru.Size = new Size(151, 28);
            cbIslemTuru.TabIndex = 4;
            cbIslemTuru.SelectedIndexChanged += cbIslemTuru_SelectedIndexChanged;
            // 
            // nudMiktar
            // 
            nudMiktar.BackColor = Color.AliceBlue;
            nudMiktar.Location = new Point(164, 287);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 5;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(65, 320);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 6;
            // 
            // btnIslemEkle
            // 
            btnIslemEkle.BackColor = SystemColors.ActiveCaption;
            btnIslemEkle.Location = new Point(171, 353);
            btnIslemEkle.Name = "btnIslemEkle";
            btnIslemEkle.Size = new Size(150, 69);
            btnIslemEkle.TabIndex = 7;
            btnIslemEkle.Text = "Kayıt butonu\n";
            btnIslemEkle.UseVisualStyleBackColor = false;
            btnIslemEkle.Click += btnIslemEkle_Click;
            // 
            // dgvDepoDetay
            // 
            dgvDepoDetay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDepoDetay.BorderStyle = BorderStyle.None;
            dgvDepoDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepoDetay.Location = new Point(327, 117);
            dgvDepoDetay.Name = "dgvDepoDetay";
            dgvDepoDetay.RowHeadersWidth = 51;
            dgvDepoDetay.Size = new Size(957, 510);
            dgvDepoDetay.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 120);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 10;
            label2.Text = "Çiftçi seçimi\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 154);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 11;
            label3.Text = "Ürün seçimi\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 188);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 12;
            label4.Text = "Tarla seçimi\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 222);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 13;
            label5.Text = "Depo seçimi\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 256);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 14;
            label6.Text = "\"Giriş\" / \"Çıkış\"\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 289);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "Miktar\n";
            // 
            // rtbStokDurumu
            // 
            rtbStokDurumu.Location = new Point(12, 428);
            rtbStokDurumu.Name = "rtbStokDurumu";
            rtbStokDurumu.ReadOnly = true;
            rtbStokDurumu.Size = new Size(302, 199);
            rtbStokDurumu.TabIndex = 16;
            rtbStokDurumu.Text = "";
            rtbStokDurumu.TextChanged += rtbStokDurumu_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(354, 29);
            label1.Name = "label1";
            label1.Size = new Size(602, 54);
            label1.TabIndex = 17;
            label1.Text = "🔍 Depo Giriş / Çıkış Kayıtları";
            // 
            // FrmDepoDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1296, 639);
            Controls.Add(label1);
            Controls.Add(rtbStokDurumu);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDepoDetay);
            Controls.Add(btnIslemEkle);
            Controls.Add(dtpTarih);
            Controls.Add(nudMiktar);
            Controls.Add(cbIslemTuru);
            Controls.Add(cbDepo);
            Controls.Add(cbTarla);
            Controls.Add(cbUrun);
            Controls.Add(cbCiftci);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmDepoDetay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDepoDetay";
            Load += FrmDepoDetay_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepoDetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCiftci;
        private ComboBox cbUrun;
        private ComboBox cbTarla;
        private ComboBox cbDepo;
        private ComboBox cbIslemTuru;
        private NumericUpDown nudMiktar;
        private DateTimePicker dtpTarih;
        private Button btnIslemEkle;
        private DataGridView dgvDepoDetay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox rtbStokDurumu;
        private Label label1;
    }
}
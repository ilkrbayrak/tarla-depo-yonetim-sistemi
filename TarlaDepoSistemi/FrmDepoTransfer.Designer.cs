namespace TarlaDepoSistemi
{
    partial class FrmDepoTransfer
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
            btnTransferEt = new Button();
            cbKaynakDepo = new ComboBox();
            cbHedefDepo = new ComboBox();
            cbUrun = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMevcutStok = new Label();
            nudMiktar = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // btnTransferEt
            // 
            btnTransferEt.Location = new Point(328, 415);
            btnTransferEt.Name = "btnTransferEt";
            btnTransferEt.Size = new Size(168, 60);
            btnTransferEt.TabIndex = 0;
            btnTransferEt.Text = "🚚 Transferi Başlat";
            btnTransferEt.UseVisualStyleBackColor = true;
            btnTransferEt.Click += btnTransferEt_Click;
            // 
            // cbKaynakDepo
            // 
            cbKaynakDepo.FormattingEnabled = true;
            cbKaynakDepo.Location = new Point(328, 134);
            cbKaynakDepo.Name = "cbKaynakDepo";
            cbKaynakDepo.Size = new Size(168, 31);
            cbKaynakDepo.TabIndex = 1;
            cbKaynakDepo.SelectedIndexChanged += cbKaynakDepo_SelectedIndexChanged_1;
            // 
            // cbHedefDepo
            // 
            cbHedefDepo.FormattingEnabled = true;
            cbHedefDepo.Location = new Point(328, 204);
            cbHedefDepo.Name = "cbHedefDepo";
            cbHedefDepo.Size = new Size(168, 31);
            cbHedefDepo.TabIndex = 2;
            // 
            // cbUrun
            // 
            cbUrun.FormattingEnabled = true;
            cbUrun.Location = new Point(328, 276);
            cbUrun.Name = "cbUrun";
            cbUrun.Size = new Size(168, 31);
            cbUrun.TabIndex = 3;
            cbUrun.SelectedIndexChanged += cbUrun_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 137);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 4;
            label1.Text = "Ürün çıkış yapılacak depo\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 207);
            label2.Name = "label2";
            label2.Size = new Size(202, 23);
            label2.TabIndex = 5;
            label2.Text = "Ürün giriş yapılacak depo\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 279);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 6;
            label3.Text = "Hangi ürün taşınacak\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 353);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 7;
            label4.Text = "Kaç adet\n";
            label4.Click += label4_Click;
            // 
            // lblMevcutStok
            // 
            lblMevcutStok.AutoSize = true;
            lblMevcutStok.BackColor = SystemColors.Control;
            lblMevcutStok.Location = new Point(560, 71);
            lblMevcutStok.Name = "lblMevcutStok";
            lblMevcutStok.Size = new Size(253, 46);
            lblMevcutStok.TabIndex = 8;
            lblMevcutStok.Text = "Kaynak depodaki mevcut miktar\n\n";
            lblMevcutStok.Click += label5_Click;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(328, 351);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(169, 30);
            nudMiktar.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(59, 35);
            label5.Name = "label5";
            label5.Size = new Size(437, 38);
            label5.TabIndex = 10;
            label5.Text = "🔁 Depolar Arası Ürün Transferi";
            // 
            // FrmDepoTransfer
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(876, 518);
            Controls.Add(label5);
            Controls.Add(nudMiktar);
            Controls.Add(lblMevcutStok);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbUrun);
            Controls.Add(cbHedefDepo);
            Controls.Add(cbKaynakDepo);
            Controls.Add(btnTransferEt);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmDepoTransfer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDepoTransfer";
            Load += FrmDepoTransfer_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransferEt;
        private ComboBox cbKaynakDepo;
        private ComboBox cbHedefDepo;
        private ComboBox cbUrun;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMevcutStok;
        private NumericUpDown nudMiktar;
        private Label label5;
    }
}
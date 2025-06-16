namespace TarlaDepoSistemi
{
    partial class FrmDepoEkle
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
            nudKapasite = new NumericUpDown();
            btnKaydet = new Button();
            txtDepoAdi = new TextBox();
            txtKonum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudKapasite).BeginInit();
            SuspendLayout();
            // 
            // nudKapasite
            // 
            nudKapasite.BackColor = Color.AliceBlue;
            nudKapasite.BorderStyle = BorderStyle.None;
            nudKapasite.Location = new Point(169, 285);
            nudKapasite.Name = "nudKapasite";
            nudKapasite.Size = new Size(169, 26);
            nudKapasite.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(169, 373);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(169, 67);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "💾 Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // txtDepoAdi
            // 
            txtDepoAdi.BackColor = Color.AliceBlue;
            txtDepoAdi.BorderStyle = BorderStyle.None;
            txtDepoAdi.Location = new Point(169, 131);
            txtDepoAdi.Name = "txtDepoAdi";
            txtDepoAdi.Size = new Size(168, 23);
            txtDepoAdi.TabIndex = 2;
            // 
            // txtKonum
            // 
            txtKonum.BackColor = Color.AliceBlue;
            txtKonum.BorderStyle = BorderStyle.None;
            txtKonum.Location = new Point(169, 209);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(168, 23);
            txtKonum.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 135);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 4;
            label1.Text = "Depo adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 213);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 5;
            label2.Text = "Konum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 288);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 6;
            label3.Text = "Kapasite";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(26, 33);
            label4.Name = "label4";
            label4.Size = new Size(324, 46);
            label4.TabIndex = 7;
            label4.Text = "➕ Yeni Depo Ekle";
            // 
            // FrmDepoEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(378, 518);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKonum);
            Controls.Add(txtDepoAdi);
            Controls.Add(btnKaydet);
            Controls.Add(nudKapasite);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "FrmDepoEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDepoEkle";
            Load += FrmDepoEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nudKapasite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudKapasite;
        private Button btnKaydet;
        private TextBox txtDepoAdi;
        private TextBox txtKonum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
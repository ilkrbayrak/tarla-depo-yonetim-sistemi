namespace TarlaDepoSistemi
{
    partial class FrmDepo
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
            dgvDepolar = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).BeginInit();
            SuspendLayout();
            // 
            // dgvDepolar
            // 
            dgvDepolar.BorderStyle = BorderStyle.None;
            dgvDepolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepolar.Location = new Point(14, 68);
            dgvDepolar.Name = "dgvDepolar";
            dgvDepolar.RowHeadersWidth = 51;
            dgvDepolar.Size = new Size(568, 315);
            dgvDepolar.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(610, 68);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 87);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += button1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaption;
            btnGuncelle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(610, 183);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 86);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaption;
            btnSil.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(610, 305);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 80);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 41);
            label1.TabIndex = 4;
            label1.Text = "🏢 Depo İşlemleri";
            label1.Click += label1_Click;
            // 
            // FrmDepo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(766, 397);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvDepolar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDepo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDepo";
            Load += FrmDepo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepolar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDepolar;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
    }
}
namespace TarlaDepoSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCiftciler = new Button();
            btnTarlalar = new Button();
            btnDepolar = new Button();
            button4 = new Button();
            btnDepoDetay = new Button();
            btnDepoTransfer = new Button();
            lblBaslik = new Label();
            SuspendLayout();
            // 
            // btnCiftciler
            // 
            btnCiftciler.BackColor = SystemColors.ActiveCaption;
            btnCiftciler.FlatStyle = FlatStyle.Flat;
            btnCiftciler.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCiftciler.ForeColor = SystemColors.ButtonHighlight;
            btnCiftciler.Image = Properties.Resources.icons8_farmer_48;
            btnCiftciler.ImageAlign = ContentAlignment.MiddleLeft;
            btnCiftciler.Location = new Point(126, 204);
            btnCiftciler.Margin = new Padding(4);
            btnCiftciler.Name = "btnCiftciler";
            btnCiftciler.Size = new Size(248, 168);
            btnCiftciler.TabIndex = 0;
            btnCiftciler.Text = "Çiftçiler";
            btnCiftciler.TextAlign = ContentAlignment.MiddleRight;
            btnCiftciler.UseVisualStyleBackColor = false;
            btnCiftciler.Click += button1_Click;
            // 
            // btnTarlalar
            // 
            btnTarlalar.BackColor = SystemColors.ActiveCaption;
            btnTarlalar.FlatStyle = FlatStyle.Flat;
            btnTarlalar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTarlalar.ForeColor = SystemColors.ButtonHighlight;
            btnTarlalar.Image = Properties.Resources.icons8_field_48;
            btnTarlalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnTarlalar.Location = new Point(644, 204);
            btnTarlalar.Margin = new Padding(4);
            btnTarlalar.Name = "btnTarlalar";
            btnTarlalar.Size = new Size(235, 168);
            btnTarlalar.TabIndex = 1;
            btnTarlalar.Text = "Tarlalar";
            btnTarlalar.TextAlign = ContentAlignment.MiddleRight;
            btnTarlalar.UseVisualStyleBackColor = false;
            btnTarlalar.Click += button2_Click;
            // 
            // btnDepolar
            // 
            btnDepolar.BackColor = SystemColors.ActiveCaption;
            btnDepolar.FlatStyle = FlatStyle.Flat;
            btnDepolar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepolar.ForeColor = SystemColors.ButtonHighlight;
            btnDepolar.Image = Properties.Resources.icons8_warehouse_48;
            btnDepolar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepolar.Location = new Point(126, 380);
            btnDepolar.Margin = new Padding(4);
            btnDepolar.Name = "btnDepolar";
            btnDepolar.Size = new Size(248, 168);
            btnDepolar.TabIndex = 2;
            btnDepolar.Text = "Depolar";
            btnDepolar.TextAlign = ContentAlignment.MiddleRight;
            btnDepolar.UseVisualStyleBackColor = false;
            btnDepolar.Click += btnDepolar_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.icons8_product_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(382, 204);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(254, 168);
            button4.TabIndex = 3;
            button4.Text = "Ürünler";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnDepoDetay
            // 
            btnDepoDetay.BackColor = SystemColors.ActiveCaption;
            btnDepoDetay.FlatStyle = FlatStyle.Flat;
            btnDepoDetay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoDetay.ForeColor = SystemColors.ButtonHighlight;
            btnDepoDetay.Image = Properties.Resources.icons8_detail_48;
            btnDepoDetay.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepoDetay.Location = new Point(382, 381);
            btnDepoDetay.Margin = new Padding(4);
            btnDepoDetay.Name = "btnDepoDetay";
            btnDepoDetay.Size = new Size(254, 168);
            btnDepoDetay.TabIndex = 4;
            btnDepoDetay.Text = "Depo \r\nDetay";
            btnDepoDetay.TextAlign = ContentAlignment.MiddleRight;
            btnDepoDetay.UseVisualStyleBackColor = false;
            btnDepoDetay.Click += btnDepoDetay_Click;
            // 
            // btnDepoTransfer
            // 
            btnDepoTransfer.BackColor = SystemColors.ActiveCaption;
            btnDepoTransfer.FlatStyle = FlatStyle.Flat;
            btnDepoTransfer.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDepoTransfer.ForeColor = SystemColors.ButtonHighlight;
            btnDepoTransfer.Image = Properties.Resources.icons8_transfer_64;
            btnDepoTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepoTransfer.Location = new Point(644, 380);
            btnDepoTransfer.Margin = new Padding(4);
            btnDepoTransfer.Name = "btnDepoTransfer";
            btnDepoTransfer.Size = new Size(235, 168);
            btnDepoTransfer.TabIndex = 5;
            btnDepoTransfer.Text = "Depolar Arası Transfer";
            btnDepoTransfer.TextAlign = ContentAlignment.MiddleRight;
            btnDepoTransfer.UseVisualStyleBackColor = false;
            btnDepoTransfer.Click += btnDepoTransfer_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(64, 64, 64);
            lblBaslik.Image = Properties.Resources.icons8_management_system_100;
            lblBaslik.Location = new Point(196, -27);
            lblBaslik.Margin = new Padding(4, 0, 4, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(601, 180);
            lblBaslik.TabIndex = 6;
            lblBaslik.Text = "\r\n\r\nTarla Depo Yönetim Sistemi\r\n";
            lblBaslik.TextAlign = ContentAlignment.BottomCenter;
            lblBaslik.Click += lblBaslik_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1000, 562);
            Controls.Add(lblBaslik);
            Controls.Add(btnDepoTransfer);
            Controls.Add(btnDepoDetay);
            Controls.Add(button4);
            Controls.Add(btnDepolar);
            Controls.Add(btnTarlalar);
            Controls.Add(btnCiftciler);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCiftciler;
        private Button btnTarlalar;
        private Button btnDepolar;
        private Button button4;
        private Button btnDepoDetay;
        private Button btnDepoTransfer;
        private Label lblBaslik;
    }
}

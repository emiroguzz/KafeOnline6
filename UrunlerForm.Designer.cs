namespace KafeOnline6
{
    partial class UrunlerForm
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
            dgvUrunler=new DataGridView();
            txtUrunAd=new TextBox();
            label1=new Label();
            label2=new Label();
            nudBirimFiyat=new NumericUpDown();
            btnEkle=new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location=new Point(12, 80);
            dgvUrunler.Name="dgvUrunler";
            dgvUrunler.RowTemplate.Height=25;
            dgvUrunler.Size=new Size(383, 358);
            dgvUrunler.TabIndex=0;
            // 
            // txtUrunAd
            // 
            txtUrunAd.BorderStyle=BorderStyle.FixedSingle;
            txtUrunAd.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrunAd.Location=new Point(12, 33);
            txtUrunAd.Name="txtUrunAd";
            txtUrunAd.Size=new Size(152, 29);
            txtUrunAd.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(72, 21);
            label1.TabIndex=2;
            label1.Text="Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(170, 9);
            label2.Name="label2";
            label2.Size=new Size(107, 21);
            label2.TabIndex=3;
            label2.Text="Birim Fiyatı(₺)";
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudBirimFiyat.Location=new Point(170, 33);
            nudBirimFiyat.Maximum=new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBirimFiyat.Name="nudBirimFiyat";
            nudBirimFiyat.Size=new Size(120, 29);
            nudBirimFiyat.TabIndex=4;
            // 
            // btnEkle
            // 
            btnEkle.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location=new Point(296, 33);
            btnEkle.Name="btnEkle";
            btnEkle.Size=new Size(99, 30);
            btnEkle.TabIndex=5;
            btnEkle.Text="EKLE";
            btnEkle.UseVisualStyleBackColor=true;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(407, 456);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUrunAd);
            Controls.Add(dgvUrunler);
            Name="UrunlerForm";
            StartPosition=FormStartPosition.CenterParent;
            Text="Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUrunler;
        private TextBox txtUrunAd;
        private Label label1;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
    }
}
namespace KafeOnline6
{
    partial class SiparisForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnDetayEkle=new Button();
            nudAdet=new NumericUpDown();
            label2=new Label();
            label1=new Label();
            dgvDetaylar=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            cboUrun=new ComboBox();
            cboMasaNo=new ComboBox();
            label3=new Label();
            btnMasaTasi=new Button();
            btnAnasayfayaDon=new Button();
            btnSiparisIptal=new Button();
            btnOdemeAl=new Button();
            label4=new Label();
            lblMasaNo=new Label();
            lblOdemeTutarı=new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetayEkle.Location=new Point(372, 33);
            btnDetayEkle.Name="btnDetayEkle";
            btnDetayEkle.Size=new Size(85, 29);
            btnDetayEkle.TabIndex=5;
            btnDetayEkle.Text="EKLE";
            btnDetayEkle.UseVisualStyleBackColor=true;
            btnDetayEkle.Click+=btnDetayEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudAdet.Location=new Point(246, 34);
            nudAdet.Maximum=new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name="nudAdet";
            nudAdet.Size=new Size(120, 29);
            nudAdet.TabIndex=4;
            nudAdet.Value=new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(246, 9);
            label2.Name="label2";
            label2.Size=new Size(42, 21);
            label2.TabIndex=1;
            label2.Text="Adet";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(15, 10);
            label1.Name="label1";
            label1.Size=new Size(45, 21);
            label1.TabIndex=0;
            label1.Text="Ürün";
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows=false;
            dgvDetaylar.AllowUserToDeleteRows=false;
            dgvDetaylar.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.Location=new Point(15, 70);
            dgvDetaylar.MultiSelect=false;
            dgvDetaylar.Name="dgvDetaylar";
            dgvDetaylar.ReadOnly=true;
            dgvDetaylar.RowHeadersVisible=false;
            dgvDetaylar.RowTemplate.Height=25;
            dgvDetaylar.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size=new Size(505, 413);
            dgvDetaylar.TabIndex=8;
            dgvDetaylar.KeyDown+=dgvDetaylar_KeyDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName="UrunAd";
            Column1.HeaderText="Ürün Ad";
            Column1.Name="Column1";
            Column1.ReadOnly=true;
            // 
            // Column2
            // 
            Column2.DataPropertyName="BirimFiyat";
            dataGridViewCellStyle1.Format="c2";
            dataGridViewCellStyle1.NullValue=null;
            Column2.DefaultCellStyle=dataGridViewCellStyle1;
            Column2.HeaderText="Birim Fiyat";
            Column2.Name="Column2";
            Column2.ReadOnly=true;
            // 
            // Column3
            // 
            Column3.DataPropertyName="Adet";
            Column3.HeaderText="Adet";
            Column3.Name="Column3";
            Column3.ReadOnly=true;
            // 
            // Column4
            // 
            Column4.DataPropertyName="TutarTL";
            Column4.HeaderText="Tutar";
            Column4.Name="Column4";
            Column4.ReadOnly=true;
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle=ComboBoxStyle.DropDownList;
            cboUrun.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboUrun.FormattingEnabled=true;
            cboUrun.Location=new Point(15, 34);
            cboUrun.Name="cboUrun";
            cboUrun.Size=new Size(225, 29);
            cboUrun.TabIndex=3;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            cboMasaNo.DropDownStyle=ComboBoxStyle.DropDownList;
            cboMasaNo.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMasaNo.FormattingEnabled=true;
            cboMasaNo.Location=new Point(617, 34);
            cboMasaNo.Name="cboMasaNo";
            cboMasaNo.Size=new Size(111, 29);
            cboMasaNo.TabIndex=6;
            // 
            // label3
            // 
            label3.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(617, 9);
            label3.Name="label3";
            label3.Size=new Size(72, 21);
            label3.TabIndex=2;
            label3.Text="Masa No";
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            btnMasaTasi.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasaTasi.Location=new Point(734, 34);
            btnMasaTasi.Name="btnMasaTasi";
            btnMasaTasi.Size=new Size(87, 29);
            btnMasaTasi.TabIndex=7;
            btnMasaTasi.Text="TAŞI";
            btnMasaTasi.UseVisualStyleBackColor=true;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnAnasayfayaDon.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnasayfayaDon.Location=new Point(530, 414);
            btnAnasayfayaDon.Name="btnAnasayfayaDon";
            btnAnasayfayaDon.Size=new Size(292, 67);
            btnAnasayfayaDon.TabIndex=14;
            btnAnasayfayaDon.Text="ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor=true;
            btnAnasayfayaDon.Click+=btnAnasayfayaDon_Click;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnSiparisIptal.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisIptal.Location=new Point(530, 352);
            btnSiparisIptal.Name="btnSiparisIptal";
            btnSiparisIptal.Size=new Size(145, 56);
            btnSiparisIptal.TabIndex=12;
            btnSiparisIptal.Text="SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor=true;
            btnSiparisIptal.Click+=btnSiparisIptal_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnOdemeAl.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOdemeAl.Location=new Point(681, 352);
            btnOdemeAl.Name="btnOdemeAl";
            btnOdemeAl.Size=new Size(141, 56);
            btnOdemeAl.TabIndex=13;
            btnOdemeAl.Text="ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor=true;
            btnOdemeAl.Click+=btnOdemeAl_Click;
            // 
            // label4
            // 
            label4.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            label4.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(530, 299);
            label4.Name="label4";
            label4.Size=new Size(145, 23);
            label4.TabIndex=10;
            label4.Text="Ödeme Tutarı:";
            label4.TextAlign=ContentAlignment.MiddleRight;
            // 
            // lblMasaNo
            // 
            lblMasaNo.BackColor=Color.Tomato;
            lblMasaNo.BorderStyle=BorderStyle.FixedSingle;
            lblMasaNo.Font=new Font("Segoe UI Variable Display", 90F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor=Color.White;
            lblMasaNo.Location=new Point(530, 70);
            lblMasaNo.Name="lblMasaNo";
            lblMasaNo.Size=new Size(292, 210);
            lblMasaNo.TabIndex=9;
            lblMasaNo.Text="00";
            lblMasaNo.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutarı
            // 
            lblOdemeTutarı.Anchor=AnchorStyles.Left|AnchorStyles.Right;
            lblOdemeTutarı.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutarı.Location=new Point(681, 299);
            lblOdemeTutarı.Name="lblOdemeTutarı";
            lblOdemeTutarı.Size=new Size(140, 23);
            lblOdemeTutarı.TabIndex=11;
            lblOdemeTutarı.Text="₺0,00";
            lblOdemeTutarı.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(834, 493);
            Controls.Add(lblOdemeTutarı);
            Controls.Add(lblMasaNo);
            Controls.Add(label4);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label3);
            Controls.Add(cboUrun);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Controls.Add(nudAdet);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize=new Size(850, 532);
            Name="SiparisForm";
            StartPosition=FormStartPosition.CenterParent;
            Text="SiparisForm";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetayEkle;
        private NumericUpDown nudAdet;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetaylar;
        private ComboBox cboUrun;
        private ComboBox cboMasaNo;
        private Label label3;
        private Button btnMasaTasi;
        private Button btnAnasayfayaDon;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Label label4;
        private Label lblMasaNo;
        private Label lblOdemeTutarı;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
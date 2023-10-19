namespace KafeOnline6
{
    partial class GecmisSiparislerForm
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
            label1=new Label();
            dgvSiparişler=new DataGridView();
            label2=new Label();
            splitContainer1=new SplitContainer();
            dgvSiparisDetaylar=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSiparişler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(75, 21);
            label1.TabIndex=0;
            label1.Text="Siparişler";
            // 
            // dgvSiparişler
            // 
            dgvSiparişler.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvSiparişler.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparişler.Location=new Point(15, 33);
            dgvSiparişler.Name="dgvSiparişler";
            dgvSiparişler.RowTemplate.Height=25;
            dgvSiparişler.Size=new Size(857, 217);
            dgvSiparişler.TabIndex=1;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(12, 12);
            label2.Name="label2";
            label2.Size=new Size(123, 21);
            label2.TabIndex=2;
            label2.Text="Sipariş Detayları";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock=DockStyle.Fill;
            splitContainer1.Location=new Point(0, 0);
            splitContainer1.Name="splitContainer1";
            splitContainer1.Orientation=Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvSiparişler);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvSiparisDetaylar);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size=new Size(884, 538);
            splitContainer1.SplitterDistance=269;
            splitContainer1.TabIndex=4;
            // 
            // dgvSiparisDetaylar
            // 
            dgvSiparisDetaylar.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgvSiparisDetaylar.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisDetaylar.Location=new Point(12, 36);
            dgvSiparisDetaylar.Name="dgvSiparisDetaylar";
            dgvSiparisDetaylar.RowTemplate.Height=25;
            dgvSiparisDetaylar.Size=new Size(860, 217);
            dgvSiparisDetaylar.TabIndex=3;
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(884, 538);
            Controls.Add(splitContainer1);
            Name="GecmisSiparislerForm";
            StartPosition=FormStartPosition.CenterParent;
            Text="Geçmiş Siparişler";
            ((System.ComponentModel.ISupportInitialize)dgvSiparişler).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSiparisDetaylar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvSiparişler;
        private Label label2;
        private SplitContainer splitContainer1;
        private DataGridView dgvSiparisDetaylar;
    }
}
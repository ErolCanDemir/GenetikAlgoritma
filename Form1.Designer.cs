namespace GenetikAlgoritmaOdev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSeckinlik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMutasyon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCaprazlama = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPopulasyon = new System.Windows.Forms.NumericUpDown();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeckinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaprazlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulasyon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MCCORMİCK FUNCTİON";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(235, 63);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(92, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "-3 <= x2 <= 4";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(117, 63);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(100, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "-1.5 <= x1 <=4";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Sınırlar : ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(362, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "F(x1,x2) = sin(x1+x2) + (x1-x2)2 - 1.5 * x1 + 2.5 * x2 +1\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownSeckinlik);
            this.groupBox2.Controls.Add(this.numericUpDownMutasyon);
            this.groupBox2.Controls.Add(this.numericUpDownCaprazlama);
            this.groupBox2.Controls.Add(this.numericUpDownPopulasyon);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VERİLER";
            // 
            // numericUpDownSeckinlik
            // 
            this.numericUpDownSeckinlik.Location = new System.Drawing.Point(215, 99);
            this.numericUpDownSeckinlik.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSeckinlik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeckinlik.Name = "numericUpDownSeckinlik";
            this.numericUpDownSeckinlik.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownSeckinlik.TabIndex = 1;
            this.numericUpDownSeckinlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSeckinlik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMutasyon
            // 
            this.numericUpDownMutasyon.DecimalPlaces = 2;
            this.numericUpDownMutasyon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutasyon.Location = new System.Drawing.Point(215, 73);
            this.numericUpDownMutasyon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutasyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutasyon.Name = "numericUpDownMutasyon";
            this.numericUpDownMutasyon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownMutasyon.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMutasyon.TabIndex = 1;
            this.numericUpDownMutasyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMutasyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownCaprazlama
            // 
            this.numericUpDownCaprazlama.DecimalPlaces = 2;
            this.numericUpDownCaprazlama.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCaprazlama.Location = new System.Drawing.Point(215, 47);
            this.numericUpDownCaprazlama.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCaprazlama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCaprazlama.Name = "numericUpDownCaprazlama";
            this.numericUpDownCaprazlama.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownCaprazlama.TabIndex = 1;
            this.numericUpDownCaprazlama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCaprazlama.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numericUpDownPopulasyon
            // 
            this.numericUpDownPopulasyon.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPopulasyon.Location = new System.Drawing.Point(215, 21);
            this.numericUpDownPopulasyon.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPopulasyon.Name = "numericUpDownPopulasyon";
            this.numericUpDownPopulasyon.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownPopulasyon.TabIndex = 1;
            this.numericUpDownPopulasyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPopulasyon.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(127, 97);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(82, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Seçkinlik  :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(83, 71);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(126, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Mutasyon Oranı  :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(70, 45);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(139, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Çaprazlama Oranı  :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(70, 19);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(139, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Popülasyon Sayısı :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.materialLabel9);
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ALGORİTMA UYGULAMASI";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Depth = 0;
            this.btnHesapla.Location = new System.Drawing.Point(10, 51);
            this.btnHesapla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Primary = true;
            this.btnHesapla.Size = new System.Drawing.Size(355, 43);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(210, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(81, 25);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(123, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "İterasyon Sayısı :";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(389, 74);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(618, 346);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(72, 36);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(21, 19);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "...";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(72, 62);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(21, 19);
            this.materialLabel11.TabIndex = 3;
            this.materialLabel11.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialLabel13);
            this.groupBox4.Controls.Add(this.materialLabel11);
            this.groupBox4.Controls.Add(this.materialLabel12);
            this.groupBox4.Controls.Add(this.materialLabel10);
            this.groupBox4.Location = new System.Drawing.Point(1013, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonuçlar";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(34, 36);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(32, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "x1 :";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(34, 62);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(32, 19);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "x2 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 432);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "McCormik Function Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeckinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaprazlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulasyon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownSeckinlik;
        private System.Windows.Forms.NumericUpDown numericUpDownMutasyon;
        private System.Windows.Forms.NumericUpDown numericUpDownCaprazlama;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulasyon;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRaisedButton btnHesapla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
    }
}


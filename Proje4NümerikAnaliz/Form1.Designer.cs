namespace Proje4NümerikAnaliz
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
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStepSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.lblMemoryUsage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DegerAraligiSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeunSonucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrtaNoktaSonucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(144, 15);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(131, 22);
            this.txtX0.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "BaşlangıçDeğeri X0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaşlangıçDeğeri Y0";
            // 
            // txtY0
            // 
            this.txtY0.Location = new System.Drawing.Point(144, 56);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(131, 22);
            this.txtY0.TabIndex = 2;
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Heun",
            "Midpoint",
            "Ralston"});
            this.cmbMethod.Location = new System.Drawing.Point(420, 15);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(121, 24);
            this.cmbMethod.TabIndex = 4;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DegerAraligiSayisi,
            this.HeunSonucu,
            this.OrtaNoktaSonucu});
            this.dgvResults.Location = new System.Drawing.Point(15, 181);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(934, 592);
            this.dgvResults.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çözüm Yöntemi :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStepSize
            // 
            this.txtStepSize.Location = new System.Drawing.Point(420, 69);
            this.txtStepSize.Name = "txtStepSize";
            this.txtStepSize.Size = new System.Drawing.Size(121, 22);
            this.txtStepSize.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adım Büyüklükleri";
            // 
            // txtV0
            // 
            this.txtV0.Location = new System.Drawing.Point(144, 96);
            this.txtV0.Name = "txtV0";
            this.txtV0.Size = new System.Drawing.Size(131, 22);
            this.txtV0.TabIndex = 10;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(420, 126);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(121, 22);
            this.txtSteps.TabIndex = 11;
            // 
            // lblMemoryUsage
            // 
            this.lblMemoryUsage.AutoSize = true;
            this.lblMemoryUsage.Location = new System.Drawing.Point(592, 132);
            this.lblMemoryUsage.Name = "lblMemoryUsage";
            this.lblMemoryUsage.Size = new System.Drawing.Size(101, 16);
            this.lblMemoryUsage.TabIndex = 12;
            this.lblMemoryUsage.Text = "Hafiza Kullanimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adım";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "BaşlangıçDeğeri V0";
            // 
            // DegerAraligiSayisi
            // 
            this.DegerAraligiSayisi.HeaderText = "DegerAraligiSayisi";
            this.DegerAraligiSayisi.MinimumWidth = 6;
            this.DegerAraligiSayisi.Name = "DegerAraligiSayisi";
            this.DegerAraligiSayisi.Width = 125;
            // 
            // HeunSonucu
            // 
            this.HeunSonucu.HeaderText = "X0";
            this.HeunSonucu.MinimumWidth = 6;
            this.HeunSonucu.Name = "HeunSonucu";
            this.HeunSonucu.Width = 125;
            // 
            // OrtaNoktaSonucu
            // 
            this.OrtaNoktaSonucu.HeaderText = "Y0";
            this.OrtaNoktaSonucu.MinimumWidth = 6;
            this.OrtaNoktaSonucu.Name = "OrtaNoktaSonucu";
            this.OrtaNoktaSonucu.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 785);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMemoryUsage);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.txtV0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStepSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStepSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtV0;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Label lblMemoryUsage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegerAraligiSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeunSonucu;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrtaNoktaSonucu;
    }
}


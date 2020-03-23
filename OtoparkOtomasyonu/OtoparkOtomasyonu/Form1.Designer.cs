namespace OtoparkOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewGüncelBilgi = new System.Windows.Forms.DataGridView();
            this.dateTimePickerSaat = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxYakıtTürü = new System.Windows.Forms.TextBox();
            this.labelYakıtTürü = new System.Windows.Forms.Label();
            this.buttonAbone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxtcn = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGüncelBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(105, 106);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(188, 22);
            this.textBoxPlaka.TabIndex = 3;
            this.textBoxPlaka.TextChanged += new System.EventHandler(this.textBoxPlaka_TextChanged);
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Location = new System.Drawing.Point(104, 48);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(188, 22);
            this.textBoxIsim.TabIndex = 1;
            this.textBoxIsim.TextChanged += new System.EventHandler(this.textBoxIsim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim Soyisim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonTamam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-1, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giriş Zamanı";
            // 
            // dataGridViewGüncelBilgi
            // 
            this.dataGridViewGüncelBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGüncelBilgi.Location = new System.Drawing.Point(331, 12);
            this.dataGridViewGüncelBilgi.Name = "dataGridViewGüncelBilgi";
            this.dataGridViewGüncelBilgi.RowTemplate.Height = 24;
            this.dataGridViewGüncelBilgi.Size = new System.Drawing.Size(933, 449);
            this.dataGridViewGüncelBilgi.TabIndex = 10;
            this.dataGridViewGüncelBilgi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGüncelBilgi_CellContentClick);
            // 
            // dateTimePickerSaat
            // 
            this.dateTimePickerSaat.Location = new System.Drawing.Point(104, 190);
            this.dateTimePickerSaat.Name = "dateTimePickerSaat";
            this.dateTimePickerSaat.Size = new System.Drawing.Size(188, 22);
            this.dateTimePickerSaat.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Giriş Fişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonFis_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Çıkış Fişi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(105, 78);
            this.textBoxTelefon.MaxLength = 11;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(188, 22);
            this.textBoxTelefon.TabIndex = 2;
            this.textBoxTelefon.TextChanged += new System.EventHandler(this.textBoxPlaka_TextChanged);
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(105, 134);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(188, 22);
            this.textBoxMarka.TabIndex = 4;
            this.textBoxMarka.TextChanged += new System.EventHandler(this.textBoxPlaka_TextChanged);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMarka.Location = new System.Drawing.Point(47, 137);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(52, 17);
            this.labelMarka.TabIndex = 0;
            this.labelMarka.Text = "Marka";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(36, 81);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(63, 17);
            this.labelTelefon.TabIndex = 0;
            this.labelTelefon.Text = "Telefon";
            this.labelTelefon.Click += new System.EventHandler(this.labelTelefon_Click);
            // 
            // textBoxYakıtTürü
            // 
            this.textBoxYakıtTürü.Location = new System.Drawing.Point(105, 162);
            this.textBoxYakıtTürü.Name = "textBoxYakıtTürü";
            this.textBoxYakıtTürü.Size = new System.Drawing.Size(188, 22);
            this.textBoxYakıtTürü.TabIndex = 5;
            this.textBoxYakıtTürü.TextChanged += new System.EventHandler(this.textBoxPlaka_TextChanged);
            // 
            // labelYakıtTürü
            // 
            this.labelYakıtTürü.AutoSize = true;
            this.labelYakıtTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYakıtTürü.Location = new System.Drawing.Point(16, 165);
            this.labelYakıtTürü.Name = "labelYakıtTürü";
            this.labelYakıtTürü.Size = new System.Drawing.Size(83, 17);
            this.labelYakıtTürü.TabIndex = 0;
            this.labelYakıtTürü.Text = "Yakıt Türü";
            // 
            // buttonAbone
            // 
            this.buttonAbone.Location = new System.Drawing.Point(75, 358);
            this.buttonAbone.Name = "buttonAbone";
            this.buttonAbone.Size = new System.Drawing.Size(217, 37);
            this.buttonAbone.TabIndex = 11;
            this.buttonAbone.Text = "Abone Ekle";
            this.buttonAbone.UseVisualStyleBackColor = true;
            this.buttonAbone.Click += new System.EventHandler(this.buttonAbone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // textBoxtcn
            // 
            this.textBoxtcn.Location = new System.Drawing.Point(75, 414);
            this.textBoxtcn.Name = "textBoxtcn";
            this.textBoxtcn.Size = new System.Drawing.Size(113, 22);
            this.textBoxtcn.TabIndex = 16;
            this.textBoxtcn.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(218, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 17;
            this.button4.Text = "Giriş";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 523);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxtcn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAbone);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePickerSaat);
            this.Controls.Add(this.dataGridViewGüncelBilgi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYakıtTürü);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.labelYakıtTürü);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Otopark Bilgi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGüncelBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewGüncelBilgi;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxYakıtTürü;
        private System.Windows.Forms.Label labelYakıtTürü;
        private System.Windows.Forms.Button buttonAbone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxtcn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
    }
}


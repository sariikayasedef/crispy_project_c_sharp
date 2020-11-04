namespace Crispy_Project
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnLks = new System.Windows.Forms.Button();
            this.btnLkk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRgbm = new System.Windows.Forms.Button();
            this.btnRgbk = new System.Windows.Forms.Button();
            this.btnRgby = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuzzer = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_ldr = new System.Windows.Forms.Button();
            this.Btn_pot = new System.Windows.Forms.Button();
            this.Btn_sicaklik = new System.Windows.Forms.Button();
            this.Btn_aktif = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLks
            // 
            this.btnLks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLks.Location = new System.Drawing.Point(0, 19);
            this.btnLks.Name = "btnLks";
            this.btnLks.Size = new System.Drawing.Size(70, 43);
            this.btnLks.TabIndex = 0;
            this.btnLks.Text = "SARI";
            this.btnLks.UseVisualStyleBackColor = true;
            this.btnLks.Click += new System.EventHandler(this.btnLks_Click);
            // 
            // btnLkk
            // 
            this.btnLkk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLkk.Location = new System.Drawing.Point(76, 19);
            this.btnLkk.Name = "btnLkk";
            this.btnLkk.Size = new System.Drawing.Size(70, 43);
            this.btnLkk.TabIndex = 1;
            this.btnLkk.Text = "KIRMIZI";
            this.btnLkk.UseVisualStyleBackColor = true;
            this.btnLkk.Click += new System.EventHandler(this.btnLkk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLks);
            this.groupBox1.Controls.Add(this.btnLkk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(27, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED KONTROLÜ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRgbm);
            this.groupBox2.Controls.Add(this.btnRgbk);
            this.groupBox2.Controls.Add(this.btnRgby);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(196, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RGB KONTROLÜ";
            // 
            // btnRgbm
            // 
            this.btnRgbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRgbm.Location = new System.Drawing.Point(152, 19);
            this.btnRgbm.Name = "btnRgbm";
            this.btnRgbm.Size = new System.Drawing.Size(70, 43);
            this.btnRgbm.TabIndex = 2;
            this.btnRgbm.Text = "MAVİ";
            this.btnRgbm.UseVisualStyleBackColor = true;
            this.btnRgbm.Click += new System.EventHandler(this.btnRgbm_Click);
            // 
            // btnRgbk
            // 
            this.btnRgbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRgbk.Location = new System.Drawing.Point(76, 19);
            this.btnRgbk.Name = "btnRgbk";
            this.btnRgbk.Size = new System.Drawing.Size(70, 43);
            this.btnRgbk.TabIndex = 0;
            this.btnRgbk.Text = "YESİL";
            this.btnRgbk.UseVisualStyleBackColor = true;
            this.btnRgbk.Click += new System.EventHandler(this.btnRgbk_Click);
            // 
            // btnRgby
            // 
            this.btnRgby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRgby.Location = new System.Drawing.Point(0, 19);
            this.btnRgby.Name = "btnRgby";
            this.btnRgby.Size = new System.Drawing.Size(70, 43);
            this.btnRgby.TabIndex = 1;
            this.btnRgby.Text = "KIRMIZI";
            this.btnRgby.UseVisualStyleBackColor = true;
            this.btnRgby.Click += new System.EventHandler(this.btnRgby_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCon);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.btn_close);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(11, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERİ HABERLEŞME";
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCon.Location = new System.Drawing.Point(256, 19);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "BAĞLAN";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.Location = new System.Drawing.Point(347, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "KAPAT";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(16, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnBuzzer
            // 
            this.btnBuzzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuzzer.Location = new System.Drawing.Point(27, 177);
            this.btnBuzzer.Name = "btnBuzzer";
            this.btnBuzzer.Size = new System.Drawing.Size(148, 40);
            this.btnBuzzer.TabIndex = 6;
            this.btnBuzzer.Text = "BUZZER";
            this.btnBuzzer.UseVisualStyleBackColor = true;
            this.btnBuzzer.Click += new System.EventHandler(this.btnBuzzer_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(218, 303);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_ldr);
            this.groupBox4.Controls.Add(this.Btn_pot);
            this.groupBox4.Controls.Add(this.Btn_sicaklik);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox4.Location = new System.Drawing.Point(196, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 88);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SICAKLIK - POT - LDR";
            // 
            // Btn_ldr
            // 
            this.Btn_ldr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ldr.Location = new System.Drawing.Point(152, 34);
            this.Btn_ldr.Name = "Btn_ldr";
            this.Btn_ldr.Size = new System.Drawing.Size(70, 43);
            this.Btn_ldr.TabIndex = 3;
            this.Btn_ldr.Text = "LDR";
            this.Btn_ldr.UseVisualStyleBackColor = true;
            this.Btn_ldr.Click += new System.EventHandler(this.Btn_ldr_Click);
            // 
            // Btn_pot
            // 
            this.Btn_pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_pot.Location = new System.Drawing.Point(76, 36);
            this.Btn_pot.Name = "Btn_pot";
            this.Btn_pot.Size = new System.Drawing.Size(70, 43);
            this.Btn_pot.TabIndex = 2;
            this.Btn_pot.Text = "POT";
            this.Btn_pot.UseVisualStyleBackColor = true;
            this.Btn_pot.Click += new System.EventHandler(this.Btn_pot_Click);
            // 
            // Btn_sicaklik
            // 
            this.Btn_sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_sicaklik.Location = new System.Drawing.Point(0, 34);
            this.Btn_sicaklik.Name = "Btn_sicaklik";
            this.Btn_sicaklik.Size = new System.Drawing.Size(70, 43);
            this.Btn_sicaklik.TabIndex = 1;
            this.Btn_sicaklik.Text = "SICAKLIK";
            this.Btn_sicaklik.UseVisualStyleBackColor = true;
            this.Btn_sicaklik.Click += new System.EventHandler(this.Btn_sicaklik_Click);
            // 
            // Btn_aktif
            // 
            this.Btn_aktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btn_aktif.Location = new System.Drawing.Point(27, 228);
            this.Btn_aktif.Name = "Btn_aktif";
            this.Btn_aktif.Size = new System.Drawing.Size(148, 40);
            this.Btn_aktif.TabIndex = 10;
            this.Btn_aktif.Text = "BUTON AKTİF";
            this.Btn_aktif.UseVisualStyleBackColor = true;
            this.Btn_aktif.Click += new System.EventHandler(this.Btn_aktif_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.richTextBox1.Location = new System.Drawing.Point(452, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 247);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = ">Hello World";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 310);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_aktif);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBuzzer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Crispy Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLks;
        private System.Windows.Forms.Button btnLkk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRgbm;
        private System.Windows.Forms.Button btnRgbk;
        private System.Windows.Forms.Button btnRgby;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnBuzzer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_ldr;
        private System.Windows.Forms.Button Btn_pot;
        private System.Windows.Forms.Button Btn_sicaklik;
        private System.Windows.Forms.Button Btn_aktif;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


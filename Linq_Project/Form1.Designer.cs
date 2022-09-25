
namespace Linq_Project
{
    partial class Form1
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
            this.sayilar_hepsi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.negatif_sayilar = new System.Windows.Forms.Button();
            this.pozitif_sayilar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayilar_hepsi
            // 
            this.sayilar_hepsi.Location = new System.Drawing.Point(12, 198);
            this.sayilar_hepsi.Name = "sayilar_hepsi";
            this.sayilar_hepsi.Size = new System.Drawing.Size(104, 35);
            this.sayilar_hepsi.TabIndex = 0;
            this.sayilar_hepsi.Text = "tüm sayilar";
            this.sayilar_hepsi.UseVisualStyleBackColor = true;
            this.sayilar_hepsi.Click += new System.EventHandler(this.sayilar_hepsi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 180);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // negatif_sayilar
            // 
            this.negatif_sayilar.Location = new System.Drawing.Point(122, 198);
            this.negatif_sayilar.Name = "negatif_sayilar";
            this.negatif_sayilar.Size = new System.Drawing.Size(104, 35);
            this.negatif_sayilar.TabIndex = 3;
            this.negatif_sayilar.Text = "negatif";
            this.negatif_sayilar.UseVisualStyleBackColor = true;
            this.negatif_sayilar.Click += new System.EventHandler(this.negatif_sayilar_Click);
            // 
            // pozitif_sayilar
            // 
            this.pozitif_sayilar.Location = new System.Drawing.Point(232, 198);
            this.pozitif_sayilar.Name = "pozitif_sayilar";
            this.pozitif_sayilar.Size = new System.Drawing.Size(104, 35);
            this.pozitif_sayilar.TabIndex = 4;
            this.pozitif_sayilar.Text = "pozitif";
            this.pozitif_sayilar.UseVisualStyleBackColor = true;
            this.pozitif_sayilar.Click += new System.EventHandler(this.pozitif_sayilar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "büyükten küçüğe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "küçükten büyüğe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "çift";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "tek";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "en büyük";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "en küçük";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(389, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "alfabetik";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(559, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "terstten alfabetik";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(389, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "uzunluk";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(559, 262);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "içinde a olan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(748, 262);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(140, 44);
            this.button11.TabIndex = 15;
            this.button11.Text = "Siparisler";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(748, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(140, 44);
            this.button12.TabIndex = 16;
            this.button12.Text = "Tarihler";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(935, 198);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(140, 44);
            this.button13.TabIndex = 17;
            this.button13.Text = "İlk 5 Sipariş";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(935, 262);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(140, 44);
            this.button14.TabIndex = 18;
            this.button14.Text = "Son 5 Sipariş";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1120, 198);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(140, 44);
            this.button15.TabIndex = 19;
            this.button15.Text = "Yang Wang";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1120, 262);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(140, 44);
            this.button16.TabIndex = 20;
            this.button16.Text = "Sipariş Sayisi";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 450);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pozitif_sayilar);
            this.Controls.Add(this.negatif_sayilar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_hepsi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sayilar_hepsi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button negatif_sayilar;
        private System.Windows.Forms.Button pozitif_sayilar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}


namespace perumahan.view
{
    partial class DaftarRumah
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
            groupBox1 = new GroupBox();
            comboBoxBlok = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxJumlahKamar = new ComboBox();
            label3 = new Label();
            comboBoxJumlahKamarMandi = new ComboBox();
            label4 = new Label();
            comboBoxLuasTanah = new ComboBox();
            label5 = new Label();
            comboBoxJumlahTingkat = new ComboBox();
            label6 = new Label();
            comboBoxHarga = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxHarga);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxJumlahTingkat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxLuasTanah);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxJumlahKamarMandi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxJumlahKamar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxBlok);
            groupBox1.Location = new Point(362, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilihan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxBlok
            // 
            comboBoxBlok.FormattingEnabled = true;
            comboBoxBlok.Location = new Point(156, 36);
            comboBoxBlok.Name = "comboBoxBlok";
            comboBoxBlok.Size = new Size(209, 23);
            comboBoxBlok.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "blok";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 88);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "jumlah kamar";
            // 
            // comboBoxJumlahKamar
            // 
            comboBoxJumlahKamar.FormattingEnabled = true;
            comboBoxJumlahKamar.Location = new Point(156, 85);
            comboBoxJumlahKamar.Name = "comboBoxJumlahKamar";
            comboBoxJumlahKamar.Size = new Size(209, 23);
            comboBoxJumlahKamar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 136);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "jumlah kamar mandi";
            // 
            // comboBoxJumlahKamarMandi
            // 
            comboBoxJumlahKamarMandi.FormattingEnabled = true;
            comboBoxJumlahKamarMandi.Location = new Point(156, 133);
            comboBoxJumlahKamarMandi.Name = "comboBoxJumlahKamarMandi";
            comboBoxJumlahKamarMandi.Size = new Size(209, 23);
            comboBoxJumlahKamarMandi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 186);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "luas tanah";
            // 
            // comboBoxLuasTanah
            // 
            comboBoxLuasTanah.FormattingEnabled = true;
            comboBoxLuasTanah.Location = new Point(156, 183);
            comboBoxLuasTanah.Name = "comboBoxLuasTanah";
            comboBoxLuasTanah.Size = new Size(209, 23);
            comboBoxLuasTanah.TabIndex = 7;
            comboBoxLuasTanah.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 237);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "jumlah tingkat";
            // 
            // comboBoxJumlahTingkat
            // 
            comboBoxJumlahTingkat.FormattingEnabled = true;
            comboBoxJumlahTingkat.Location = new Point(156, 234);
            comboBoxJumlahTingkat.Name = "comboBoxJumlahTingkat";
            comboBoxJumlahTingkat.Size = new Size(209, 23);
            comboBoxJumlahTingkat.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 286);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Harga";
            // 
            // comboBoxHarga
            // 
            comboBoxHarga.FormattingEnabled = true;
            comboBoxHarga.Location = new Point(156, 283);
            comboBoxHarga.Name = "comboBoxHarga";
            comboBoxHarga.Size = new Size(209, 23);
            comboBoxHarga.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 318);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(27, 352);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(108, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(189, 352);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(270, 352);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(27, 326);
            button5.Name = "button5";
            button5.Size = new Size(318, 23);
            button5.TabIndex = 16;
            button5.Text = "Add To Favorit";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(243, 370);
            button6.Name = "button6";
            button6.Size = new Size(113, 23);
            button6.TabIndex = 2;
            button6.Text = "Remove Image";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(243, 338);
            button7.Name = "button7";
            button7.Size = new Size(113, 23);
            button7.TabIndex = 3;
            button7.Text = "Add Image";
            button7.UseVisualStyleBackColor = true;
            // 
            // DaftarRumah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 405);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "DaftarRumah";
            Text = "DaftarRumah";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxJumlahKamar;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxBlok;
        private Label label3;
        private ComboBox comboBoxLuasTanah;
        private Label label4;
        private ComboBox comboBoxJumlahKamarMandi;
        private ComboBox comboBoxJumlahTingkat;
        private Label label5;
        private ComboBox comboBoxHarga;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
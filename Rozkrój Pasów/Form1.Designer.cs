namespace Rozkrój_Pasów
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbSheet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPas1 = new System.Windows.Forms.TextBox();
            this.tbItem2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPas1 = new System.Windows.Forms.ComboBox();
            this.cbItem2 = new System.Windows.Forms.ComboBox();
            this.cbItem4 = new System.Windows.Forms.ComboBox();
            this.cbItem3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItem4 = new System.Windows.Forms.TextBox();
            this.tbItem3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbItem6 = new System.Windows.Forms.ComboBox();
            this.cbItem5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbItem6 = new System.Windows.Forms.TextBox();
            this.tbItem5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbItem8 = new System.Windows.Forms.ComboBox();
            this.cbItem7 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbItem8 = new System.Windows.Forms.TextBox();
            this.tbItem7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btGeneruj = new System.Windows.Forms.Button();
            this.lbmateriał = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lbgrubość = new System.Windows.Forms.Label();
            this.cbGrubosc = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbObróbki = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbKolor = new System.Windows.Forms.ComboBox();
            this.cbArkusz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSheet
            // 
            this.lbSheet.AutoSize = true;
            this.lbSheet.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSheet.Location = new System.Drawing.Point(12, 38);
            this.lbSheet.Name = "lbSheet";
            this.lbSheet.Size = new System.Drawing.Size(202, 24);
            this.lbSheet.TabIndex = 0;
            this.lbSheet.Text = "Szerokość Arkusza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szerokość Pasa";
            // 
            // tbPas1
            // 
            this.tbPas1.Location = new System.Drawing.Point(200, 206);
            this.tbPas1.Name = "tbPas1";
            this.tbPas1.Size = new System.Drawing.Size(131, 26);
            this.tbPas1.TabIndex = 6;
            // 
            // tbItem2
            // 
            this.tbItem2.Location = new System.Drawing.Point(200, 257);
            this.tbItem2.Name = "tbItem2";
            this.tbItem2.Size = new System.Drawing.Size(131, 26);
            this.tbItem2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ilość";
            // 
            // cbPas1
            // 
            this.cbPas1.FormattingEnabled = true;
            this.cbPas1.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbPas1.Location = new System.Drawing.Point(54, 206);
            this.cbPas1.Name = "cbPas1";
            this.cbPas1.Size = new System.Drawing.Size(119, 28);
            this.cbPas1.TabIndex = 14;
            this.cbPas1.SelectedIndexChanged += new System.EventHandler(this.cbItem1_SelectedIndexChanged);
            // 
            // cbItem2
            // 
            this.cbItem2.FormattingEnabled = true;
            this.cbItem2.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbItem2.Location = new System.Drawing.Point(55, 257);
            this.cbItem2.Name = "cbItem2";
            this.cbItem2.Size = new System.Drawing.Size(119, 28);
            this.cbItem2.TabIndex = 15;
            // 
            // cbItem4
            // 
            this.cbItem4.FormattingEnabled = true;
            this.cbItem4.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbItem4.Location = new System.Drawing.Point(371, 257);
            this.cbItem4.Name = "cbItem4";
            this.cbItem4.Size = new System.Drawing.Size(119, 28);
            this.cbItem4.TabIndex = 21;
            // 
            // cbItem3
            // 
            this.cbItem3.FormattingEnabled = true;
            this.cbItem3.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbItem3.Location = new System.Drawing.Point(370, 204);
            this.cbItem3.Name = "cbItem3";
            this.cbItem3.Size = new System.Drawing.Size(119, 28);
            this.cbItem3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "ilość";
            // 
            // tbItem4
            // 
            this.tbItem4.Location = new System.Drawing.Point(516, 257);
            this.tbItem4.Name = "tbItem4";
            this.tbItem4.Size = new System.Drawing.Size(131, 26);
            this.tbItem4.TabIndex = 18;
            // 
            // tbItem3
            // 
            this.tbItem3.Location = new System.Drawing.Point(516, 206);
            this.tbItem3.Name = "tbItem3";
            this.tbItem3.Size = new System.Drawing.Size(131, 26);
            this.tbItem3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Szerokość Pasa";
            // 
            // cbItem6
            // 
            this.cbItem6.FormattingEnabled = true;
            this.cbItem6.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbItem6.Location = new System.Drawing.Point(675, 257);
            this.cbItem6.Name = "cbItem6";
            this.cbItem6.Size = new System.Drawing.Size(119, 28);
            this.cbItem6.TabIndex = 27;
            // 
            // cbItem5
            // 
            this.cbItem5.FormattingEnabled = true;
            this.cbItem5.Items.AddRange(new object[] {
            "155",
            "175",
            "205",
            "230",
            "255",
            "280",
            "305",
            "330",
            "355",
            "380",
            "405",
            "430",
            "455",
            "480",
            "505"});
            this.cbItem5.Location = new System.Drawing.Point(674, 204);
            this.cbItem5.Name = "cbItem5";
            this.cbItem5.Size = new System.Drawing.Size(119, 28);
            this.cbItem5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(866, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "ilość";
            // 
            // tbItem6
            // 
            this.tbItem6.Location = new System.Drawing.Point(820, 257);
            this.tbItem6.Name = "tbItem6";
            this.tbItem6.Size = new System.Drawing.Size(131, 26);
            this.tbItem6.TabIndex = 24;
            // 
            // tbItem5
            // 
            this.tbItem5.Location = new System.Drawing.Point(820, 206);
            this.tbItem5.Name = "tbItem5";
            this.tbItem5.Size = new System.Drawing.Size(131, 26);
            this.tbItem5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Szerokość Pasa";
            // 
            // cbItem8
            // 
            this.cbItem8.FormattingEnabled = true;
            this.cbItem8.Location = new System.Drawing.Point(977, 257);
            this.cbItem8.Name = "cbItem8";
            this.cbItem8.Size = new System.Drawing.Size(119, 28);
            this.cbItem8.TabIndex = 33;
            // 
            // cbItem7
            // 
            this.cbItem7.FormattingEnabled = true;
            this.cbItem7.Location = new System.Drawing.Point(976, 204);
            this.cbItem7.Name = "cbItem7";
            this.cbItem7.Size = new System.Drawing.Size(119, 28);
            this.cbItem7.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1168, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "ilość";
            // 
            // tbItem8
            // 
            this.tbItem8.Location = new System.Drawing.Point(1122, 257);
            this.tbItem8.Name = "tbItem8";
            this.tbItem8.Size = new System.Drawing.Size(131, 26);
            this.tbItem8.TabIndex = 30;
            // 
            // tbItem7
            // 
            this.tbItem7.Location = new System.Drawing.Point(1122, 206);
            this.tbItem7.Name = "tbItem7";
            this.tbItem7.Size = new System.Drawing.Size(131, 26);
            this.tbItem7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(972, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Szerokość Pasa";
            // 
            // btGeneruj
            // 
            this.btGeneruj.BackColor = System.Drawing.Color.IndianRed;
            this.btGeneruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btGeneruj.ForeColor = System.Drawing.Color.Black;
            this.btGeneruj.Location = new System.Drawing.Point(848, 335);
            this.btGeneruj.Name = "btGeneruj";
            this.btGeneruj.Size = new System.Drawing.Size(272, 61);
            this.btGeneruj.TabIndex = 34;
            this.btGeneruj.Text = "Generuj Rozkrój";
            this.btGeneruj.UseVisualStyleBackColor = false;
            this.btGeneruj.Click += new System.EventHandler(this.btGeneruj_Click);
            // 
            // lbmateriał
            // 
            this.lbmateriał.AutoSize = true;
            this.lbmateriał.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbmateriał.Location = new System.Drawing.Point(414, 42);
            this.lbmateriał.Name = "lbmateriał";
            this.lbmateriał.Size = new System.Drawing.Size(74, 20);
            this.lbmateriał.TabIndex = 35;
            this.lbmateriał.Text = "materiał";
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "Stal Ocynk",
            "Aluminium"});
            this.cbMaterial.Location = new System.Drawing.Point(490, 38);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(130, 28);
            this.cbMaterial.TabIndex = 36;
            // 
            // lbgrubość
            // 
            this.lbgrubość.AutoSize = true;
            this.lbgrubość.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbgrubość.Location = new System.Drawing.Point(656, 42);
            this.lbgrubość.Name = "lbgrubość";
            this.lbgrubość.Size = new System.Drawing.Size(73, 20);
            this.lbgrubość.TabIndex = 37;
            this.lbgrubość.Text = "grubość";
            // 
            // cbGrubosc
            // 
            this.cbGrubosc.FormattingEnabled = true;
            this.cbGrubosc.Items.AddRange(new object[] {
            "0,6",
            "1,0",
            "1,5",
            "2,0"});
            this.cbGrubosc.Location = new System.Drawing.Point(737, 37);
            this.cbGrubosc.Name = "cbGrubosc";
            this.cbGrubosc.Size = new System.Drawing.Size(91, 28);
            this.cbGrubosc.TabIndex = 38;
            this.cbGrubosc.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1090, 880);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 49);
            this.button2.TabIndex = 39;
            this.button2.Text = "Drukuj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 456);
            this.dataGridView1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1056, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 100);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(110, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 67);
            this.button3.TabIndex = 42;
            this.button3.Text = "Pobierz dane z NEXO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbObróbki
            // 
            this.cbObróbki.AutoSize = true;
            this.cbObróbki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbObróbki.Location = new System.Drawing.Point(370, 99);
            this.cbObróbki.Name = "cbObróbki";
            this.cbObróbki.Size = new System.Drawing.Size(187, 29);
            this.cbObróbki.TabIndex = 43;
            this.cbObróbki.Text = "Rozkrój obróbki";
            this.cbObróbki.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(620, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 29);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Rozkrój parpety";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(844, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "kolor";
            // 
            // cbKolor
            // 
            this.cbKolor.FormattingEnabled = true;
            this.cbKolor.Items.AddRange(new object[] {
            "7016",
            "8017",
            "8019",
            "9005",
            "9010",
            "9016",
            "9006",
            "9007",
            "7024",
            "ZŁ. DĄB",
            "WINCHESTER",
            "ORZECH",
            "SUROWY",
            ""});
            this.cbKolor.Location = new System.Drawing.Point(900, 42);
            this.cbKolor.Name = "cbKolor";
            this.cbKolor.Size = new System.Drawing.Size(130, 28);
            this.cbKolor.TabIndex = 46;
            // 
            // cbArkusz
            // 
            this.cbArkusz.FormattingEnabled = true;
            this.cbArkusz.Items.AddRange(new object[] {
            "1250",
            "1255",
            "1500"});
            this.cbArkusz.Location = new System.Drawing.Point(230, 37);
            this.cbArkusz.Name = "cbArkusz";
            this.cbArkusz.Size = new System.Drawing.Size(130, 28);
            this.cbArkusz.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1405, 945);
            this.Controls.Add(this.cbArkusz);
            this.Controls.Add(this.cbKolor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbObróbki);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbGrubosc);
            this.Controls.Add(this.lbgrubość);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.lbmateriał);
            this.Controls.Add(this.btGeneruj);
            this.Controls.Add(this.cbItem8);
            this.Controls.Add(this.cbItem7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbItem8);
            this.Controls.Add(this.tbItem7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbItem6);
            this.Controls.Add(this.cbItem5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbItem6);
            this.Controls.Add(this.tbItem5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbItem4);
            this.Controls.Add(this.cbItem3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbItem4);
            this.Controls.Add(this.tbItem3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbItem2);
            this.Controls.Add(this.cbPas1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItem2);
            this.Controls.Add(this.tbPas1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1427, 1001);
            this.MinimumSize = new System.Drawing.Size(1427, 1001);
            this.Name = "Form1";
            this.Text = " ROZKRÓJ PASÓW v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPas1;
        private System.Windows.Forms.TextBox tbItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPas1;
        private System.Windows.Forms.ComboBox cbItem2;
        private System.Windows.Forms.ComboBox cbItem4;
        private System.Windows.Forms.ComboBox cbItem3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbItem4;
        private System.Windows.Forms.TextBox tbItem3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbItem6;
        private System.Windows.Forms.ComboBox cbItem5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbItem6;
        private System.Windows.Forms.TextBox tbItem5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbItem8;
        private System.Windows.Forms.ComboBox cbItem7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbItem8;
        private System.Windows.Forms.TextBox tbItem7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btGeneruj;
        private System.Windows.Forms.Label lbmateriał;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lbgrubość;
        private System.Windows.Forms.ComboBox cbGrubosc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbObróbki;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbKolor;
        private System.Windows.Forms.ComboBox cbArkusz;
    }
}


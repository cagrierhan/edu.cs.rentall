namespace RentAll
{
    partial class vehiclelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiclelist));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbyatarac = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbyakit = new System.Windows.Forms.ComboBox();
            this.picvehicle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnameplaka = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 343);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cmbyatarac
            // 
            this.cmbyatarac.FormattingEnabled = true;
            this.cmbyatarac.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Arabalar ",
            "Yatlar"});
            this.cmbyatarac.Location = new System.Drawing.Point(28, 12);
            this.cmbyatarac.Name = "cmbyatarac";
            this.cmbyatarac.Size = new System.Drawing.Size(100, 21);
            this.cmbyatarac.TabIndex = 55;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboBox1.Location = new System.Drawing.Point(134, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // cmbyakit
            // 
            this.cmbyakit.FormattingEnabled = true;
            this.cmbyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.cmbyakit.Location = new System.Drawing.Point(695, 121);
            this.cmbyakit.Name = "cmbyakit";
            this.cmbyakit.Size = new System.Drawing.Size(100, 21);
            this.cmbyakit.TabIndex = 76;
            // 
            // picvehicle
            // 
            this.picvehicle.Location = new System.Drawing.Point(675, 202);
            this.picvehicle.Name = "picvehicle";
            this.picvehicle.Size = new System.Drawing.Size(120, 73);
            this.picvehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvehicle.TabIndex = 75;
            this.picvehicle.TabStop = false;
            this.picvehicle.Click += new System.EventHandler(this.picvehicle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(695, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 74;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmbmodel
            // 
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Items.AddRange(new object[] {
            "M3",
            "Egea",
            "Golf",
            "3 Serisi",
            "E Serisi",
            "5 Serisi",
            "S Serisi",
            "A4",
            "A5",
            "Katamaran",
            "MotorYat"});
            this.cmbmodel.Location = new System.Drawing.Point(695, 175);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(100, 21);
            this.cmbmodel.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Model";
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(695, 148);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(100, 21);
            this.cmbmarka.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yat"});
            this.comboBox2.Location = new System.Drawing.Point(695, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 70;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(723, 323);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 59);
            this.btndelete.TabIndex = 69;
            this.btndelete.Text = "SİL";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Yakıt Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kira Ücreti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Adı/Plaka";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(695, 97);
            this.txtucret.Multiline = true;
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(100, 20);
            this.txtucret.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Yat/Araba";
            // 
            // txtnameplaka
            // 
            this.txtnameplaka.Location = new System.Drawing.Point(695, 71);
            this.txtnameplaka.Multiline = true;
            this.txtnameplaka.Name = "txtnameplaka";
            this.txtnameplaka.Size = new System.Drawing.Size(100, 20);
            this.txtnameplaka.TabIndex = 62;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Green;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(613, 323);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 59);
            this.btnupdate.TabIndex = 61;
            this.btnupdate.Text = "GÜNCELLE";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.BackgroundImage")));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitbtn.Location = new System.Drawing.Point(675, 391);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(105, 59);
            this.exitbtn.TabIndex = 77;
            this.exitbtn.UseVisualStyleBackColor = false;
            // 
            // vehiclelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(834, 476);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.cmbyakit);
            this.Controls.Add(this.picvehicle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbmodel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnameplaka);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbyatarac);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "vehiclelist";
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.vehiclelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbyatarac;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbyakit;
        private System.Windows.Forms.PictureBox picvehicle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnameplaka;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button exitbtn;
    }
}

 namespace RentAll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncloseapp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btncars = new System.Windows.Forms.Button();
            this.btnuserlist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnaddvehicle = new System.Windows.Forms.Button();
            this.btmaddyatch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncloseapp
            // 
            this.btncloseapp.BackColor = System.Drawing.Color.Red;
            this.btncloseapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncloseapp.BackgroundImage")));
            this.btncloseapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncloseapp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btncloseapp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncloseapp.Location = new System.Drawing.Point(884, 3);
            this.btncloseapp.Name = "btncloseapp";
            this.btncloseapp.Size = new System.Drawing.Size(136, 86);
            this.btncloseapp.TabIndex = 1;
            this.btncloseapp.UseVisualStyleBackColor = false;
            this.btncloseapp.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blurelogo.png");
            this.imageList1.Images.SetKeyName(1, "carreal.png");
            this.imageList1.Images.SetKeyName(2, "çıkar.png");
            this.imageList1.Images.SetKeyName(3, "favicon.ico");
            this.imageList1.Images.SetKeyName(4, "img_343953.png");
            this.imageList1.Images.SetKeyName(5, "kullancı cıkar.png");
            this.imageList1.Images.SetKeyName(6, "kullanıcı eklev1.png");
            this.imageList1.Images.SetKeyName(7, "kullanıcı listesi.png");
            this.imageList1.Images.SetKeyName(8, "listreal.png");
            this.imageList1.Images.SetKeyName(9, "login-icon-png-6.png");
            this.imageList1.Images.SetKeyName(10, "logo.png");
            this.imageList1.Images.SetKeyName(11, "realadd.png");
            this.imageList1.Images.SetKeyName(12, "ship.png");
            this.imageList1.Images.SetKeyName(13, "şuberea1l.png");
            // 
            // btncars
            // 
            this.btncars.BackColor = System.Drawing.Color.IndianRed;
            this.btncars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncars.BackgroundImage")));
            this.btncars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncars.ForeColor = System.Drawing.Color.White;
            this.btncars.Location = new System.Drawing.Point(74, 3);
            this.btncars.Name = "btncars";
            this.btncars.Size = new System.Drawing.Size(136, 86);
            this.btncars.TabIndex = 0;
            this.btncars.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncars.UseVisualStyleBackColor = false;
            this.btncars.Click += new System.EventHandler(this.btncars_Click);
            // 
            // btnuserlist
            // 
            this.btnuserlist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnuserlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnuserlist.BackgroundImage")));
            this.btnuserlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnuserlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuserlist.ForeColor = System.Drawing.Color.White;
            this.btnuserlist.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnuserlist.Location = new System.Drawing.Point(555, 3);
            this.btnuserlist.Name = "btnuserlist";
            this.btnuserlist.Size = new System.Drawing.Size(136, 86);
            this.btnuserlist.TabIndex = 3;
            this.btnuserlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnuserlist.UseVisualStyleBackColor = false;
            this.btnuserlist.Click += new System.EventHandler(this.btnuserlist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btmaddyatch);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.btnaddvehicle);
            this.panel1.Controls.Add(this.btncloseapp);
            this.panel1.Controls.Add(this.btnuserlist);
            this.panel1.Controls.Add(this.btncars);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 92);
            this.panel1.TabIndex = 0;
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnadduser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadduser.BackgroundImage")));
            this.btnadduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnadduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadduser.Location = new System.Drawing.Point(697, 3);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(136, 86);
            this.btnadduser.TabIndex = 5;
            this.btnadduser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnaddvehicle
            // 
            this.btnaddvehicle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnaddvehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddvehicle.BackgroundImage")));
            this.btnaddvehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnaddvehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddvehicle.ForeColor = System.Drawing.Color.White;
            this.btnaddvehicle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaddvehicle.Location = new System.Drawing.Point(373, 3);
            this.btnaddvehicle.Name = "btnaddvehicle";
            this.btnaddvehicle.Size = new System.Drawing.Size(136, 86);
            this.btnaddvehicle.TabIndex = 4;
            this.btnaddvehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaddvehicle.UseVisualStyleBackColor = false;
            this.btnaddvehicle.Click += new System.EventHandler(this.btnaddvehicle_Click);
            // 
            // btmaddyatch
            // 
            this.btmaddyatch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btmaddyatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmaddyatch.BackgroundImage")));
            this.btmaddyatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmaddyatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmaddyatch.ForeColor = System.Drawing.Color.White;
            this.btmaddyatch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmaddyatch.Location = new System.Drawing.Point(231, 3);
            this.btmaddyatch.Name = "btmaddyatch";
            this.btmaddyatch.Size = new System.Drawing.Size(136, 86);
            this.btmaddyatch.TabIndex = 6;
            this.btmaddyatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmaddyatch.UseVisualStyleBackColor = false;
            this.btmaddyatch.Click += new System.EventHandler(this.btmaddyatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1093, 592);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncloseapp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btncars;
        private System.Windows.Forms.Button btnuserlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btnaddvehicle;
        private System.Windows.Forms.Button btmaddyatch;
    }
}


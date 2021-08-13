
namespace Camera
{
    partial class GetPicture
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
            this.cboVideo = new System.Windows.Forms.ComboBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboVideo
            // 
            this.cboVideo.FormattingEnabled = true;
            this.cboVideo.Location = new System.Drawing.Point(82, 23);
            this.cboVideo.Name = "cboVideo";
            this.cboVideo.Size = new System.Drawing.Size(212, 26);
            this.cboVideo.TabIndex = 0;
            this.cboVideo.SelectedIndexChanged += new System.EventHandler(this.cboVideo_SelectedIndexChanged);
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Location = new System.Drawing.Point(82, 67);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(212, 26);
            this.cboResolution.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 124);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(285, 43);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(9, 186);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(285, 43);
            this.btnCut.TabIndex = 3;
            this.btnCut.Text = "断开";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(9, 248);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(285, 43);
            this.btnPic.TabIndex = 4;
            this.btnPic.Text = "拍照";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "摄像头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "像  素：";
            // 
            // vispShoot
            // 
            this.vispShoot.Location = new System.Drawing.Point(367, 12);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(400, 300);
            this.vispShoot.TabIndex = 7;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboResolution);
            this.panel1.Controls.Add(this.cboVideo);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 650);
            this.panel1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(285, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存图片";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbView
            // 
            this.pbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbView.Location = new System.Drawing.Point(367, 338);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(400, 300);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 10;
            this.pbView.TabStop = false;
            // 
            // GetPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 650);
            this.Controls.Add(this.pbView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vispShoot);
            this.MaximumSize = new System.Drawing.Size(850, 706);
            this.MinimumSize = new System.Drawing.Size(850, 706);
            this.Name = "GetPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "拍照";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetPicture_FormClosing);
            this.Load += new System.EventHandler(this.GetPicture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVideo;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Button btnSave;
    }
}
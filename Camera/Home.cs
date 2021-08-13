using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //导入图片 单击从本地导入裂纹图片
        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "导入图片";
            dialog.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jpg;*.png;*.jpeg;*.bmp;*.gif|All files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string picturePath = dialog.FileName;
                pictureBox1.Load(picturePath);
            }
        }
        
        // 拍摄图片 单击跳转至摄像头页面，通过摄像头抓拍裂纹照片
        private void btn_camera_Click(object sender, EventArgs e)
        {
            GetPicture gp = new GetPicture();
            this.Hide();
            gp.ShowDialog();
            this.Dispose();
        }
    }
}

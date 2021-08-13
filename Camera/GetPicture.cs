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
using AForge.Video.DirectShow;

namespace Camera
{
    public partial class GetPicture : Form
    {
        private FilterInfoCollection videoDevices;//所有摄像设备
        private VideoCaptureDevice videoDevice;//摄像设备
        private VideoCapabilities[] videoCapabilities;//摄像头分辨率
        public GetPicture()
        {
            InitializeComponent();
        }

        // 载入页面时获取摄像头列表
        private void GetPicture_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//得到机器所有接入的摄像设备
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cboVideo.Items.Add(device.Name);//把摄像设备添加到摄像列表中
                }
            }
            else
            {
                cboVideo.Items.Add("没有找到摄像头");
            }
            cboVideo.SelectedIndex = 0;//默认选择第一个
        }

        //选择摄像头
        private void cboVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                //获取摄像头
                videoDevice = new VideoCaptureDevice(videoDevices[cboVideo.SelectedIndex].MonikerString);
                GetDeviceResolution(videoDevice);//获取摄像头的分辨率
            }
        }

        //获取摄像头的分辨率
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cboResolution.Items.Clear();//清空列表
            videoCapabilities = videoCaptureDevice.VideoCapabilities;//设备的摄像头分辨率数组
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                //把这个设备的所有分辨率添加到列表
                cboResolution.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cboResolution.SelectedIndex = 0;//默认选择第一个
        }

        //单击 连接 开启摄像头
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)//如果摄像头不为空
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cboResolution.SelectedIndex];//摄像头分辨率
                    vispShoot.VideoSource = videoDevice;//把摄像头赋给控件
                    vispShoot.Start();//开启摄像头
                    EnableControlStatus(false);
                }
            }
        }

        //控件的显示切换（连接、断开、拍照 三个控件）
        private void EnableControlStatus(bool status)
        {
            cboVideo.Enabled = status;
            cboResolution.Enabled = status;
            btnConnect.Enabled = status;
            btnPic.Enabled = !status;
            btnCut.Enabled = !status;
        }

        //断开
        private void btnCut_Click(object sender, EventArgs e)
        {
            DisConnect();//断开连接
            EnableControlStatus(true);
        }

        //拍照
        private void btnPic_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();//拍照
            pbView.Image = img;
        }

        //关闭并释放摄像头
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }

        //保存图片
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "保存图片";
            savedialog.Filter = "jpg图片|*.JPG|png图片|*.PNG|bmp 图片|*.bmp|jpeg图片|*.JPEG";
            savedialog.FilterIndex = 1;//设置默认文件类型显示顺序 
            savedialog.RestoreDirectory = true; //点了保存按钮进入
            if (pbView.Image != null)
            {
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    string pictureName = savedialog.FileName;
                    //照片另存
                    using (MemoryStream mem = new MemoryStream())
                    {
                        Bitmap bmp = new Bitmap(pbView.Image);
                        //保存到磁盘文件
                        bmp.Save(@pictureName, pbView.Image.RawFormat);
                        bmp.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("没有图片！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //关闭当前窗口时 释放摄像头资源
        private void GetPicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Dispose();
            DisConnect();//断开连接
        }
    }
}

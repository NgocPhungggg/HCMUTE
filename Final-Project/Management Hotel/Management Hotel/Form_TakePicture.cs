using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Management_Hotel
{
    public partial class Form_TakePicture : Form
    {
        private FilterInfoCollection camera;
        private VideoCaptureDevice cam;
        public Form_TakePicture()
        {
            InitializeComponent();
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in camera)
            {
                ComboBox_Device.Items.Add(info.Name); 
            }
            ComboBox_Device.SelectedIndex = 0;
        }

        private void Form_TakePicture_Load(object sender, EventArgs e)
        {
            PictureBox_Pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Button_OpenCamera_Click(object sender, EventArgs e)
        {
            if(cam != null && cam.IsRunning) 
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(camera[ComboBox_Device.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            PictureBox_Pic.Image = bitmap;
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) 
            {
                cam.Stop();
            }
        }
        protected override void OnClosed (EventArgs e)
        {
            base.OnClosed (e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        private void Button_TakePic_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Users\\ASUS\\Pictures";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                PictureBox_Pic.Image.Save(saveFileDialog1.FileName);
            }

        }
    }
}

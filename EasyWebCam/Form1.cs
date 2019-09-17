using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace EasyWebCam
{
    public partial class Form1 : Form
    {
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();

            var videoSources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoSources != null && videoSources.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoSources[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (pbWeb.Image != null)
            {
                pbWeb.Image.Dispose();
            }
            pbWeb.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnLigarDesligar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pbWeb.Image = null;
            }
            else
            {
                videoSource.Start();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (pbWeb.Image != null)
            {
                try
                {
                    videoSource.NewFrame -= VideoSource_NewFrame;

                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.DefaultExt = "png";
                        dialog.AddExtension = true;

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            pbWeb.Image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
                finally
                {
                    videoSource.NewFrame += VideoSource_NewFrame;
                }
                
            }

           
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
            base.OnFormClosing(e);
        }
    }
}

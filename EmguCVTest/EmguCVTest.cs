using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCVTest
{
    public partial class EmguCVTest : Form
    {
        /// <summary>
        /// EmguCV中获取视频信息的类
        /// </summary>
        Capture capture;
        public EmguCVTest()
        {
            InitializeComponent();
        }

        private void TSBTPlayCamera_Click(object sender, EventArgs e)
        {
            //将capture实例化，没有任何参数的实例化将会读取本地摄像头
            capture = new Capture();
            //捕获图像时要调用的事件
            capture.ImageGrabbed += Capture_ImageGrabbed;
        }
        /// <summary>
        /// 捕获图像的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            //新建一个Mat
            Mat frame = new Mat();
            //将得到的图像检索到frame中
            capture.Retrieve(frame, 0);
            //将图像赋值到IBShow的Image中完成显示
            IBShow.Image = frame;
        }
        /// <summary>
        /// 控制视频的播放暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSBTPlay_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (tSBTPlay.Text == "Pause")
                {
                    //stop the capture
                    tSBTPlay.Text = "Play";
                    capture.Pause();
                }
                else
                {
                    //start the capture
                    tSBTPlay.Text = "Pause";
                    capture.Start();
                }
            }
        }
    }
}

using Emgu.CV;
using System;
using System.Windows.Forms;

namespace EmguCVTest
{
    public partial class EmguCVTest : Form
    {
        /// <summary>
        /// EmguCV中获取视频信息的类
        /// </summary>
        Capture capture;
        /// <summary>
        /// 构造方法
        /// </summary>
        public EmguCVTest()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 播放本地摄像头事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSBTPlayCamera_Click(object sender, EventArgs e)
        {
            //将capture实例化，没有任何参数的实例化将会读取本地摄像头
            capture = new Capture();
            //捕获图像时要调用的事件
            capture.ImageGrabbed += Capture_ImageGrabbed;
            //IBShow.Image = capture.QueryFrame();
        }
        /// <summary>
        /// 捕获图像的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
           // IBShow.Image = capture.QueryFrame();
            //capture.Retrieve(IBShow.Image, 0);
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
        /// <summary>
        /// 播放RTSP视频流事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlayRTSP_Click(object sender, EventArgs e)
        {
            try
            {
                string RTSPStreamText = tSTBRTSPStream.Text.Trim();
                capture = new Capture(RTSPStreamText);
                capture.ImageGrabbed += Capture_ImageGrabbed;
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 播放本地视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tSBTPlayLocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openFileDialog.FileName;
                capture = new Capture(fName);
                capture.ImageGrabbed += Capture_ImageGrabbed;
            }
        }
    }
}

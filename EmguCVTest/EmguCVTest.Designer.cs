namespace EmguCVTest
{
    partial class EmguCVTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmguCVTest));
            this.TSShow = new System.Windows.Forms.ToolStrip();
            this.tSBRTSPStreamText = new System.Windows.Forms.ToolStripLabel();
            this.tSTBRTSPStream = new System.Windows.Forms.ToolStripTextBox();
            this.tSBTPlayRTSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPlayLocal = new System.Windows.Forms.ToolStripButton();
            this.tSBTPlayCamera = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPlay = new System.Windows.Forms.ToolStripButton();
            this.IBShow = new Emgu.CV.UI.ImageBox();
            this.TSShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBShow)).BeginInit();
            this.SuspendLayout();
            // 
            // TSShow
            // 
            this.TSShow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TSShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBRTSPStreamText,
            this.tSTBRTSPStream,
            this.tSBTPlayRTSP,
            this.toolStripSeparator6,
            this.tSBTPlayLocal,
            this.tSBTPlayCamera,
            this.toolStripSeparator5,
            this.tSBTPlay});
            this.TSShow.Location = new System.Drawing.Point(0, 0);
            this.TSShow.Name = "TSShow";
            this.TSShow.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TSShow.Size = new System.Drawing.Size(1216, 27);
            this.TSShow.TabIndex = 3;
            this.TSShow.Text = "toolStrip2";
            // 
            // tSBRTSPStreamText
            // 
            this.tSBRTSPStreamText.Name = "tSBRTSPStreamText";
            this.tSBRTSPStreamText.Size = new System.Drawing.Size(130, 24);
            this.tSBRTSPStreamText.Text = "RTSPStreamText";
            // 
            // tSTBRTSPStream
            // 
            this.tSTBRTSPStream.AutoSize = false;
            this.tSTBRTSPStream.Name = "tSTBRTSPStream";
            this.tSTBRTSPStream.Size = new System.Drawing.Size(600, 27);
            this.tSTBRTSPStream.Text = "rtsp://admin:hldz123123@192.168.1.64:554/h264/ch1/main/av_stream";
            // 
            // tSBTPlayRTSP
            // 
            this.tSBTPlayRTSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayRTSP.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayRTSP.Image")));
            this.tSBTPlayRTSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayRTSP.Name = "tSBTPlayRTSP";
            this.tSBTPlayRTSP.Size = new System.Drawing.Size(50, 24);
            this.tSBTPlayRTSP.Text = "RTSP";
            this.tSBTPlayRTSP.Click += new System.EventHandler(this.tSBTPlayRTSP_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTPlayLocal
            // 
            this.tSBTPlayLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayLocal.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayLocal.Image")));
            this.tSBTPlayLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayLocal.Name = "tSBTPlayLocal";
            this.tSBTPlayLocal.Size = new System.Drawing.Size(51, 24);
            this.tSBTPlayLocal.Text = "Local";
            this.tSBTPlayLocal.Click += new System.EventHandler(this.tSBTPlayLocal_Click);
            // 
            // tSBTPlayCamera
            // 
            this.tSBTPlayCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlayCamera.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlayCamera.Image")));
            this.tSBTPlayCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlayCamera.Name = "tSBTPlayCamera";
            this.tSBTPlayCamera.Size = new System.Drawing.Size(68, 24);
            this.tSBTPlayCamera.Text = "Camera";
            this.tSBTPlayCamera.Click += new System.EventHandler(this.TSBTPlayCamera_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tSBTPlay
            // 
            this.tSBTPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBTPlay.Image = ((System.Drawing.Image)(resources.GetObject("tSBTPlay.Image")));
            this.tSBTPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTPlay.Name = "tSBTPlay";
            this.tSBTPlay.Size = new System.Drawing.Size(50, 24);
            this.tSBTPlay.Text = "PLAY";
            this.tSBTPlay.Click += new System.EventHandler(this.TSBTPlay_Click);
            // 
            // IBShow
            // 
            this.IBShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IBShow.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.IBShow.Location = new System.Drawing.Point(0, 27);
            this.IBShow.Name = "IBShow";
            this.IBShow.Size = new System.Drawing.Size(1216, 584);
            this.IBShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IBShow.TabIndex = 2;
            this.IBShow.TabStop = false;
            // 
            // EmguCVTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 611);
            this.Controls.Add(this.IBShow);
            this.Controls.Add(this.TSShow);
            this.Name = "EmguCVTest";
            this.Text = "EmguCVTest";
            this.TSShow.ResumeLayout(false);
            this.TSShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IBShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSShow;
        private System.Windows.Forms.ToolStripLabel tSBRTSPStreamText;
        private System.Windows.Forms.ToolStripTextBox tSTBRTSPStream;
        private System.Windows.Forms.ToolStripButton tSBTPlayRTSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tSBTPlayLocal;
        private System.Windows.Forms.ToolStripButton tSBTPlayCamera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tSBTPlay;
        private Emgu.CV.UI.ImageBox IBShow;
    }
}


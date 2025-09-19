namespace OperatorApp
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.segmentR2F = new System.Windows.Forms.Label();
            this.segmentR1F = new System.Windows.Forms.Label();
            this.segmentL2F = new System.Windows.Forms.Label();
            this.segmentR2E = new System.Windows.Forms.Label();
            this.segmentL1F = new System.Windows.Forms.Label();
            this.segmentR1E = new System.Windows.Forms.Label();
            this.segmentL2E = new System.Windows.Forms.Label();
            this.segmentR2C = new System.Windows.Forms.Label();
            this.segmentL1E = new System.Windows.Forms.Label();
            this.segmentR1C = new System.Windows.Forms.Label();
            this.segmentL2C = new System.Windows.Forms.Label();
            this.segmentR2B = new System.Windows.Forms.Label();
            this.segmentL1C = new System.Windows.Forms.Label();
            this.segmentR1B = new System.Windows.Forms.Label();
            this.segmentL2B = new System.Windows.Forms.Label();
            this.segmentL1B = new System.Windows.Forms.Label();
            this.segmentR2D = new System.Windows.Forms.Label();
            this.segmentL2D = new System.Windows.Forms.Label();
            this.segmentR1D = new System.Windows.Forms.Label();
            this.segmentL1D = new System.Windows.Forms.Label();
            this.segmentR2G = new System.Windows.Forms.Label();
            this.segmentL2G = new System.Windows.Forms.Label();
            this.segmentR1G = new System.Windows.Forms.Label();
            this.segmentL1G = new System.Windows.Forms.Label();
            this.segmentR2A = new System.Windows.Forms.Label();
            this.segmentL2A = new System.Windows.Forms.Label();
            this.segmentR1A = new System.Windows.Forms.Label();
            this.segmentL1A = new System.Windows.Forms.Label();
            this.bannerRight = new System.Windows.Forms.Label();
            this.BannerRight2 = new System.Windows.Forms.Label();
            this.BannerLeft2 = new System.Windows.Forms.Label();
            this.bannerLeft = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboPorts);
            this.panel1.Controls.Add(this.cmdOpen);
            this.panel1.Controls.Add(this.cmdRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 43);
            this.panel1.TabIndex = 0;
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(12, 12);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(284, 20);
            this.comboPorts.TabIndex = 1;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.comboPorts_SelectedIndexChanged);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Enabled = false;
            this.cmdOpen.Location = new System.Drawing.Point(302, 12);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(75, 23);
            this.cmdOpen.TabIndex = 0;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(383, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 0;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSerial.Location = new System.Drawing.Point(0, 43);
            this.txtSerial.Multiline = true;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerial.Size = new System.Drawing.Size(184, 521);
            this.txtSerial.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.segmentR2F);
            this.panel2.Controls.Add(this.segmentR1F);
            this.panel2.Controls.Add(this.segmentL2F);
            this.panel2.Controls.Add(this.segmentR2E);
            this.panel2.Controls.Add(this.segmentL1F);
            this.panel2.Controls.Add(this.segmentR1E);
            this.panel2.Controls.Add(this.segmentL2E);
            this.panel2.Controls.Add(this.segmentR2C);
            this.panel2.Controls.Add(this.segmentL1E);
            this.panel2.Controls.Add(this.segmentR1C);
            this.panel2.Controls.Add(this.segmentL2C);
            this.panel2.Controls.Add(this.segmentR2B);
            this.panel2.Controls.Add(this.segmentL1C);
            this.panel2.Controls.Add(this.segmentR1B);
            this.panel2.Controls.Add(this.segmentL2B);
            this.panel2.Controls.Add(this.segmentL1B);
            this.panel2.Controls.Add(this.segmentR2D);
            this.panel2.Controls.Add(this.segmentL2D);
            this.panel2.Controls.Add(this.segmentR1D);
            this.panel2.Controls.Add(this.segmentL1D);
            this.panel2.Controls.Add(this.segmentR2G);
            this.panel2.Controls.Add(this.segmentL2G);
            this.panel2.Controls.Add(this.segmentR1G);
            this.panel2.Controls.Add(this.segmentL1G);
            this.panel2.Controls.Add(this.segmentR2A);
            this.panel2.Controls.Add(this.segmentL2A);
            this.panel2.Controls.Add(this.segmentR1A);
            this.panel2.Controls.Add(this.segmentL1A);
            this.panel2.Controls.Add(this.bannerRight);
            this.panel2.Controls.Add(this.BannerRight2);
            this.panel2.Controls.Add(this.BannerLeft2);
            this.panel2.Controls.Add(this.bannerLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 521);
            this.panel2.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("굴림", 20F);
            this.lblTimer.Location = new System.Drawing.Point(163, 70);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(168, 37);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("굴림", 20F);
            this.lblResult.Location = new System.Drawing.Point(163, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(168, 37);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // segmentR2F
            // 
            this.segmentR2F.BackColor = System.Drawing.Color.Black;
            this.segmentR2F.Location = new System.Drawing.Point(281, 161);
            this.segmentR2F.Name = "segmentR2F";
            this.segmentR2F.Size = new System.Drawing.Size(10, 30);
            this.segmentR2F.TabIndex = 1;
            // 
            // segmentR1F
            // 
            this.segmentR1F.BackColor = System.Drawing.Color.Black;
            this.segmentR1F.Location = new System.Drawing.Point(337, 161);
            this.segmentR1F.Name = "segmentR1F";
            this.segmentR1F.Size = new System.Drawing.Size(10, 30);
            this.segmentR1F.TabIndex = 1;
            // 
            // segmentL2F
            // 
            this.segmentL2F.BackColor = System.Drawing.Color.Black;
            this.segmentL2F.Location = new System.Drawing.Point(107, 161);
            this.segmentL2F.Name = "segmentL2F";
            this.segmentL2F.Size = new System.Drawing.Size(10, 30);
            this.segmentL2F.TabIndex = 1;
            // 
            // segmentR2E
            // 
            this.segmentR2E.BackColor = System.Drawing.Color.Black;
            this.segmentR2E.Location = new System.Drawing.Point(281, 201);
            this.segmentR2E.Name = "segmentR2E";
            this.segmentR2E.Size = new System.Drawing.Size(10, 30);
            this.segmentR2E.TabIndex = 1;
            // 
            // segmentL1F
            // 
            this.segmentL1F.BackColor = System.Drawing.Color.Black;
            this.segmentL1F.Location = new System.Drawing.Point(163, 161);
            this.segmentL1F.Name = "segmentL1F";
            this.segmentL1F.Size = new System.Drawing.Size(10, 30);
            this.segmentL1F.TabIndex = 1;
            // 
            // segmentR1E
            // 
            this.segmentR1E.BackColor = System.Drawing.Color.Black;
            this.segmentR1E.Location = new System.Drawing.Point(337, 201);
            this.segmentR1E.Name = "segmentR1E";
            this.segmentR1E.Size = new System.Drawing.Size(10, 30);
            this.segmentR1E.TabIndex = 1;
            // 
            // segmentL2E
            // 
            this.segmentL2E.BackColor = System.Drawing.Color.Black;
            this.segmentL2E.Location = new System.Drawing.Point(107, 201);
            this.segmentL2E.Name = "segmentL2E";
            this.segmentL2E.Size = new System.Drawing.Size(10, 30);
            this.segmentL2E.TabIndex = 1;
            // 
            // segmentR2C
            // 
            this.segmentR2C.BackColor = System.Drawing.Color.Black;
            this.segmentR2C.Location = new System.Drawing.Point(321, 201);
            this.segmentR2C.Name = "segmentR2C";
            this.segmentR2C.Size = new System.Drawing.Size(10, 30);
            this.segmentR2C.TabIndex = 1;
            // 
            // segmentL1E
            // 
            this.segmentL1E.BackColor = System.Drawing.Color.Black;
            this.segmentL1E.Location = new System.Drawing.Point(163, 201);
            this.segmentL1E.Name = "segmentL1E";
            this.segmentL1E.Size = new System.Drawing.Size(10, 30);
            this.segmentL1E.TabIndex = 1;
            // 
            // segmentR1C
            // 
            this.segmentR1C.BackColor = System.Drawing.Color.Black;
            this.segmentR1C.Location = new System.Drawing.Point(377, 201);
            this.segmentR1C.Name = "segmentR1C";
            this.segmentR1C.Size = new System.Drawing.Size(10, 30);
            this.segmentR1C.TabIndex = 1;
            // 
            // segmentL2C
            // 
            this.segmentL2C.BackColor = System.Drawing.Color.Black;
            this.segmentL2C.Location = new System.Drawing.Point(147, 201);
            this.segmentL2C.Name = "segmentL2C";
            this.segmentL2C.Size = new System.Drawing.Size(10, 30);
            this.segmentL2C.TabIndex = 1;
            // 
            // segmentR2B
            // 
            this.segmentR2B.BackColor = System.Drawing.Color.Black;
            this.segmentR2B.Location = new System.Drawing.Point(321, 161);
            this.segmentR2B.Name = "segmentR2B";
            this.segmentR2B.Size = new System.Drawing.Size(10, 30);
            this.segmentR2B.TabIndex = 1;
            // 
            // segmentL1C
            // 
            this.segmentL1C.BackColor = System.Drawing.Color.Black;
            this.segmentL1C.Location = new System.Drawing.Point(203, 201);
            this.segmentL1C.Name = "segmentL1C";
            this.segmentL1C.Size = new System.Drawing.Size(10, 30);
            this.segmentL1C.TabIndex = 1;
            // 
            // segmentR1B
            // 
            this.segmentR1B.BackColor = System.Drawing.Color.Black;
            this.segmentR1B.Location = new System.Drawing.Point(377, 161);
            this.segmentR1B.Name = "segmentR1B";
            this.segmentR1B.Size = new System.Drawing.Size(10, 30);
            this.segmentR1B.TabIndex = 1;
            // 
            // segmentL2B
            // 
            this.segmentL2B.BackColor = System.Drawing.Color.Black;
            this.segmentL2B.Location = new System.Drawing.Point(147, 161);
            this.segmentL2B.Name = "segmentL2B";
            this.segmentL2B.Size = new System.Drawing.Size(10, 30);
            this.segmentL2B.TabIndex = 1;
            // 
            // segmentL1B
            // 
            this.segmentL1B.BackColor = System.Drawing.Color.Black;
            this.segmentL1B.Location = new System.Drawing.Point(203, 161);
            this.segmentL1B.Name = "segmentL1B";
            this.segmentL1B.Size = new System.Drawing.Size(10, 30);
            this.segmentL1B.TabIndex = 1;
            // 
            // segmentR2D
            // 
            this.segmentR2D.BackColor = System.Drawing.Color.Black;
            this.segmentR2D.Location = new System.Drawing.Point(291, 231);
            this.segmentR2D.Name = "segmentR2D";
            this.segmentR2D.Size = new System.Drawing.Size(30, 10);
            this.segmentR2D.TabIndex = 1;
            // 
            // segmentL2D
            // 
            this.segmentL2D.BackColor = System.Drawing.Color.Black;
            this.segmentL2D.Location = new System.Drawing.Point(117, 231);
            this.segmentL2D.Name = "segmentL2D";
            this.segmentL2D.Size = new System.Drawing.Size(30, 10);
            this.segmentL2D.TabIndex = 1;
            // 
            // segmentR1D
            // 
            this.segmentR1D.BackColor = System.Drawing.Color.Black;
            this.segmentR1D.Location = new System.Drawing.Point(347, 231);
            this.segmentR1D.Name = "segmentR1D";
            this.segmentR1D.Size = new System.Drawing.Size(30, 10);
            this.segmentR1D.TabIndex = 1;
            // 
            // segmentL1D
            // 
            this.segmentL1D.BackColor = System.Drawing.Color.Black;
            this.segmentL1D.Location = new System.Drawing.Point(173, 231);
            this.segmentL1D.Name = "segmentL1D";
            this.segmentL1D.Size = new System.Drawing.Size(30, 10);
            this.segmentL1D.TabIndex = 1;
            // 
            // segmentR2G
            // 
            this.segmentR2G.BackColor = System.Drawing.Color.Black;
            this.segmentR2G.Location = new System.Drawing.Point(291, 191);
            this.segmentR2G.Name = "segmentR2G";
            this.segmentR2G.Size = new System.Drawing.Size(30, 10);
            this.segmentR2G.TabIndex = 1;
            // 
            // segmentL2G
            // 
            this.segmentL2G.BackColor = System.Drawing.Color.Black;
            this.segmentL2G.Location = new System.Drawing.Point(117, 191);
            this.segmentL2G.Name = "segmentL2G";
            this.segmentL2G.Size = new System.Drawing.Size(30, 10);
            this.segmentL2G.TabIndex = 1;
            // 
            // segmentR1G
            // 
            this.segmentR1G.BackColor = System.Drawing.Color.Black;
            this.segmentR1G.Location = new System.Drawing.Point(347, 191);
            this.segmentR1G.Name = "segmentR1G";
            this.segmentR1G.Size = new System.Drawing.Size(30, 10);
            this.segmentR1G.TabIndex = 1;
            // 
            // segmentL1G
            // 
            this.segmentL1G.BackColor = System.Drawing.Color.Black;
            this.segmentL1G.Location = new System.Drawing.Point(173, 191);
            this.segmentL1G.Name = "segmentL1G";
            this.segmentL1G.Size = new System.Drawing.Size(30, 10);
            this.segmentL1G.TabIndex = 1;
            // 
            // segmentR2A
            // 
            this.segmentR2A.BackColor = System.Drawing.Color.Black;
            this.segmentR2A.Location = new System.Drawing.Point(291, 151);
            this.segmentR2A.Name = "segmentR2A";
            this.segmentR2A.Size = new System.Drawing.Size(30, 10);
            this.segmentR2A.TabIndex = 1;
            // 
            // segmentL2A
            // 
            this.segmentL2A.BackColor = System.Drawing.Color.Black;
            this.segmentL2A.Location = new System.Drawing.Point(117, 151);
            this.segmentL2A.Name = "segmentL2A";
            this.segmentL2A.Size = new System.Drawing.Size(30, 10);
            this.segmentL2A.TabIndex = 1;
            // 
            // segmentR1A
            // 
            this.segmentR1A.BackColor = System.Drawing.Color.Black;
            this.segmentR1A.Location = new System.Drawing.Point(347, 151);
            this.segmentR1A.Name = "segmentR1A";
            this.segmentR1A.Size = new System.Drawing.Size(30, 10);
            this.segmentR1A.TabIndex = 1;
            // 
            // segmentL1A
            // 
            this.segmentL1A.BackColor = System.Drawing.Color.Black;
            this.segmentL1A.Location = new System.Drawing.Point(173, 151);
            this.segmentL1A.Name = "segmentL1A";
            this.segmentL1A.Size = new System.Drawing.Size(30, 10);
            this.segmentL1A.TabIndex = 1;
            // 
            // bannerRight
            // 
            this.bannerRight.BackColor = System.Drawing.Color.Gray;
            this.bannerRight.Location = new System.Drawing.Point(291, 3);
            this.bannerRight.Name = "bannerRight";
            this.bannerRight.Size = new System.Drawing.Size(200, 30);
            this.bannerRight.TabIndex = 0;
            // 
            // BannerRight2
            // 
            this.BannerRight2.BackColor = System.Drawing.Color.Gray;
            this.BannerRight2.Location = new System.Drawing.Point(461, 33);
            this.BannerRight2.Name = "BannerRight2";
            this.BannerRight2.Size = new System.Drawing.Size(30, 320);
            this.BannerRight2.TabIndex = 0;
            // 
            // BannerLeft2
            // 
            this.BannerLeft2.BackColor = System.Drawing.Color.Gray;
            this.BannerLeft2.Location = new System.Drawing.Point(3, 33);
            this.BannerLeft2.Name = "BannerLeft2";
            this.BannerLeft2.Size = new System.Drawing.Size(30, 320);
            this.BannerLeft2.TabIndex = 0;
            // 
            // bannerLeft
            // 
            this.bannerLeft.BackColor = System.Drawing.Color.Gray;
            this.bannerLeft.Location = new System.Drawing.Point(3, 3);
            this.bannerLeft.Name = "bannerLeft";
            this.bannerLeft.Size = new System.Drawing.Size(200, 30);
            this.bannerLeft.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "SerialViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bannerRight;
        private System.Windows.Forms.Label bannerLeft;
        private System.Windows.Forms.Label BannerRight2;
        private System.Windows.Forms.Label BannerLeft2;
        private System.Windows.Forms.Label segmentL1F;
        private System.Windows.Forms.Label segmentL1E;
        private System.Windows.Forms.Label segmentL1C;
        private System.Windows.Forms.Label segmentL1B;
        private System.Windows.Forms.Label segmentL1D;
        private System.Windows.Forms.Label segmentL1A;
        private System.Windows.Forms.Label segmentR1F;
        private System.Windows.Forms.Label segmentR1E;
        private System.Windows.Forms.Label segmentR1C;
        private System.Windows.Forms.Label segmentR1B;
        private System.Windows.Forms.Label segmentR1D;
        private System.Windows.Forms.Label segmentR1G;
        private System.Windows.Forms.Label segmentL1G;
        private System.Windows.Forms.Label segmentR1A;
        private System.Windows.Forms.Label segmentR2F;
        private System.Windows.Forms.Label segmentL2F;
        private System.Windows.Forms.Label segmentR2E;
        private System.Windows.Forms.Label segmentL2E;
        private System.Windows.Forms.Label segmentR2C;
        private System.Windows.Forms.Label segmentL2C;
        private System.Windows.Forms.Label segmentR2B;
        private System.Windows.Forms.Label segmentL2B;
        private System.Windows.Forms.Label segmentR2D;
        private System.Windows.Forms.Label segmentL2D;
        private System.Windows.Forms.Label segmentR2G;
        private System.Windows.Forms.Label segmentL2G;
        private System.Windows.Forms.Label segmentR2A;
        private System.Windows.Forms.Label segmentL2A;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTimer;
    }
}


namespace CookieGame
{
    partial class Form1
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
            this.pgbTimer = new CCWin.SkinControl.SkinProgressBar();
            this.lblTotalCookies = new CCWin.SkinControl.SkinLabel();
            this.lbl1 = new CCWin.SkinControl.SkinLabel();
            this.lblTotalAutoCliks = new CCWin.SkinControl.SkinLabel();
            this.btnBuyAutoClick = new CCWin.SkinControl.SkinButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinPictureBox3 = new CCWin.SkinControl.SkinPictureBox();
            this.pbBuyAutoClick = new CCWin.SkinControl.SkinPictureBox();
            this.pbCookieClicker = new CCWin.SkinControl.SkinPictureBox();
            this.btnBuyCookies = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyAutoClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookieClicker)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbTimer
            // 
            this.pgbTimer.Back = null;
            this.pgbTimer.BackColor = System.Drawing.Color.Transparent;
            this.pgbTimer.BarBack = null;
            this.pgbTimer.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.pgbTimer.ForeColor = System.Drawing.Color.Red;
            this.pgbTimer.Location = new System.Drawing.Point(28, 30);
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.pgbTimer.Size = new System.Drawing.Size(345, 30);
            this.pgbTimer.TabIndex = 0;
            // 
            // lblTotalCookies
            // 
            this.lblTotalCookies.BackColor = System.Drawing.Color.Maroon;
            this.lblTotalCookies.BorderColor = System.Drawing.Color.White;
            this.lblTotalCookies.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalCookies.ForeColor = System.Drawing.Color.White;
            this.lblTotalCookies.Location = new System.Drawing.Point(30, 73);
            this.lblTotalCookies.Name = "lblTotalCookies";
            this.lblTotalCookies.Size = new System.Drawing.Size(343, 35);
            this.lblTotalCookies.TabIndex = 1;
            this.lblTotalCookies.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Maroon;
            this.lbl1.BorderColor = System.Drawing.Color.White;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(290, 215);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(324, 35);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "每60秒自动单击一次";
            // 
            // lblTotalAutoCliks
            // 
            this.lblTotalAutoCliks.BackColor = System.Drawing.Color.Maroon;
            this.lblTotalAutoCliks.BorderColor = System.Drawing.Color.White;
            this.lblTotalAutoCliks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalAutoCliks.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalAutoCliks.ForeColor = System.Drawing.Color.White;
            this.lblTotalAutoCliks.Location = new System.Drawing.Point(290, 279);
            this.lblTotalAutoCliks.Name = "lblTotalAutoCliks";
            this.lblTotalAutoCliks.Size = new System.Drawing.Size(324, 35);
            this.lblTotalAutoCliks.TabIndex = 1;
            this.lblTotalAutoCliks.Text = "0";
            // 
            // btnBuyAutoClick
            // 
            this.btnBuyAutoClick.BackColor = System.Drawing.Color.Transparent;
            this.btnBuyAutoClick.BaseColor = System.Drawing.Color.Red;
            this.btnBuyAutoClick.BorderColor = System.Drawing.Color.Red;
            this.btnBuyAutoClick.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBuyAutoClick.DownBack = null;
            this.btnBuyAutoClick.DownBaseColor = System.Drawing.Color.Red;
            this.btnBuyAutoClick.Location = new System.Drawing.Point(460, 30);
            this.btnBuyAutoClick.MouseBack = null;
            this.btnBuyAutoClick.Name = "btnBuyAutoClick";
            this.btnBuyAutoClick.NormlBack = null;
            this.btnBuyAutoClick.Size = new System.Drawing.Size(154, 55);
            this.btnBuyAutoClick.TabIndex = 3;
            this.btnBuyAutoClick.UseVisualStyleBackColor = false;
            this.btnBuyAutoClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBuyAutoClick_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinPictureBox3
            // 
            this.skinPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox3.Image = global::CookieGame.Properties.Resources.Cookie;
            this.skinPictureBox3.Location = new System.Drawing.Point(390, 110);
            this.skinPictureBox3.Name = "skinPictureBox3";
            this.skinPictureBox3.Size = new System.Drawing.Size(64, 55);
            this.skinPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox3.TabIndex = 2;
            this.skinPictureBox3.TabStop = false;
            // 
            // pbBuyAutoClick
            // 
            this.pbBuyAutoClick.BackColor = System.Drawing.Color.Transparent;
            this.pbBuyAutoClick.Image = global::CookieGame.Properties.Resources.Click1;
            this.pbBuyAutoClick.Location = new System.Drawing.Point(390, 30);
            this.pbBuyAutoClick.Name = "pbBuyAutoClick";
            this.pbBuyAutoClick.Size = new System.Drawing.Size(64, 55);
            this.pbBuyAutoClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuyAutoClick.TabIndex = 2;
            this.pbBuyAutoClick.TabStop = false;
            // 
            // pbCookieClicker
            // 
            this.pbCookieClicker.BackColor = System.Drawing.Color.Transparent;
            this.pbCookieClicker.Image = global::CookieGame.Properties.Resources.Cookie;
            this.pbCookieClicker.Location = new System.Drawing.Point(28, 133);
            this.pbCookieClicker.Name = "pbCookieClicker";
            this.pbCookieClicker.Size = new System.Drawing.Size(225, 224);
            this.pbCookieClicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCookieClicker.TabIndex = 2;
            this.pbCookieClicker.TabStop = false;
            this.pbCookieClicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCookieClicker_MouseDown);
            // 
            // btnBuyCookies
            // 
            this.btnBuyCookies.BackColor = System.Drawing.Color.Transparent;
            this.btnBuyCookies.BaseColor = System.Drawing.Color.Red;
            this.btnBuyCookies.BorderColor = System.Drawing.Color.Red;
            this.btnBuyCookies.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBuyCookies.DownBack = null;
            this.btnBuyCookies.Location = new System.Drawing.Point(460, 110);
            this.btnBuyCookies.MouseBack = null;
            this.btnBuyCookies.Name = "btnBuyCookies";
            this.btnBuyCookies.NormlBack = null;
            this.btnBuyCookies.Size = new System.Drawing.Size(154, 55);
            this.btnBuyCookies.TabIndex = 3;
            this.btnBuyCookies.UseVisualStyleBackColor = false;
            this.btnBuyCookies.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBuyCookies_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(648, 387);
            this.Controls.Add(this.btnBuyCookies);
            this.Controls.Add(this.btnBuyAutoClick);
            this.Controls.Add(this.skinPictureBox3);
            this.Controls.Add(this.pbBuyAutoClick);
            this.Controls.Add(this.pbCookieClicker);
            this.Controls.Add(this.lblTotalAutoCliks);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTotalCookies);
            this.Controls.Add(this.pgbTimer);
            this.Name = "Form1";
            this.Text = "Cookie Game";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuyAutoClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookieClicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinProgressBar pgbTimer;
        private CCWin.SkinControl.SkinLabel lblTotalCookies;
        private CCWin.SkinControl.SkinLabel lbl1;
        private CCWin.SkinControl.SkinLabel lblTotalAutoCliks;
        private CCWin.SkinControl.SkinPictureBox pbCookieClicker;
        private CCWin.SkinControl.SkinPictureBox pbBuyAutoClick;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox3;
        private CCWin.SkinControl.SkinButton btnBuyAutoClick;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton btnBuyCookies;
    }
}


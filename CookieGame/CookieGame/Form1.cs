using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;

namespace CookieGame
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化
        /// </summary>
        double mdTotalCookies = 0;  //记录你做的饼干数量
        double mdCookiesPerClick = 1;   //一次单击多少个饼干


        double mdPurchasAutoClickCost = 50; //购买更多自动点击的成本(对应btnBuyAutoClick)
        double mdPurchasCookieCost = 50;    //购买更多饼干的成本（对应btnBuyCookies)

        double mdTotalAutoClick = 10;   //已经拥有的自动点击
        byte md60SecondsCount = 0;  //我们的自动点击计时器

        //调用两种颜色的手指 
        Image mdWhiteHand = Properties.Resources.Click1;    //白色
        Image mdBlueHand = Properties.Resources.Click2; //蓝色


        public Form1()
        {
            InitializeComponent();
            btnBuyAutoClick.Enabled = false;
            btnBuyCookies.Enabled = false;
            //控制计时器
            timer1.Interval = 1000; //表明是每一秒滴答
            timer1.Start(); //计时器开始
            //调用更新屏幕的方法
            UpdateScreen();
        }
        /// <summary>
        /// 更新屏幕的方法
        /// </summary>
        private void UpdateScreen()
        {
            btnBuyAutoClick.Text = "自动点击升级！￥" + Convert.ToString(mdPurchasAutoClickCost) + "饼干";
            btnBuyCookies.Text = "单击获得饼干数升级！￥" + Convert.ToString(mdPurchasCookieCost) + "饼干";

            lblTotalAutoCliks.Text = Convert.ToString(mdTotalAutoClick);
            lblTotalCookies.Text = Convert.ToString(mdTotalCookies);

        }
        /// <summary>
        /// 单击饼干方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCookieClicker_MouseDown(object sender, MouseEventArgs e)
        {
            //饼干总数 += 单击饼干
            mdTotalCookies += mdCookiesPerClick;
            UpdateScreen();
        }
        /// <summary>
        /// 自动点击按钮的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuyAutoClick_MouseDown(object sender, MouseEventArgs e)
        {
            //检测到鼠标按下后，禁用按钮以停止两次点击”
            btnBuyAutoClick.Enabled = false;
            //总的饼干数量减去购买自动点击的价格
            mdTotalCookies -= mdPurchasAutoClickCost;
            //自动点击涨价了
            mdPurchasAutoClickCost += 10;
            //自动增1, 这里不太理解
            mdTotalAutoClick++;

            UpdateScreen();//刷新
        }
        /// <summary>
        /// 单次点击获得饼干的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuyCookies_MouseDown(object sender, MouseEventArgs e)
        {
            //防止二次点击
            btnBuyCookies.Enabled = false;
            //饼干总数减去购买单次点击获得饼干的价格
            mdTotalCookies -= mdPurchasCookieCost;

            //提高单次获得饼干数量
            mdCookiesPerClick += 2;

            mdPurchasCookieCost += 20;

            UpdateScreen();

        }
        /// <summary>
        /// timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateScreen();//刷新
            //判断价格是否可以购买技能
            CheckPrices(btnBuyAutoClick, mdPurchasAutoClickCost);
            CheckPrices(btnBuyCookies, mdPurchasCookieCost);

            md60SecondsCount++;//时间自增
            if (md60SecondsCount == 60)
            {
                md60SecondsCount = 0;
            }
            if (md60SecondsCount <= mdTotalAutoClick)
            {
                DoAutoClick();
                mdTotalCookies++;   //相当于有多少时间，增加了多少的饼干
            }
            pgbTimer.Minimum = 0;
            pgbTimer.Maximum = 60;
            pgbTimer.Value = md60SecondsCount;

            UpdateScreen();//刷新

        }
        //添加背景音乐以及转换白蓝手
        private void DoAutoClick()
        {
            if (pbBuyAutoClick.Image == mdWhiteHand)
            {
                pbBuyAutoClick.Image = mdBlueHand;
            }
            else
            {
                pbBuyAutoClick.Image = mdWhiteHand;
            }
            //播放背景音乐
            SoundPlayer my_wave_file = new SoundPlayer(Properties.Resources.ClickNoise);
            my_wave_file.Play();

        }

        /// <summary>
        /// 判断价格是否可以购买技能的方法
        /// </summary>
        /// <param name="btnBuyAutoClick"></param>
        /// <param name="mdPurchasAutoClickCost"></param>
        private void CheckPrices(Control my, double prCost)
        {
            //遍历所有控件（包括lable、button）
            foreach (Control C in this.Controls)
            {
                if (C.Name == my.Name)
                {
                    if (mdTotalCookies >= prCost)
                    {
                        C.Enabled = true;
                    }
                    else
                    {
                        C.Enabled = false;
                    }
                }
            }
        }
    }
}

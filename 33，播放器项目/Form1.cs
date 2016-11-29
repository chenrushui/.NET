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

namespace _33_播放器项目
{
    public partial class Form1 : Form
    {

        //关键是控件类的使用，属性和事件
        //如何实现自动下一曲的功能?
        //如何实现歌词的显示功能？
        //用于存储音乐文件的全路径
        List<string> list = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        //播放按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //1)播放器默认情况下是属于自动播放的！如果取消播放器的自动播放
            mediaPlayer.Ctlcontrols.play();
        }

        //暂停按钮
        private void button2_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        //停止按钮
        private void button3_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候,取消播放功能！这两个顺序不能颠倒。
            mediaPlayer.settings.autoStart = false;
            mediaPlayer.URL = @"C:\Users\Tuhuadmin\Desktop\music\1.mp3";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        bool b = true;

        //用一个按钮控制播放和暂停
        /// <summary>
        /// 播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            bool b = true;

            if (btn_play_stop.Text == "播放")
            {
                if (b)
                {
                    //选中音乐，点击播放按钮
                    mediaPlayer.URL = list[listBox1.SelectedIndex];
                }
                else
                {
                    //继续播放，不重头播放

                }
                //如何记录播放到的位置,不让它重新播放
                //让某些代码满足一些条件的时候，在进行执行！
                btn_play_stop.Text = "暂停";
                mediaPlayer.Ctlcontrols.play();
            }
            else
            {

                btn_play_stop.Text = "播放";
                mediaPlayer.Ctlcontrols.pause();
                b = false;
            }

        }

        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        /// <summary>
        /// 用于选择歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //读取指定文件夹中的音乐文件，并显示在列表里面
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Tuhuadmin\Desktop\music";
            ofd.Filter = "*.mp3|*.avi|音乐文件|*.*";
            ofd.Title = "请选择要播放的音乐文件";
            //允许多选
            ofd.Multiselect = true;
            ofd.ShowDialog();

            //获取选中文件的全路径
            string[] str = ofd.FileNames;
            for (int i = 0; i < str.Length; i++)
            {
                list.Add(str[i]);
                //将文件名存储到listbox中
                listBox1.Items.Add(Path.GetFileName(str[i]));
            }
        }

        /// <summary>
        /// 双击播放事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                btn_play_stop.Enabled = false;
                MessageBox.Show("请先选择音乐");
                return;
            }

            try
            {
                //带播放音乐的索引
                mediaPlayer.URL = list[listBox1.SelectedIndex];
                mediaPlayer.Ctlcontrols.play();
                //当前播放到的位置
                //lbinformation.Text = mediaPlayer.currentMedia.duration.ToString();
                btn_play_stop.Text = "暂停";
            }
            catch
            {
                //进行异常捕获
            }
        }

        /// <summary>
        /// 上一曲的功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {


            //1)获取当前歌曲的索引
            int index = listBox1.SelectedIndex;
            //清空选中的索引项，因为当前Listbox设置的属性为多选
            listBox1.SelectedIndices.Clear();
            index--;
            //2)判断如果是第一首音乐，会怎么样?
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            //3)指向上一个url
            mediaPlayer.URL = list[index];
            //将改变后的索引值设置给当前选纵项
            listBox1.SelectedIndex = index;
            //4)进行播放
            mediaPlayer.Ctlcontrols.play();

        }

        /// <summary>
        /// 下一曲的功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {

            //1)获取当前歌曲的索引
            int index = listBox1.SelectedIndex;
            //清空选中的索引项，因为当前Listbox设置的属性为多选
            listBox1.SelectedIndices.Clear();
            index++;
            //2)判断如果是最后一首音乐，会怎么样?
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //3)指向下一个url
            mediaPlayer.URL = list[index];
            //将改变后的索引值设置给当前选纵项
            listBox1.SelectedIndex = index;
            //4)进行播放
            mediaPlayer.Ctlcontrols.play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 右键删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //多选，删除，先删集合再删除列表
            //首先获取要删除集合的个数：
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //1)删除集合
                list.RemoveAt(listBox1.SelectedIndex);
                //2)删除列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btn_voice.Text == "静音")
            {
                //处理具体的业务逻辑
                mediaPlayer.settings.mute = true;
                //文本改变，状态改变
                btn_voice.Text = "放音";
            }
            else
            {
                //处理具体的业务逻辑
                mediaPlayer.settings.mute = false;
                //文本改变，状态改变
                btn_voice.Text = "静音";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //判断音乐的播放状态
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //如果播放器的状态是正在播放中
                lbinformation.Text = mediaPlayer.Ctlcontrols.currentPositionString;
            }

            //通过判断播放时间来实现。

        }

        private void lbinformation_Click(object sender, EventArgs e)
        {

        }
    }
}

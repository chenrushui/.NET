using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_窗体应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            MessageBox.Show("Hello World! 转换成功");

            //在内存中创建窗体2
            Form2 f2= new Form2();
            //展示窗体
            f2.Show();
            //关闭窗体
            f2.Close();
            //关闭当前窗体
            this.Close();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World! 转换成功");
        }
    }
}

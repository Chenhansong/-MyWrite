using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Choose = 1;
        }
        public int Choose { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (Choose)
            {
                case 1:
                    GetText("房写你名");
                    break;
                case 2:
                    GetText("我妈会游泳");
                    break;
                case 3:
                    GetText("让你两个月胖20斤");
                    break;
                case 4:
                    GetText("再点我生气了");
                    break;
                case 5:
                    GetText("能不能给点面子");
                    break;
                case 6:
                    GetText("我的代码 我说了算鼓捣要同意");
                    break;
                default:
                    GetText("我擦 代码出错了");
                    break;
            }
            Choose++;
            if (Choose > 6)
            {
                Choose = 1;
            }
        }

        void GetText(string text)
        {
            MessageBox.Show(text, "我的条件", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("以后你就是我的第2222任 ( ⊙o⊙ )", "完美", MessageBoxButtons.OK);
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}

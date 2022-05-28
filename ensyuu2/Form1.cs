using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyuu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 10)//変数iが10まで繰り返す
            {
                if(i == 5){//変数iが5だった場合の処理
                    MessageBox.Show(i.ToString());
                    MessageBox.Show("ここで半分です");
                    i++;
                }
                else//変数iが5以外の処理
                {
                    MessageBox.Show(i.ToString());
                    i++;
                }
            }
        }
    }
}

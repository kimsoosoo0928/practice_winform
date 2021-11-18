using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormCalC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            NumberView.Text += btnTmp.Text;
            // 사용자가 누른 버튼 (sender)을 임시 버튼(btnTmp)으로 만들어 준다. 그리고 textBox1의 Text에 임시 버튼의 Text를 추가해준다.
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NumberView.Text += btn.Text;
            
        }
    }
}

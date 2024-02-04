using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGo
{
    public partial class MainPage_ : UserControl
    {
        public MainPage_()
        {
            InitializeComponent();
        }
        public void setInfo(String namecompany) 
        {
            lbl_Name_Company.Text += namecompany;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

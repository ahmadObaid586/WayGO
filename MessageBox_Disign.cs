using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Junior_project;

namespace WinGo
{
    public partial class MessageBox_Disign : Form
    {
        int idbus;
        ViewAllBuses allBuses;
        public MessageBox_Disign()
        {
            InitializeComponent();
        }
        public MessageBox_Disign(int id ,ViewAllBuses viewAllBuses)
        {
            idbus = id;
            allBuses = viewAllBuses;
            InitializeComponent();
        }

        private void Message_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sPanel_MessageBox_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MessageBox_Disign_Load(object sender, EventArgs e)
        {
        }

        public void Message_lbl_TextChanged(String msg)
        {
            if (Message_lbl.InvokeRequired)
                Message_lbl.Invoke(new MethodInvoker(delegate
                {
                    Message_lbl.Text = msg;
                }));
            else
                Message_lbl.Text = msg;
        }

        private async void btn_Ok_Click(object sender, EventArgs e)
        {
            bool del = await ResttHelper.Delete("bus/deleteBus/", idbus);
            if (del == true)
            {
                this.Close();
                allBuses.VewiPageBusCompany_1();
            }
            else
            {
                Message_lbl.Text = "لم يتم الحذف.";
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

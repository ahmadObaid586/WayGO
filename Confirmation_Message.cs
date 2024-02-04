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
    public partial class Confirmation_Message : UserControl
    {
        public Confirmation_Message()
        {
            InitializeComponent();
        }

        private void lbl_InfoBus_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WinGo
{
    public partial class HomePage : Form
    {
        String NameCompany;
        Log_in log_in_ForEnd;
        public HomePage(String companyName , Log_in log_In)
        {
            InitializeComponent();
            NameCompany = companyName;
            log_in_ForEnd = log_In;
        }

        private void pnl_sidepar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addTrip_Click(object sender, EventArgs e)
        {
            addNewTrip1.Reset_Interface(NameCompany);
            SidePanel.Height = btn_addTrip.Height;
            SidePanel.Top = btn_addTrip.Top;
            addNewTrip1.BringToFront();
            btn_addTrip.TextColor = Color.FromArgb(221, 221, 221);
            btn_addTrip.BackColor = Color.FromArgb(87, 111, 145);
            ViewAllTrioAvalable_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllTrioAvalable_btn.BackColor = Color.FromArgb(221, 221, 221);
            ViewAllBus_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllBus_btn.BackColor = Color.FromArgb(221, 221, 221);
            ViewLastTrips_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewLastTrips_btn.BackColor = Color.FromArgb(221, 221, 221);
            addNewTrip1.getInfo_fromServer();
        }

        private void ViewLastTrips_btn_Click(object sender, EventArgs e)
        {
            ViewLastTrips_lst.ViewLastTrip(NameCompany , ViewLastTrips_lst);
            SidePanel.Height = ViewLastTrips_btn.Height;
            SidePanel.Top = ViewLastTrips_btn.Top;
            ViewLastTrips_lst.BringToFront();
            ViewLastTrips_btn.TextColor = Color.FromArgb(221, 221, 221);
            ViewLastTrips_btn.BackColor = Color.FromArgb(87, 111, 145);
            btn_addTrip.TextColor = Color.FromArgb(35, 56, 98);
            btn_addTrip.BackColor = Color.FromArgb(221, 221, 221);
            ViewAllTrioAvalable_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllTrioAvalable_btn.BackColor = Color.FromArgb(221, 221, 221);
            ViewAllBus_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllBus_btn.BackColor = Color.FromArgb(221, 221, 221);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            mainPage_1.setInfo(NameCompany);
            mainPage_1.BringToFront();
        }

        private void ViewAllTrioAvalable_btn_Click(object sender, EventArgs e)
        {

            viewAllEffectiveTrips.View_detailsOfTrips_Effec(NameCompany);
            SidePanel.Height = ViewAllTrioAvalable_btn.Height;
            SidePanel.Top = ViewAllTrioAvalable_btn.Top;
            viewAllEffectiveTrips.BringToFront();
            ViewAllTrioAvalable_btn.TextColor = Color.FromArgb(221, 221, 221);
            ViewAllTrioAvalable_btn.BackColor = Color.FromArgb(87, 111, 145);
            btn_addTrip.TextColor = Color.FromArgb(35, 56, 98);
            btn_addTrip.BackColor = Color.FromArgb(221, 221, 221);
            ViewAllBus_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllBus_btn.BackColor = Color.FromArgb(221, 221, 221);
            ViewLastTrips_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewLastTrips_btn.BackColor = Color.FromArgb(221, 221, 221);

        }

        private void ViewAllBus_btn_Click(object sender, EventArgs e)
        {

            viewAllBuses1.VewiPageBusCompany_1(viewAllBuses1,NameCompany);
            SidePanel.Height = ViewAllBus_btn.Height;
            SidePanel.Top = ViewAllBus_btn.Top;
            viewAllBuses1.BringToFront();
            ViewAllBus_btn.TextColor = Color.FromArgb(221, 221, 221);
            ViewAllBus_btn.BackColor = Color.FromArgb(87, 111, 145);
            btn_addTrip.TextColor = Color.FromArgb(35, 56, 98);
            btn_addTrip.BackColor = Color.FromArgb(221, 221, 221);
            ViewAllTrioAvalable_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewAllTrioAvalable_btn.BackColor = Color.FromArgb(221, 221, 221);
            ViewLastTrips_btn.TextColor = Color.FromArgb(35, 56, 98);
            ViewLastTrips_btn.BackColor = Color.FromArgb(221, 221, 221);
        }

        private void viewAllBuses1_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            log_in_ForEnd.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Net.WebSockets;
using System.Text;
using WebSocketSharp;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
using Junior_project;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinGo
{
    public partial class ViewAllBuses : UserControl
    {
        List<Bus> buses;
        ViewAllBuses allBuses;
        public ViewAllBuses()
        {
            InitializeComponent();

        }
        private void ViewAllBuses_Load(object sender, EventArgs e)
        {
        }

        public async void VewiPageBusCompany_1(ViewAllBuses viewAllBuses, String namecompany)
        {
            lbl_Name_Company.Text += namecompany;
            allBuses = viewAllBuses;
            dGV_DriverInfo.Rows.Clear();
            lbl_msg.Text = string.Empty;
            JObject AllTripAvaliable = new JObject();
            AllTripAvaliable = await ResttHelper.GetAll("bus/getBuses");
            if (AllTripAvaliable != null)
            {
                buses = Bus.Read_Json_Bus(AllTripAvaliable);
                for (int i = 0; i < buses.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_DriverInfo);  // this line was missing
                    row.Cells[0].Value = buses[i].driverName;
                    row.Cells[1].Value = buses[i].helpDriverName;
                    row.Cells[2].Value = buses[i].numberOfBus;
                    row.Cells[3].Value = buses[i].type;
                    row.Cells[4].Value = buses[i].numOfSets;
                    dGV_DriverInfo.Rows.Add(row);
                }
                dGV_DriverInfo.AllowUserToAddRows = false;
            }
            else
                lbl_msg.Text = "لا يوجد باصات";
        }
        public async void VewiPageBusCompany_1()
        {
            dGV_DriverInfo.Rows.Clear();
            lbl_msg.Text = string.Empty;
            JObject AllTripAvaliable = new JObject();
            AllTripAvaliable = await ResttHelper.GetAll("bus/getBuses");
            if (AllTripAvaliable != null)
            {
                buses = Bus.Read_Json_Bus(AllTripAvaliable);
                for (int i = 0; i < buses.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_DriverInfo);  // this line was missing
                    row.Cells[0].Value = buses[i].driverName;
                    row.Cells[1].Value = buses[i].helpDriverName;
                    row.Cells[2].Value = buses[i].numberOfBus;
                    row.Cells[3].Value = buses[i].type;
                    row.Cells[4].Value = buses[i].numOfSets;
                    dGV_DriverInfo.Rows.Add(row);
                }
                dGV_DriverInfo.AllowUserToAddRows = false;

            }
            else
                lbl_msg.Text = "لا يوجد باصات";
        }
        private void dGV_DriverInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                        
            if (e.ColumnIndex == dGV_DriverInfo.Columns["col_Delete"].Index)
            {
                int id = buses[e.RowIndex].id;
                MessageBox_Disign message = new MessageBox_Disign(id,allBuses);
                message.Message_lbl_TextChanged(".سيتم حذف الباص نهائياً من الشركة");
                message.Show();
            }
            if (e.ColumnIndex == dGV_DriverInfo.Columns["colEdit"].Index)
            {
                int id = buses[e.RowIndex].id;
                edit_Bus_Info.GetIdValue(id);
                edit_Bus_Info.FillTextBox(buses[e.RowIndex]);
                edit_Bus_Info.getPageViewBuses(allBuses);
                edit_Bus_Info.BringToFront();

            }
            if (e.ColumnIndex == dGV_DriverInfo.Columns["colTrips"].Index)
            {
                int id = buses[e.RowIndex].id;
                made_Trips.GetIdValue(id, buses);
                made_Trips.BringToFront();
            }
        }
        private void btn_addTrip_Click(object sender, EventArgs e)
        {
            pnl_AddNewBus.BringToFront();
            pnl_AddNewBus.getPageViewBuses(allBuses);

        }
        private void addBus1_Load_1(object sender, EventArgs e)
        {

        }

        private void edit_Bus_Info_Load(object sender, EventArgs e)
        {

        }
    }
}

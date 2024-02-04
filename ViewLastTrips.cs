using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Junior_project;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class ViewLastTrips : UserControl
    {
        List<Trip> trips;
        ViewLastTrips viewRefrech;
        string name;
        public ViewLastTrips()
        {
            InitializeComponent();
      }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void ViewLastTrips_Load(object sender, EventArgs e)
        {
        }


        private void dGV_ِBvailableBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex >= dGV_ِViewTripInfo.Columns["col_More_INFO"].Index)
            {
                int id = trips[e.RowIndex].id;
                detailsOfTrips.GetIdValue(id,trips, viewRefrech,name);
                detailsOfTrips.BringToFront();
            }

        }

        private async void detailsOfTrips_Load(object sender, EventArgs e)
        {

        }
        public async void ViewLastTrip(String namecompany , ViewLastTrips viewLastTrips) 
        {
            viewRefrech = viewLastTrips;
            name = namecompany;
            lbl_Name_Company.Text += namecompany;
            DateTime date = DateTime.Now;
            lbl_Date_Now.Text = (date.Year + "/" + date.Month + "/" + date.Day).ToString();
            lbl_msg.Text = string.Empty;
            dGV_ِViewTripInfo.Rows.Clear();
            JObject AllTripAvaliable = new JObject();
            AllTripAvaliable = await ResttHelper.GetAll("trip/getOldTrips");
            if (AllTripAvaliable != null)
            {
                trips = Trip.Read_Json_trip(AllTripAvaliable);
                for (int i = 0; i < trips.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_ِViewTripInfo);  // this line was missing
                    row.Cells[0].Value = trips[i].date;
                    row.Cells[1].Value = trips[i].date;
                    row.Cells[2].Value = trips[i].from;
                    row.Cells[3].Value = trips[i].to;
                    row.Cells[4].Value = trips[i].bus.numberOfBus;
                    row.Cells[5].Value = trips[i].ticktPrice;
                    row.Cells[6].Value = trips[i].bus.type;
                    dGV_ِViewTripInfo.Rows.Add(row);
                }
                dGV_ِViewTripInfo.AllowUserToAddRows = false;
            }
            else
                MessageBox.Show("لايوجد رحلات");
        }
        public async void ViewLastTrip()
        {
            DateTime date = DateTime.Now;
            lbl_Date_Now.Text = (date.Year + "/" + date.Month + "/" + date.Day).ToString();
            lbl_msg.Text = string.Empty;
            dGV_ِViewTripInfo.Rows.Clear();
            JObject AllTripAvaliable = new JObject();
            AllTripAvaliable = await ResttHelper.GetAll("trip/getOldTrips");
            if (AllTripAvaliable != null)
            {
                trips = Trip.Read_Json_trip(AllTripAvaliable);
                for (int i = 0; i < trips.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_ِViewTripInfo);  // this line was missing
                    row.Cells[0].Value = trips[i].date;
                    row.Cells[1].Value = trips[i].date;
                    row.Cells[2].Value = trips[i].from;
                    row.Cells[3].Value = trips[i].to;
                    row.Cells[4].Value = trips[i].bus.numberOfBus;
                    row.Cells[5].Value = trips[i].ticktPrice;
                    row.Cells[6].Value = trips[i].bus.type;
                    dGV_ِViewTripInfo.Rows.Add(row);
                }
                dGV_ِViewTripInfo.AllowUserToAddRows = false;
            }
            else
                MessageBox.Show("لايوجد رحلات");
        }
    }
}

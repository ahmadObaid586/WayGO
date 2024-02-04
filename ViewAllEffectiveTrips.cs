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
    public partial class ViewAllEffectiveTrips : UserControl
    {
        List<Trip> trips;
        List<Bus> buses;
        public ViewAllEffectiveTrips()
        {
            InitializeComponent();
        }

        public async void ViewAllEffectiveTrips_Load(object sender, EventArgs e)
        {

        }

        public async void View_detailsOfTrips_Effec(String namecompany)
        {
            lbl_Name_Company.Text += namecompany;
            DateTime date = DateTime.Now;
            lbl_Date_Now.Text = (date.Year + "/" + date.Month + "/" + date.Day).ToString();
            dGV_ِAvailableTrips.Rows.Clear();
            JObject AllTripAvaliable = new JObject();
            AllTripAvaliable = await ResttHelper.GetAll("trip/getValidTrips");
            if (AllTripAvaliable != null)
            {
                lbl_error.Text = String.Empty;
                trips = Trip.Read_Json_trip(AllTripAvaliable);
                for (int i = 0; i < trips.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_ِAvailableTrips);  // this line was missing
                    row.Cells[0].Value = trips[i].date;
                    row.Cells[1].Value = trips[i].date;
                    row.Cells[2].Value = trips[i].from;
                    row.Cells[3].Value = trips[i].to;
                    row.Cells[4].Value = trips[i].bus.numberOfBus;
                    row.Cells[5].Value = trips[i].ticktPrice;
                    row.Cells[6].Value = trips[i].bus.type;
                    dGV_ِAvailableTrips.Rows.Add(row);
                }
                dGV_ِAvailableTrips.AllowUserToAddRows = false;
            }
            else
            {
                lbl_error.Text = "لا يوجد رحلات ";
            }
        }
        public async void dGV_ِAvailableTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGV_ِAvailableTrips.Columns["col_More_INFO"].Index)
            {
                int idtrip = trips[e.RowIndex].id;
                JObject get = await ResttHelper.GetAll("trip/getCustomersInTrip/" + idtrip);
                if (get != null)
                {
                    detailsOfTrips_Effec.GetIdValue(idtrip, trips);
                    detailsOfTrips_Effec.BringToFront();
                }
                else
                    MessageBox.Show("لايوجد مستخدمين في هذه الرحلة");

            }
            if (e.ColumnIndex == dGV_ِAvailableTrips.Columns["colReservation"].Index)
            {

                int idtrip = trips[e.RowIndex].id;
                int price = trips[e.RowIndex].ticktPrice;
                ticketBooking.GetId(idtrip, price);
                ticketBooking.BringToFront();
            }
        }

        public void dGV_ِAvailableTrips_CellStyleContentChanged(object sender, DataGridViewCellStyleContentChangedEventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string woldSearch = txt_SearchWorld.Texts;
            bool check_word = false;
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].from == woldSearch)
                {
                    check_word = true;
                    dGV_ِAvailableTrips.Rows.Clear();
                    break;
                }
            }

            if (check_word)
            {
                for (int i = 0; i < trips.Count; i++)
                {
                    if (trips[i].from == woldSearch)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dGV_ِAvailableTrips);  // this line was missing
                        row.Cells[0].Value = trips[i].date;
                        row.Cells[1].Value = trips[i].date;
                        row.Cells[2].Value = trips[i].from;
                        row.Cells[3].Value = trips[i].to;
                        row.Cells[4].Value = trips[i].bus.numberOfBus;
                        row.Cells[5].Value = trips[i].ticktPrice;
                        row.Cells[6].Value = trips[i].bus.type;
                        dGV_ِAvailableTrips.Rows.Add(row);
                    }
                    dGV_ِAvailableTrips.AllowUserToAddRows = false;
                }
            }
            else 
            {
                MessageBox.Show("لايوجد رحلات لنتيجة البحث");
            }
        }
    }
}

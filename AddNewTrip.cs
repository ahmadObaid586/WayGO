using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Junior_project;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class AddNewTrip : UserControl
    {
        String namecompany;
        public AddNewTrip()
        {
            InitializeComponent();
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Source_lst_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public async void getInfo_fromServer() 
        {
            NumBus_lst.Items.Clear();
            Source_lst.Items.Clear();
            Distination_lst.Items.Clear();
            JObject numberbus = await ResttHelper.GetAll("bus/getBusesNumberAndCities");
            if (numberbus != null)
            {
                foreach (JObject jdata in numberbus["buses"])
                {
                    NumBus_lst.Items.Add(jdata["busNumber"]);
                }
                foreach (JObject jdata in numberbus["cities"])
                {
                    Source_lst.Items.Add(jdata["name"]);
                    Distination_lst.Items.Add(jdata["name"]);
                }
            }
        }

        private async void btn_AddTrip_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();                                     //create object from trip
            if (Distination_lst.SelectedItem != null 
                && Distination_lst.SelectedItem != null
                && dTP_Tripdate != null && NumBus_lst.SelectedItem != null
                && PriceTicket_lst.SelectedItem != null)
            {
                lblError.Text = string.Empty;
                trip.from = Source_lst.SelectedItem.ToString();
                trip.to = Distination_lst.SelectedItem.ToString();
                String date = dTP_Tripdate.Value.Year.ToString() + "-" + dTP_Tripdate.Value.Month.ToString() + "-" + dTP_Tripdate.Value.Day.ToString() + " " + dTP_Triptime.Value.Hour.ToString() + ":" + dTP_Triptime.Value.Minute.ToString() + ":" + "00";
                MessageBox.Show(date);
                trip.date = date;
                trip.busNumber = NumBus_lst.SelectedItem.ToString();
                trip.ticktPrice = Int32.Parse(PriceTicket_lst.SelectedItem.ToString());
                var inputJson = JsonConvert.SerializeObject(trip);              // convert the object to file json 
                bool cus = await ResttHelper.POST("trip/addTrip", inputJson);        //send file json to server with post method
                if (cus == true)
                {
                    lblError.Text = string.Empty;
                    lblError.Text = "تم إضافة الرحلة.";
                }
                else
                {
                    lblError.Text = string.Empty;
                    lblError.Text = "لم يتم إضافة الرحلة.";
                }

            }
            else
            {
                lblError.Text = "يرجى تعبئة كافة الحقول.";
            }
            Distination_lst.SelectedItems.Clear();
            NumBus_lst.SelectedItems.Clear();
            PriceTicket_lst.SelectedItems.Clear();
            Source_lst.SelectedItems.Clear();
        }
        public void Reset_Interface(String name) 
        {
            lbl_Name_Company.Text += name;
            Distination_lst.SelectedItems.Clear();
            NumBus_lst.SelectedItems.Clear();
            PriceTicket_lst.SelectedItems.Clear();
            Source_lst.SelectedItems.Clear();
            lblError.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime date = DateTime.Now;
            lbl_Time_Now.Text = (date.Year +"/" + date.Month +"/"+ date.Day).ToString();      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


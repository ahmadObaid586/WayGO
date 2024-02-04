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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class AddBus : UserControl
    {
        Bus bus = new Bus();
        ViewAllBuses buses;
        public AddBus()
        {
            InitializeComponent();
        }



        private async void btn_ِAddBus_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            if (txt_AidName.Texts != "" &&
                txt_FirstNameDriver.Texts != "" &&
                txt_NuberSeats.Texts != "" &&
                txt_NumberBus.Texts != "" &&
                txt_TypeBus.Texts != "")
            {
                
                bus.type = txt_TypeBus.Texts;
                bus.numOfSets = txt_NuberSeats.Texts;
                bus.driverName = txt_FirstNameDriver.Texts;
                bus.helpDriverName = txt_AidName.Texts;
                bus.numberOfBus = Convert.ToInt32(txt_NumberBus.Texts);
                var inputJson = JsonConvert.SerializeObject(bus);              // convert the object to file json 
                bool cus = await ResttHelper.POST("bus/addBus", inputJson);        //send file json to server with post method
                if (cus == true)
                {
                    lblError.Text = "تمت إضافة الباص.";
                    
                    txt_TypeBus.Texts = String.Empty;
                    txt_NumberBus.Texts = String.Empty;
                    txt_NuberSeats.Texts = String.Empty;
                    txt_FirstNameDriver.Texts = String.Empty;
                    txt_AidName.Texts = String.Empty;
                }
                else
                {
                    lblError.Text = "لم يتم إضافة الباص.";
                }
            }
            else
            {
                lblError.Text = "يرجى ملئ كافة الحقول.";
            }
           // ViewLastTrips lastTrips = new ViewLastTrips();
           // lastTrips.ViewLastTrip();
            
        }

        private void pnl_AddBus_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getPageViewBuses(ViewAllBuses viewAllBuses) 
        {
            buses = viewAllBuses;

        }
        public void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            txt_TypeBus.Texts = String.Empty;
            txt_NumberBus.Texts = String.Empty;
            txt_NuberSeats.Texts = String.Empty;
            txt_FirstNameDriver.Texts = String.Empty;
            txt_AidName.Texts = String.Empty;
            lblError.Text = string.Empty;
            buses.VewiPageBusCompany_1();
            this.SendToBack();

        }
    }
}

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
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace WinGo
{
    public partial class Edit_Bus_Info : UserControl
    {
        int idbus;
        ViewAllBuses allBuses;
        public Edit_Bus_Info()
        {
            InitializeComponent();

        }
        public void GetIdValue(int id)
        {
            idbus = id;
        }
      


        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
            txt_AidName.Texts = string.Empty;
            txt_FirstNameDriver.Texts = string.Empty;
            txt_NuberSeats.Texts = string.Empty;
            txt_NumberBus.Texts = string.Empty;
            txt_TypeBus.Texts = string.Empty;
        }

        public void FillTextBox(Bus bus1) 
        {
            txt_NumberBus.Texts = Convert.ToString(bus1.numberOfBus);
            txt_FirstNameDriver.Texts = bus1.driverName;
            txt_NuberSeats.Texts = bus1.numOfSets;
            txt_TypeBus.Texts = bus1.type;
            txt_AidName.Texts = bus1.helpDriverName;
        }
        public void getPageViewBuses(ViewAllBuses viewAllBuses)
        {
            allBuses = viewAllBuses;

        }
        public async void btn_ِUpdateBusINFO_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            if (txt_AidName.Texts != "" &&
                txt_FirstNameDriver.Texts != "" &&
                txt_NuberSeats.Texts != "" &&
                txt_NumberBus.Texts != "" &&
                txt_TypeBus.Texts != "")
            {
                Bus bus = new Bus();
                bus.type = txt_TypeBus.Texts;
                bus.numOfSets = txt_NuberSeats.Texts;
                bus.driverName = txt_FirstNameDriver.Texts;
                bus.helpDriverName = txt_AidName.Texts;
                bus.numberOfBus = Convert.ToInt32(txt_NumberBus.Texts);
                bus.id = idbus;
                var inputJson = JsonConvert.SerializeObject(bus);              // convert the object to file json 
                bool cus = await ResttHelper.PUT("bus/updateBus/"+idbus, inputJson);        //send file json to server with post method
                if (cus == true)
                {
                    lblError.Text = "تم تعديل معلومات الباص.";
                    allBuses.VewiPageBusCompany_1();
                }
                else
                {
                    lblError.Text = "لم يتم تعديل معلومات الباص.";
                }
            }
            else
            {
                lblError.Text = "يرجى ملئ كافة الحقول.";
            }
            txt_AidName.Texts = string.Empty;
            txt_FirstNameDriver.Texts = string.Empty;
            txt_NuberSeats.Texts = string.Empty;
            txt_NumberBus.Texts = string.Empty;
            txt_TypeBus.Texts = string.Empty;
        }

        private void pnl_BusEditInfo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //confirmation_Message_Update.BringToFront();
    }
    }

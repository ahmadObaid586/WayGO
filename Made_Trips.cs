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
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class Made_Trips : UserControl
    {
        int idbus;
        String idtrip;
        List<Bus> allBus;
        List<Customer> customers; 
        public Made_Trips()
        {
            InitializeComponent();
        }
        public void GetIdValue(int id, List<Bus> bus)
        {
            dGV_TripsInfo.Rows.Clear();
            allBus = bus;
            bool check = false;
            for (int i = 0; i < allBus.Count; i++)
            {
                if (id == allBus[i].id && allBus[i].trips.Count != 0)
                {
                    idbus = i;
                    for (int j = 0; j < allBus[i].trips.Count; j++)
                    {
                        check = true;
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dGV_TripsInfo);  // this line was missing
                        row.Cells[0].Value = allBus[i].driverName;
                        row.Cells[1].Value = allBus[i].trips[j].date;
                        row.Cells[2].Value = allBus[i].numberOfBus;
                        row.Cells[3].Value = allBus[i].type;
                        row.Cells[4].Value = allBus[i].trips[j].from;
                        row.Cells[5].Value = allBus[i].trips[j].to;
                        row.Cells[6].Value = allBus[i].trips[j].ticktPrice;

                        dGV_TripsInfo.Rows.Add(row);
                    }
                }

            }
            if (!check)
            {
                MessageBox.Show("لا يوجد رحلات لهذا الباص ");
            }
        }
        private void btn_BackPage_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
        public void made_Trips() 
        {
        }

        private async void dGV_TripsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGV_TripsInfo.Columns["colDetailes"].Index)
            {
                int idtrip = allBus[idbus].trips[e.RowIndex].id;
                JObject get =await ResttHelper.GetAll("trip/getCustomersInTrip/" + idtrip);
                if (get != null)
                {
                    customers = Customer.Read_Json_Customer(get);
                    more_Informations_Customer.GetNameValue(customers);
                    more_Informations_Customer.BringToFront();
                }
                else
                MessageBox.Show("لايوجد مستخدمين في هذه الرحلة");
            }
        }
    }
}

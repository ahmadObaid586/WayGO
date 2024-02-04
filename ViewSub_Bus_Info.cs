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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public partial class ViewSub_Bus_Info : UserControl
    {
        int idtrip;
        public ViewSub_Bus_Info()
        {
            InitializeComponent();
        }

        public void GetINFO(int id ,List<Trip> trips) 
        {
            idtrip= id;
            dGV_LastBusTrip.Rows.Clear();
            for (int i = 0; i < trips.Count; i++)
            {
                if (trips[i].id == id) 
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_LastBusTrip);  // this line was missing
                    row.Cells[0].Value = trips[i].bus.numberOfBus;
                    row.Cells[1].Value = trips[i].bus.driverName;
                    row.Cells[2].Value = trips[i].bus.numOfSets;
                    row.Cells[3].Value = trips[i].bus.type;
                    row.Cells[4].Value = trips[i].bus.helpDriverName;
                    dGV_LastBusTrip.Rows.Add(row);
                }
            }
        }
        private void btn_BackPage_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        /*
        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream("C:/Users/Ahmad/Desktop/create.pdf",FileMode.Create));
        doc.Open();
        Paragraph p1 = new Paragraph("Hello world");
        doc.Add(p1);
        doc.Close();
        MessageBox.Show("yes");
*/
    
    }
}

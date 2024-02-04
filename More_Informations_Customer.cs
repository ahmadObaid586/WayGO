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
    public partial class More_Informations_Customer : UserControl
    {
        public More_Informations_Customer()
        {
            InitializeComponent();
        }

        public void GetNameValue(String name, List<Customer> costomer)
        {
            dGV_CustomerInfo.Rows.Clear();
            for (int i = 0; i < costomer.Count; i++)
            {
                if (costomer[i].firstName == name)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_CustomerInfo);  // this line was missing
                    row.Cells[0].Value = costomer[i].firstName;
                    row.Cells[1].Value = costomer[i].lastName;
                    row.Cells[2].Value = costomer[i].fatherName;
                    row.Cells[3].Value = costomer[i].motherName;
                    row.Cells[4].Value = costomer[i].gender;
                    row.Cells[5].Value = costomer[i].phoneNumber;
                    row.Cells[6].Value = costomer[i].iss;

                    dGV_CustomerInfo.Rows.Add(row);
                }
            }
        }
        public void GetNameValue( List<Customer> costomer)
        {
            dGV_CustomerInfo.Rows.Clear();
            for (int i = 0; i < costomer.Count; i++)
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dGV_CustomerInfo);  // this line was missing
                    row.Cells[0].Value = costomer[i].firstName;
                    row.Cells[1].Value = costomer[i].lastName;
                    row.Cells[2].Value = costomer[i].fatherName;
                    row.Cells[3].Value = costomer[i].motherName;
                    row.Cells[4].Value = costomer[i].gender;
                    row.Cells[5].Value = costomer[i].phoneNumber;
                    row.Cells[6].Value = costomer[i].iss;

                    dGV_CustomerInfo.Rows.Add(row);
                }
            }
        
        private void btn_BackPage_Click(object sender, EventArgs e)
        {
            dGV_CustomerInfo.Rows.Clear();
            this.SendToBack();
        }
    }
}

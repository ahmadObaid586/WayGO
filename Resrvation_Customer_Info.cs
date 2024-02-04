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

namespace WinGo
{
    public partial class Resrvation_Customer_Info : UserControl
    {
        int tripId;
        int numberOfSets;
        List<int> chear;
        int count;
        int counter = 1;
        List<Customer> customers = new List<Customer>();
        public Resrvation_Customer_Info()
        {
            InitializeComponent();
        }


        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            count= 1;
            lbl_msg.Text = String.Empty;
            txb_FatherName.Texts = string.Empty;
            txb_FirstName.Texts = string.Empty;
            txb_Gender.Texts = string.Empty;
            txb_ISS.Texts = string.Empty;
            txb_LastName.Texts = string.Empty;
            txb_MobaileNumber.Texts = string.Empty;
            txb_MotherName.Texts = string.Empty;
            this.SendToBack();
        }

        private void txb_MobaileNumber__TextChanged(object sender, EventArgs e)
        {

        }

        public void get_parameter(int id, int numofSeat, int num, List<int> ints)
        {
            tripId = id;
            numberOfSets = numofSeat;
            chear = ints;
            count = num;
            if (count > 1)
            {
                lbl_numOfCustomer.Text = "المستخدم رقم 1 ";
            }
        }
        private void FillListCustomer() 
        {
            lbl_msg.Text = string.Empty;
            Customer customer = new Customer();
            customer.phoneNumber = txb_MobaileNumber.ToString();
            customer.firstName = txb_FirstName.ToString();
            customer.lastName = txb_LastName.ToString();
            customer.fatherName = txb_FatherName.ToString();
            customer.motherName = txb_MotherName.ToString();
            customer.gender = txb_Gender.ToString();
            customer.iss = txb_ISS.ToString();
            customers.Add(customer);
            txb_FatherName.Texts = string.Empty;
            txb_FirstName.Texts = string.Empty;
            txb_Gender.Texts = string.Empty;
            txb_ISS.Texts = string.Empty;
            txb_LastName.Texts = string.Empty;
            txb_MobaileNumber.Texts = string.Empty;
            txb_MotherName.Texts = string.Empty;
        }
        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            while (numberOfSets > 0)
            {
                if (txb_MobaileNumber.Texts != "" &&
                    txb_FirstName.Texts != "" &&
                    txb_FatherName.Texts != "" &&
                    txb_MotherName.Texts != "" &&
                    txb_LastName.Texts != "" &&
                    txb_Gender.Texts != "" &&
                    txb_ISS.Texts != "")
                {
                    FillListCustomer();
                    counter++;
                    numberOfSets--;
                    if(numberOfSets > 0) 
                        lbl_numOfCustomer.Text = "المستخدم رقم  " + counter.ToString();
                    break;
                }
                else
                {
                    lbl_msg.Text = "يرجى ملئ كافة الحقول ";
                }
            }
            MessageBox.Show(customers.ToString());
            if (numberOfSets == 0)
            {
                String inputJson = JsonConvert.SerializeObject(customers);              // convert the object to file json 
                bool AddRecervation = await ResttHelper.POST("/trip/submitBooking/"+tripId.ToString(), inputJson);
                if (AddRecervation == true)
                {
                    MessageBox.Show("تم تثبيت الحجز ");

                }
                else
                {
                    MessageBox.Show("لم يتم تثبيت الحجز");
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Junior_project;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public class Customer
    {
        public String firstName { set; get; }
        public String lastName { set; get; }
        public String fatherName { set; get; }
        public String motherName { set; get; }
        public String gender { set; get; }
        public String phoneNumber { set; get; }
        public String iss { set; get; }
        public Customer() { }
        public static List<Customer> Read_Json_Customer(JObject Jdata)
        {
            Customer Ob = new Customer();
            List<Customer> datalist = new List<Customer>();
            try
            {
                foreach (JObject data in Jdata["customers"])
                {
                    Ob.firstName = data["firstName"].Value<string>();
                    Ob.lastName = data["lastName"].Value<string>();
                    Ob.fatherName = data["fatherName"].Value<String>();
                    Ob.motherName = data["motherName"].Value<string>();
                    Ob.gender = data["gender"].Value<string>();
                    Ob.phoneNumber = data["phoneNumber"].Value<String>();
                    Ob.iss = data["iss"].Value<String>();
                    datalist.Add(Ob);
                    Ob = new Customer();
                }
                return datalist;
            }
            catch (Exception o)
            {
                MessageBox.Show("لايوجد رحلات.");
                return datalist;
            }
        }
    }
}

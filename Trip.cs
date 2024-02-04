using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinGo;

namespace Junior_project
{

    public class Trip 
    {
        public int id { set; get; }
        public String from { set; get; }
        public String to { set; get; }
        public String date { set; get; }
        public String busNumber{ set; get; }
        public int ticktPrice { set; get; }

        public Bus bus = new Bus();
        public Trip() { }
        public static List<Trip> Read_Json_trip(JObject Jdata)
        {
            Trip Ob = new Trip();
            List<Trip> datalist = new List<Trip>();
            try
            {
                foreach (JObject data in Jdata["trips"])
                {
                    Ob.id = data["id"].Value<int>();
                    Ob.from = data["from"].Value<string>();
                    Ob.to = data["to"].Value<string>();
                    Ob.date = data["date"].Value<String>();
                    Ob.ticktPrice = data["ticktPrice"].Value<int>();
                    Ob.bus.type = data["buse"]["type"].Value<string>();
                    Ob.bus.numOfSets = data["buse"]["numOfSets"].Value<String>();
                    Ob.bus.numberOfBus = data["buse"]["numberOfBus"].Value<int>();
                    Ob.bus.driverName = data["buse"]["driverName"].Value<String>();
                    Ob.bus.helpDriverName = data["buse"]["helpDriverName"].Value<String>();
                    datalist.Add(Ob);
                    Ob = new Trip();
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

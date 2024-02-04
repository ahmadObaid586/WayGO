using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Junior_project;
using Newtonsoft.Json.Linq;

namespace WinGo
{
    public class Bus
    {

        public String type { get; set; }

        public String numOfSets { get; set; }
        public String driverName { get; set; }
        public String helpDriverName { get; set; }
        public int numberOfBus { get; set; }
        public int id { get; set; }

        public  List<Trip> trips = new List<Trip>();
        public static List<Bus> Read_Json_Bus(JObject Jdata)
        {
            try
            {
                Bus Ob = new Bus();
                Trip trip = new Trip();
                List<Bus> datalist = new List<Bus>();
                foreach (JObject data in Jdata["buses"])
                {
                    Ob.type = data["type"].Value<string>();
                    Ob.numOfSets = data["numOfSets"].Value<string>();
                    Ob.driverName = data["driverName"].Value<string>();
                    Ob.helpDriverName = data["helpDriverName"].Value<string>();
                    Ob.numberOfBus = data["numberOfBus"].Value<int>();
                    Ob.id = data["id"].Value<int>();

                    foreach (JObject oldtrip in data["oldTrip"])
                    {
                        trip.id = oldtrip["id"].Value<int>();
                        trip.from = oldtrip["from"].Value<string>();
                        trip.to = oldtrip["to"].Value<string>();
                        trip.ticktPrice = oldtrip["ticktPrice"].Value<int>();
                        trip.date = oldtrip["date"].Value<String>();
                        Ob.trips.Add(trip);
                        trip = new Trip();

                    }
                    foreach (JObject newtrip in data["newTrip"])
                    {
                        trip.id = newtrip["id"].Value<int>();
                        trip.from = newtrip["from"].Value<string>();
                        trip.to = newtrip["to"].Value<string>();
                        trip.ticktPrice = newtrip["ticktPrice"].Value<int>();
                        trip.date = newtrip["date"].Value<String>();
                        Ob.trips.Add(trip);
                        trip = new Trip();
                    }
                  
                    datalist.Add(Ob);
                    Ob = new Bus();
                }
                    return datalist;
            }
            catch (Exception d) { MessageBox.Show("لايوجد باصات لهذه الشركة."); return null; }
        }
    }
}

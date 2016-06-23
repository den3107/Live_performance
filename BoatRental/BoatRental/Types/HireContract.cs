using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    public class HireContract
    {
        public int ID { get; private set; }
        public DateTime DateStart { get; private set; }
        public DateTime DateEnd { get; private set; }
        public int FrieschLakes { get; private set; }
        public List<Boat> Boats { get; private set; }
        public List<Item> Items { get; private set; }
        public List<Lake> Lakes { get; private set; }
        public String HirerEmailaddress { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public HireContract(int id, String hirerEmailaddress, List<Boat> boats, int frieschLakes, DateTime dateStart, DateTime dateEnd, List<Item> items = null, List<Lake> lakes = null)
        {
            ID = id;
            HirerEmailaddress = hirerEmailaddress;
            Boats = boats;
            FrieschLakes = frieschLakes;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Items = items ?? new List<Item>();
            Lakes = lakes ?? new List<Lake>();
        }

        public override string ToString()
        {
            return DateStart.ToString("yyyy/MM/dd") + " - " + DateEnd.ToString("yyyy/MM/dd");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    public class Lake
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public double Price { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Lake(int id, String name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public void SetName(String name)
        {
            dal.SetLakeName(name, ID);

            Name = name;
        }

        public void SetPrice(double price)
        {
            dal.SetLakePrice(price, ID);

            Price = price;
        }

        public static List<Lake> GetAllLakes()
        {
            return dal.GetAllLakes();
        }

        public override string ToString()
        {
            return "[" + ID + "] " + Name;
        }
    }
}

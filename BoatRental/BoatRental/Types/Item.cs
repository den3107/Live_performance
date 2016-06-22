using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class Item
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public double Price { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Item(int id, String name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public void SetName(String name)
        {
            dal.SetItemName(name, ID);

            Name = name;
        }

        public void SetPrice(double price)
        {
            dal.SetItemPrice(price, ID);

            Price = price;
        }

        public static List<Item> GetAllItems()
        {
            return dal.GetAllItems();
        }
    }
}

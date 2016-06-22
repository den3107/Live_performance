using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class Kind
    {
        public String Name { get; private set; }
        public bool PaysForLock { get; private set; }
        public double Price { get; private set; }
        public String Type { get; private set; }

        private DAL dal = new DAL(new OracleRepository());

        public Kind(String name, bool paysForLock, double price, String type)
        {
            Name = name;
            PaysForLock = paysForLock;
            Price = price;
            Type = type;
        }

        public bool SetName(String name)
        {
            bool success = true;
            int returnVal = 0;
            try
            {
                returnVal = dal.SetName(name);
            }
            catch
            {
                success = false;
            }

            if (returnVal > 0)
            {
                Name = name;
            }
            else
            {
                success = false;
            }

            return success;
        }

        public void SetPaysForLock(bool paysForLock)
        {
            dal.SetPaysForLock(paysForLock);

            PaysForLock = paysForLock;
        }

        public void SetPrice(double price)
        {
            dal.SetPrice(price);

            Price = price;
        }

        public void SetType(String type)
        {
            dal.SetType(type);

            Type = type;
        }
    }
}

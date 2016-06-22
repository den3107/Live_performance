using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class CONFIG
    {
        public static double FrieschLakePrice { get; private set; }
        public static int FrieschLakes { get; private set; }
        public static double LockPrice { get; private set; }
        public static int MaxFrieschLakes { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        static CONFIG()
        {
            Dictionary<String, object> fields = dal.GetCONFIG();

            FrieschLakePrice = double.Parse(fields["frieschLakePrice"].ToString());
            FrieschLakes = int.Parse(fields["frieschLakes"].ToString());
            LockPrice = double.Parse(fields["lockPrice"].ToString());
            MaxFrieschLakes = int.Parse(fields["maxFrieschLakes"].ToString());
        }

        public static void SetFrieschLakePrice(double frieschLakePrice)
        {
            dal.SetCONFIGFrieschLakePrice(frieschLakePrice);

            FrieschLakePrice = frieschLakePrice;
        }

        public static void SetFrieschLakes(int frieschLakes)
        {
            dal.SetCONFIGFrieschLakes(frieschLakes);

            FrieschLakes = frieschLakes;
        }

        public static void SetLockPrice(double lockPrice)
        {
            dal.SetCONFIGLockPrice(lockPrice);

            LockPrice = lockPrice;
        }

        public static void SetMaxFrieschLakes(int maxFrieschLakes)
        {
            dal.SetCONFIGMaxFrieschLakes(maxFrieschLakes);

            MaxFrieschLakes = maxFrieschLakes;
        }
    }
}

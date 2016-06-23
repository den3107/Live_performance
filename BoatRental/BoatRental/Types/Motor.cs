using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    public class Motor
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public double TankCapacity { get; private set; }
        public double Price { get; private set; }
        public bool MayTraverseLakes { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Motor(int id, String name, double tankCapacity, double price, bool mayTraverseLakes)
        {
            ID = id;
            Name = name;
            TankCapacity = tankCapacity;
            Price = price;
            MayTraverseLakes = mayTraverseLakes;
        }

        public void SetName(String name)
        {
            dal.SetMotorName(name, ID);

            Name = name;
        }

        public void SetTankCapacity(double tankCapacity)
        {
            dal.SetMotorTankCapacity(tankCapacity, ID);

            TankCapacity = tankCapacity;
        }

        public void SetPrice(double price)
        {
            dal.SetMotorPrice(price, ID);

            Price = price;
        }

        public void SetMayTraverseLakes(bool mayTraverseLakes)
        {
            dal.SetMotorMayTraverseLakes(mayTraverseLakes, ID);

            MayTraverseLakes = mayTraverseLakes;
        }

        public static List<Motor> GetAllMotors()
        {
            return dal.GetAllMotors();
        }

        public override string ToString()
        {
            return "[" + ID + "] " + Name;
        }
    }
}

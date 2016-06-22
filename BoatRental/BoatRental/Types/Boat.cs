using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class Boat
    {
        public String Name { get; private set; }
        public Kind Kind { get; private set; }
        public Motor Motor { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Boat(String name, Kind kind, Motor motor)
        {
            Name = name;
            Kind = kind;
            Motor = motor;
        }

        public void SetKind(Kind kind)
        {
            dal.SetBoatKind(kind, Name);

            Kind = kind;
        }

        public void SetMotor(Motor motor)
        {
            dal.SetBoatMotor(motor, Name);

            Motor = motor;
        }

        public static List<Boat> GetAllBoats()
        {
            return dal.GetAllBoats();
        }
    }
}

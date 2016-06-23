using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    public class Kind
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public bool PaysForLock { get; private set; }
        public String Type { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Kind(int id, String name, bool paysForLock, String type)
        {
            ID = id;
            Name = name;
            PaysForLock = paysForLock;
            Type = type;
        }

        public void SetName(String name)
        {
            dal.SetKindName(name, ID);

            Name = name;
        }

        public void SetPaysForLock(bool paysForLock)
        {
            dal.SetKindPaysForLock(paysForLock, ID);

            PaysForLock = paysForLock;
        }

        public void SetType(String type)
        {
            dal.SetKindType(type, ID);

            Type = type;
        }

        public static List<Kind> GetAllKinds()
        {
            return dal.GetAllKinds();
        }
        public override string ToString()
        {
            return "[" + ID + "] " + Name;
        }
    }
}

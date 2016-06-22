using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Types;

namespace BoatRental.Repository
{
    class DAL
    {
        private IRepository repository;
        
        public DAL(IRepository repository)
        {
            this.repository = repository;
        }

        #region Kind type queries
        public int SetKindName(String name, int ID)
        {
            return 0;
        }

        public int SetKindPaysForLock(bool paysForLock, int ID)
        {
            return 0;
        }

        public int SetKindPrice(double price, int ID)
        {
            return 0;
        }

        public int SetKindType(String type, int ID)
        {
            return 0;
        }

        public List<Kind> GetAllKinds()
        {
            return new List<Kind>();
        }
        #endregion

        #region Motor type queries
        public int SetMotorName(String name, int ID)
        {
            return 0;
        }

        public int SetMotorTankCapacity(double tankCapacity, int ID)
        {
            return 0;
        }

        public List<Motor> GetAllMotors()
        {
            return new List<Motor>();
        }
        #endregion

        #region Boat type queries
        public int SetBoatKind(Kind kind, String name)
        {
            return 0;
        }

        public int SetBoatMotor(Motor motor, String name)
        {
            return 0;
        }

        public List<Boat> GetAllBoats()
        {
            return new List<Boat>();
        }
        #endregion

        #region Item type queries
        public int SetItemName(String name, int ID)
        {
            return 0;
        }

        public int SetItemPrice(double price, int ID)
        {
            return 0;
        }

        public List<Item> GetAllItems()
        {
            return new List<Item>();
        }
        #endregion

        #region Lake type queries
        public int SetLakeName(String name, int ID)
        {
            return 0;
        }

        public int SetLakePrice(double price, int ID)
        {
            return 0;
        }

        public List<Lake> GetAllLakes()
        {
            return new List<Lake>();
        }
        #endregion

        #region HireContract type queries
        public int AddHireContractDateEnd(DateTime date, int id)
        {
            return 0;
        }
        #endregion

        #region User type queries
        public int AddUserHireContract(HireContract hireContract, String emailaddress)
        {
            return 0;
        }

        public User ValidateUser(String emailaddress, String password)
        {
            return new User("dummy", "dummy", true);
        }
        #endregion

        #region CONFIG type queries
        public Dictionary<String, object> GetCONFIG()
        {
            return new Dictionary<string, object>();
        }

        public int SetCONFIGFrieschLakePrice(double frieschLakePrice)
        {
            return 0;
        }

        public int SetCONFIGFrieschLakes(int frieschLakes)
        {
            return 0;
        }

        public int SetCONFIGLockPrice(double lockPrice)
        {
            return 0;
        }

        public int SetCONFIGMaxFrieschLakes(int maxFrieschLakes)
        {
            return 0;
        }
        #endregion
    }
}

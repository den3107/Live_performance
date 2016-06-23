using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Types;

namespace BoatRental.Repository
{
    public class DAL
    {
        private IRepository repository;
        
        public DAL(IRepository repository)
        {
            this.repository = repository;
        }

        #region Kind type queries
        public int SetKindName(String name, int ID)
        {
            return repository.SetKindName(name, ID);
        }

        public int SetKindPaysForLock(bool paysForLock, int ID)
        {
            return repository.SetKindPaysForLock(paysForLock, ID);
        }

        public int SetKindType(String type, int ID)
        {
            return repository.SetKindType(type, ID);
        }

        public List<Kind> GetAllKinds()
        {
            return repository.GetAllKinds();
        }
        #endregion

        #region Motor type queries
        public int SetMotorName(String name, int ID)
        {
            return repository.SetMotorName(name, ID);
        }

        public int SetMotorTankCapacity(double tankCapacity, int ID)
        {
            return repository.SetMotorTankCapacity(tankCapacity, ID);
        }

        public int SetMotorPrice(double price, int ID)
        {
            return repository.SetMotorPrice(price, ID);
        }

        public int SetMotorMayTraverseLakes(bool mayTraverseLakes, int ID)
        {
            return repository.SetMotorMayTraverseLakes(mayTraverseLakes, ID);
        }

        public List<Motor> GetAllMotors()
        {
            return repository.GetAllMotors();
        }
        #endregion

        #region Boat type queries
        public int SetBoatKind(Kind kind, String name)
        {
            return repository.SetBoatKind(kind, name);
        }

        public int SetBoatMotor(Motor motor, String name)
        {
            return repository.SetBoatMotor(motor, name);
        }

        public List<Boat> GetAllBoats()
        {
            return repository.GetAllBoats();
        }
        #endregion

        #region Item type queries
        public int SetItemName(String name, int ID)
        {
            return repository.SetItemName(name, ID);
        }

        public int SetItemPrice(double price, int ID)
        {
            return repository.SetItemPrice(price, ID);
        }

        public List<Item> GetAllItems()
        {
            return repository.GetAllItems();
        }
        #endregion

        #region Lake type queries
        public int SetLakeName(String name, int ID)
        {
            return repository.SetLakeName(name, ID);
        }

        public int SetLakePrice(double price, int ID)
        {
            return repository.SetLakePrice(price, ID);
        }

        public List<Lake> GetAllLakes()
        {
            return repository.GetAllLakes();
        }
        #endregion

        #region HireContract type queries
        #endregion

        #region User type queries
        public HireContract AddUserHireContract(int friescheLakes, DateTime dateStart, DateTime dateEnd, List<Boat> boats, String hirerEmailaddress, List<Item> items = null, List<Lake> lakes = null)
        {
            return repository.AddUserHireContract(friescheLakes, dateStart, dateEnd, boats, hirerEmailaddress, items, lakes);
        }

        public User ValidateUser(String emailaddress, String password)
        {
            return repository.ValidateUser(emailaddress, password);
        }
        #endregion

        #region CONFIG type queries
        public Dictionary<String, object> GetCONFIG()
        {
            return repository.GetCONFIG();
        }

        public int SetCONFIGFrieschLakePrice(double frieschLakePrice)
        {
            return repository.SetCONFIGFrieschLakePrice(frieschLakePrice);
        }

        public int SetCONFIGFrieschLakes(int frieschLakes)
        {
            return repository.SetCONFIGFrieschLakes(frieschLakes);
        }

        public int SetCONFIGLockPrice(double lockPrice)
        {
            return repository.SetCONFIGLockPrice(lockPrice);
        }

        public int SetCONFIGMaxFrieschLakes(int maxFrieschLakes)
        {
            return repository.SetCONFIGMaxFrieschLakes(maxFrieschLakes);
        }
        #endregion
    }
}

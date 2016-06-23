using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Types;

namespace BoatRental.Repository
{
    public interface IRepository
    {
        #region Kind type queries
        int SetKindName(String name, int ID);

        int SetKindPaysForLock(bool paysForLock, int ID);

        int SetKindType(String type, int ID);

        List<Kind> GetAllKinds();
        #endregion

        #region Motor type queries
        int SetMotorName(String name, int ID);

        int SetMotorTankCapacity(double tankCapacity, int ID);

        int SetMotorPrice(double price, int ID);

        int SetMotorMayTraverseLakes(bool mayTraverseLakes, int ID);

        List<Motor> GetAllMotors();
        #endregion

        #region Boat type queries
        int SetBoatKind(Kind kind, String name);

        int SetBoatMotor(Motor motor, String name);

        List<Boat> GetAllBoats();
        #endregion

        #region Item type queries
        int SetItemName(String name, int ID);

        int SetItemPrice(double price, int ID);

        List<Item> GetAllItems();
        #endregion

        #region Lake type queries
        int SetLakeName(String name, int ID);

        int SetLakePrice(double price, int ID);

        List<Lake> GetAllLakes();
        #endregion

        #region HireContract type queries
        #endregion

        #region User type queries
        HireContract AddUserHireContract(int friescheLakes, DateTime dateStart, DateTime dateEnd, List<Boat> boats, String hirerEmailaddress, List<Item> items = null, List<Lake> lakes = null);

        User ValidateUser(String emailaddress, String password);
        #endregion

        #region CONFIG type queries
        Dictionary<String, object> GetCONFIG();

        int SetCONFIGFrieschLakePrice(double frieschLakePrice);

        int SetCONFIGFrieschLakes(int frieschLakes);

        int SetCONFIGLockPrice(double lockPrice);

        int SetCONFIGMaxFrieschLakes(int maxFrieschLakes);
        #endregion
    }
}

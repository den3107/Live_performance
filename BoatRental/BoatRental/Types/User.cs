using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    public class User
    {
        public String Emailaddress { get; private set; }
        public String Name { get; private set; }
        public bool IsAdmin { get; private set; }
        public List<HireContract> HireContracts { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public User(String emailaddress, String name, bool isAdmin, List<HireContract> hireContracts = null)
        {
            Emailaddress = emailaddress;
            Name = name;
            IsAdmin = isAdmin;
            HireContracts = hireContracts ?? new List<HireContract>();
        }

        public void AddHireContract(int friescheLakes, DateTime dateStart, DateTime dateEnd, List<Boat> boats, List<Item> items = null, List<Lake> lakes = null)
        {
            HireContract hireContract = dal.AddUserHireContract(friescheLakes, dateStart, dateEnd, boats, Emailaddress, items, lakes);

            HireContracts.Add(hireContract);
        }

        public static User ValidateUser(String emailaddress, String password)
        {
            return dal.ValidateUser(emailaddress, password);
        }
    }
}

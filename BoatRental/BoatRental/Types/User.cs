using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class User
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

        public void AddHireContract(HireContract hireContract)
        {
            dal.AddUserHireContract(hireContract, Emailaddress);

            HireContracts.Add(hireContract);
        }

        public static User ValidateUser(String emailaddress, String password)
        {
            return dal.ValidateUser(emailaddress, password);
        }
    }
}

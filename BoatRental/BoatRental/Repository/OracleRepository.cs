using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.Repository
{
    class OracleRepository : IRepository
    {
        private readonly string connectionstring = "User Id=LP;Password=LP;Data Source=192.168.19.128";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.Repository
{
    class DAL
    {
        private IRepository repository;
        
        public DAL(IRepository repository)
        {
            this.repository = repository;
        }

        public int SetName(String name)
        {
            return 0;
        }

        public int SetPaysForLock(bool paysForLock)
        {
            return 0;
        }

        public int SetPrice(double price)
        {
            return 0;
        }

        public int SetType(String type)
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSolution.Models
{
    public class ClientLayer
    {
        CarOrderContext db = new CarOrderContext();

        //All Clients
        public IEnumerable<Client> GetClients()
        {
            try
            {
                return db.Client.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSolution.Models
{
    public class CarLayer
    {
        CarOrderContext db = new CarOrderContext();

        //All Cars
        public IEnumerable<Car> GetCars()
        {
            try
            {
                return db.Car.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}

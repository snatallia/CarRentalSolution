using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSolution.Models
{
    public class CarOrderLayer
    {
        CarOrderContext db = new CarOrderContext();
        
        //All Car Orders
        public IEnumerable<CarOrder> GetAllCarOrders()
        {
            try
            {
                return db.CarOrder.ToList();
            }
            catch
            {
                throw;
            }
        }

        //Find CarOrder by ID
        public CarOrder GetOrderByID(int id)
        {
            try
            {
                return db.CarOrder.Find(id);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Add new order record   
        public int AddOrder(CarOrder order)
        {
            try
            {
                db.CarOrder.Add(order);
                db.SaveChanges();
                int orderID = order.CarOrderId;
                return orderID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //Update the records for selected order  
        public int UpdateOrder(CarOrder order)
        {
            try
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Delete order
        public int DeleteOrder(int id)
        {
            try
            {
                CarOrder order = db.CarOrder.Find(id);
                db.CarOrder.Remove(order);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }



        ////Get the details of a client by ID
        //public Client GetClientData(int id)
        //{
        //    try
        //    {
        //        Client client = db.Client.Find(id);
        //        return client;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        ////Get the list of Clients
        //public List<Client> GetAllClients()
        //{
        //    List<Client> clients = new List<Client>();
        //    clients = (from Surname in db.Client select Surname).ToList();
        //    return clients;
        //}

        ////Get the details of a car by ID
        //public Car GetCartData(int id)
        //{
        //    try
        //    {
        //        Car car = db.Car.Find(id);
        //        return car;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //Get the list of Cars
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            cars = (from Model in db.Car select Model).ToList();
            return cars;
        }

    }
}
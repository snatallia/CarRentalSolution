using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalSolution.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentalSolution.Controllers
{
    
    public class OrderController : Controller
    {
        CarOrderLayer orders = new CarOrderLayer();

        // GET: api/<controller>        
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<CarOrder> GetCarOrders()
        {            
            return orders.GetAllCarOrders();
        }

        //// GET api/<controller>/5
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public CarOrder GetCarOrder(int id)
        {
            CarOrder order = orders.GetOrderByID(id);
            return order;
        }

        //// POST api/<controller>
        [HttpPost]
        [Route("api/[controller]/add")]
        public int Add([FromBody]CarOrder newOrder)
        {           
            return orders.AddOrder(newOrder);
        }

        //// PUT api/<controller>/5
        [HttpPut]
        [Route("api/[controller]/edit")]        
        public int Edit([FromBody]CarOrder order)
        {
            return orders.UpdateOrder(order);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("api/[controller]/delete/{id}")]
        //[Route("api/CarOrder/Delete/{id}")]
        public int Delete(int id)
        {
            return orders.DeleteOrder(id);
        }


                          



        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public Client GetClient(int id)
        //{
        //    return orders.GetClientData(id);

        //}

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PCAzureWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TruyumController : ControllerBase
    {
        public static List<MenuItem> menuItems = new List<MenuItem>
        {
            new MenuItem{ Menucode=1,ItemName="Sandwich",Price=99,active=true,date_of_launch=Convert.ToDateTime("15-03-2017 00:00:00"),CategoryId=2,freeDelivery=true }

          
        };
        // GET: api/Truyum
        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return menuItems;
        }


        // POST api/<TruyumController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TruyumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TruyumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

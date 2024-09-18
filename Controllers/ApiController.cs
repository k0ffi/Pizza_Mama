using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {

        DataContext dataContext;

       public ApiController( DataContext dataContext)

        {
            this.dataContext = dataContext;
        }
        // GET: Pizas/values
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            // recuperer le DataContext
            var pizzas = dataContext.Pizzas.ToList();




            return Json(pizzas);


        }
       
    }
}


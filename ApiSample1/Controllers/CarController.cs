using ApiSample1.Models.CarModels;
using BL1.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample1.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly ICarService _iCarService;

        public CarController(ICarService iCarService)
        {
            _iCarService = iCarService;


        }


        [HttpGet("GetBAsicCar")]
        public int GetCar()
        {

            return 1;
        }
        [HttpPost]
        public async Task<ActionResult> Post(Car car)
        {

           int yy= await _iCarService.Get1();
            /*   if (car.Id > 20)
               {
                   return StatusCode(500);
               }*/

            try {

            }
            catch (Exception e) { 
            
            }
            return Json(yy);
        
        }

        [HttpPut]
        public int Put(Car car)
        {
            return 1;

        }

        [HttpDelete]
        public int Delete(Car car)
        {
            return 1;

        }
    }
}

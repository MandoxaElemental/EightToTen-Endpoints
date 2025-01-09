using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPicker : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
        public RestaurantPicker(RestaurantPickerServices restaurantPickerServices){
            _restaurantPickerServices = restaurantPickerServices;
        }
        [HttpPost]
        [Route("yourFood/{yourChoice}")]
        public List<string> yourFood(string yourChoice){
            return _restaurantPickerServices.yourFood(yourChoice);
        }

    }
}
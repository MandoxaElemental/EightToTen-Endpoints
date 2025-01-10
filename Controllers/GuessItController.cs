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
    public class GuessIt: ControllerBase
    {
        private readonly GuessItEasyServices _guessItEasyServices;
        private readonly GuessItMediumServices _guessItMediumServices;
        private readonly GuessItHardServices _guessItHardServices;
        public GuessIt(GuessItEasyServices guessItEasyServices, GuessItMediumServices guessItMediumServices, GuessItHardServices guessItHardServices){
            _guessItEasyServices = guessItEasyServices;
            _guessItMediumServices = guessItMediumServices;
            _guessItHardServices = guessItHardServices;
        }
        [HttpPost]
        [Route("guessIt/{yourInput}")]
        public List<string> YourAnswerEasy(string yourInput){
            return _guessItEasyServices.YourAnswerEasy(yourInput);
        }
        [HttpPost]
        [Route("guessIt/{yourInput}")]
        public List<string> YourAnswerMedium(string yourInput){
            return _guessItMediumServices.YourAnswerMedium(yourInput);
        }
        [HttpPost]
        [Route("guessIt/{yourInput}")]
        public List<string> YourAnswerHard(string yourInput){
            return _guessItHardServices.YourAnswerHard(yourInput);
        }
        

    }
    
}
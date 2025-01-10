using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen_Endpoints.Services
{
    public class GuessItEasyServices
    {
        public List<string> easyAnswer = new();
        public Random rng = new Random();
        public List<string> YourAnswerEasy(string yourInput){
            int easyMode = rng.Next(1, 11);
            int intGuess;
            bool boolGuess = int.TryParse(yourInput, out intGuess);

            if (boolGuess)
            {

                    //Easy Mode
                    if (intGuess == easyMode)
                    {
                        easyAnswer.Add($"Wow, you actually did it! I was thinking of {easyMode}!");
                        return easyAnswer;

                    }
                    else if (intGuess >= 11)
                    {
                        easyAnswer.Add($"Buddy, you chose Easy Mode. Keep your guess within the Parameters");
                        return easyAnswer;
                    }
                    else if (intGuess > easyMode)
                    {
                        easyAnswer.Add("You're too high");
                        return easyAnswer;
                    }
                    else
                    {
                        easyAnswer.Add("You're too low");
                        return easyAnswer;
                    }

                }
                easyAnswer.Add("ERROR");
                return easyAnswer;
        }
    }
}
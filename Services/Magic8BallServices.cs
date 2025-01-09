using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen_Endpoints.Services
{
    public class Magic8BallServices
    {

        public List<string> resultList = new();
        public Random rng = new Random();
        public string[] answers = { "YES", "NO", "MAYBE", "I DON'T KNOW", "PROBABLY", "GIVE ME TWO WEEKS BEFORE I GIVE MY FINAL ANSWER", "ONCE IN A BLUE MOON", "DON'T ASK QUESTIONS YOU MAY NOT WANT TO THE ANSWERS TO..." };
        public List<string> YourQuestion(string userInput)
        {
            int ourRandomNumber = rng.Next(0, 9);
            resultList.Add("You have asked: " + userInput + " - My answer to you is: " + answers[ourRandomNumber]);
            return resultList;

        }
    }
}
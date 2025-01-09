using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen_Endpoints.Services
{
    public class RestaurantPickerServices
    {
    public List<string> resultList = new();
    Random rng = new Random();
    string[] burgers = { "In-n-Out", "McDonalds", "Burger King", "Five Guys", "The Habit", "Jack in the Box", "Wendys", "Red Robin", "Chilli's", "Whataburger"};
    string[] tacos = { "Taco Bell", "Del Taco", "Rubios", "Chipotle", "El Pollo Loco", "Café Rio", "Baja Fresh", "Qdoba", "On the Border Mexican Grill & Cantina", "Taco John's"};
    string[] chicken = { "Chick-fil-A", "Raising Canes", "Wing Stop", "PopeYES", "KFC", "Church's Texas Chicken", "Buffalo Wild Wings", "Zaxby's", "Jollibee's", "Bonchon"};
    string[] pizza = { "Pizza Hut", "Round Table", "Domino's", "Little Caesars", "Mountain Mike's", "Pizza Guys", "Shakey's Pizza", "CiCis Pizza", "MOD Pizza", "Papa Murphy’s"};
    string[] other = { "Panda Express", "Sonic", "Dunkin Donuts", "Dairy Queen", "Arby's", "Papa Johns", "Jersey Mike's", "Firehouse Subs", "Panera Bread", "Subway" };
    public List<string> yourFood(string yourChoice)
        {
            
            int ourRandomNumber = rng.Next(other.Length);
            string foodChoice = yourChoice.ToUpper();
            switch (foodChoice)
            {
                case "BURGERS":
                resultList.Add("You have picked Burgers: How about some: " + burgers[ourRandomNumber]);
                break;
                
                case "TACOS":
                resultList.Add("You have picked Tacos: How about some: " + tacos[ourRandomNumber]);
                break;

                case "CHICKEN":
                resultList.Add("You have picked Chicken: How about some: " + chicken[ourRandomNumber]);
                break;

                case "PIZZA":
                resultList.Add("You have picked Pizza: How about some: " + pizza[ourRandomNumber]);
                break;

                case "OTHER":
                resultList.Add("You have picked Other: How about some: " + other[ourRandomNumber]);
                break;

                default:
                resultList.Add("Please enter one of the Following: BURGER / TACOS / CHICKEN / PIZZA / OTHER");
                break;
            }
            return resultList;
        }
    }
}
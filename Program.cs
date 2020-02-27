using System;
using System.Collections.Generic;
using Plantary.Models;
using System.Drawing;
// using Console = Colorful.Console;

namespace Plantary
{
  public class Program
  {
    public static Plant usersPlant = new Plant();
    static void Main()
    {
      Console.WriteLine("WELCOME TO PLANTARY");
      Console.WriteLine("Click start to buy a new plant, or say bye to exit");
      string response = Console.ReadLine();

      if(response.ToLower() == "start")
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations on your new plant!\nYou will need to feed, water, and give it sun in appropriate amounts.\nYou can do any action per round by typing 'Feed', 'Water', 'Sun', and then type next day to see if it's grown. Or type 'Exit' to return to this menu.");
        Console.Write("Good Luck!\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Feed  ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Water  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Sun  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("NextDay  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Exit");
        Console.ResetColor();

        UsersActions();
      }
      else 
      {
        Console.WriteLine("Goodbye!");
      }
    }
       
    public static void UsersActions()
    {
      string action = Console.ReadLine().ToLower();

      if (action == "feed")
      {
        usersPlant.Feed();
        UsersActions();
      }
      else if (action == "water")
      {
        usersPlant.WaterPlant();
        UsersActions();
      }
      else if (action == "sun")
      {
        usersPlant.Sun();
        UsersActions();
      }
      else if (action == "nextday")
      {
        usersPlant.NextDay();
        Console.WriteLine(InformGrowth());
        Console.WriteLine("=========================================================");
        UsersActions();
      }
      else if (action == "exit")
      {
        Main();
      }
      else 
      {
        UsersActions();
      }
    }
    //method ShouldGrowing
    public static string InformGrowth()
    {
      Console.WriteLine("=========================================================");
      Console.WriteLine($"Your plant's vitals are:\n Water: {usersPlant.Water} \n Sun Exposure: {usersPlant.SunExposure} \n Food: {usersPlant.Food}");
      if(usersPlant.Food <= 0 || usersPlant.Food > 3)
      {
        return "Uh oh! You did something wrong! Plant isnt growing";
      }
      else if(usersPlant.SunExposure <= 0 || usersPlant.SunExposure > 3)
      {
        return "Uh oh! You did something wrong! Plant isnt growing";
      }
      else if(usersPlant.Water <= 0 || usersPlant.Water > 3)
      {
        return "Uh oh! You did something wrong! Plant isnt growing";
      }
      else
      {
        usersPlant.Grow();
        return $"Your plant grew to {usersPlant.Size} inches tall!";
      }

      // Console.WriteLine("=========================================================")
    }
  }
 
}
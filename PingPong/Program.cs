using System;
using PingPong.Models;
using System.Collections.Generic;

// UI logic and entry point for the application

namespace PingPong 
{
  class Program
  {
    static void Main() 
    {
      Console.WriteLine("Enter a number:");
      string input = Console.ReadLine();
      int number = int.Parse(input); 

      List<string> result = PingPongClass.GetOutput(number);
      for (int i = 0; i < result.Count; i++)
      {
        Console.WriteLine(result[i]);
      }
      Console.ReadLine();
    }
  }
}



// static void Main(string[] args)
//     {
//       Console.WriteLine("Enter a number:");
//       int input = Convert.ToInt32(Console.ReadLine());

//       foreach (string result in PingPong.GetOutput(input))
//       {
//         Console.WriteLine(result);
//       }
//       Console.ReadLine();
//     }
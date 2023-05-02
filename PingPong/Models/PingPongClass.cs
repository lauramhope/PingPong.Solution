using System.Collections.Generic; 

// Business Logic 
namespace PingPong.Models
{
  public class PingPongClass
  {
    public static List<string> GetOutput(int input) 
    {
      List<string> output = new List<string> {};
      for (int i = 1; i <= input; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          output.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          output.Add("ping");
        }
        else if (i % 5 == 0)
        {
          output.Add("pong");
        }
        else
        {
          output.Add(i.ToString());
        }
      }
      return output;
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pong
{
  public class PingPong
  {
    public static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(PingPongGenerator(userNumber));
    }

    public static string PingPongGenerator(int userNumber)
    {
        List<int> lst = new List<int>();
        for (int i=1; i<=userNumber; i+=1)
        {
            lst.Add(i);
        }
        List<string> lstString = new List<string>();
        foreach(int num in lst)
        {
            if (num%3==0 && num%5==0)
            {
                lstString.Add("ping-pong");
            }
            else if (num%5==0)
            {
                lstString.Add("pong");
            }
            else if (num%3==0)
            {
                lstString.Add("ping");
            }
            else
            {
                lstString.Add(num.ToString());
            }
        }
        return(string.Join( ",", lstString.ToArray() ));
    }
  }
}
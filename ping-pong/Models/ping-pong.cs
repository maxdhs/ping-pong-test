using System;
using System.Collections.Generic;
using System.Linq;

namespace Pong
{
  public class PingPong
  {
    public string PingPongGenerator(int userNumber)
    {
        
            if (userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                return "ping-pong";
            }
            else if (userNumber % 5 == 0)
            {
                return "pong";
            }
            else if (userNumber % 3 == 0)
            {
                return "ping";
            }
            else
            {
                return userNumber.ToString();
            }

  }
}
}
        //     else if (num%5==0)
        //     {
        //         lstString.Add("pong");
        //     }
        //     else if (num%3==0)
        //     {
        //         lstString.Add("ping");
        //     }
        //     else
        //     {
        //         lstString.Add(num.ToString());
        //     }
        // }
        // return(string.Join( ",", lstString.ToArray() ));

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paxos
{
  
    public class NewLeaderNotificationMessage : Message
    {
        public int Num {  get; set; }
        public NewLeaderNotificationMessage(int num)
        {
            this.Num = num;
          
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paxos
{
  
    public class NewLeaderNotificationMessage : Message
    {
        public int num {  get; set; }
        public NewLeaderNotificationMessage(int num)
        {
            this.num = num;
          
        }
        public int getNum()
        {
            return num;
        }
    }
}

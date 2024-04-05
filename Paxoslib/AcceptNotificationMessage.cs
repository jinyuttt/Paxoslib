using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paxos
{
   
    public class AcceptNotificationMessage<TValue> : Message  
    {
        public int Test { get; set; } = 6;
        public Proposal<TValue> Proposal { get; set; }

        public AcceptNotificationMessage()
        {

        }
        public AcceptNotificationMessage(Proposal<TValue> proposal)
        {
            this.Proposal = proposal;
          
        }
        
       

       
            
    }  
}

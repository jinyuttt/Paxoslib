using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paxos
{
   
    public class AcceptNotificationMessage<TValue> : Message  
    {
      
        public Proposal<TValue> Proposal { get; set; }

       
        public AcceptNotificationMessage(Proposal<TValue> proposal)
        {
            this.Proposal = proposal;
          
        }
        
       

       
            
    }  
}

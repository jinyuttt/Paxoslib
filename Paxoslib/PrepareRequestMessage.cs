namespace Paxos
{

    public class PrepareRequestMessage : Message  
    {          
        public int csn;          
        public int psn;   
        public PrepareRequestMessage()
        {

        }
        public PrepareRequestMessage(int csn, int psn)          
        {                  
            this.csn = csn;                  
            this.psn = psn;
          
        }                    
        
        public int getPsn()          
        {                  
            return psn;          
        }                    
        public int getCsn()          
        {                  
            return csn;          
        }  
    }
}

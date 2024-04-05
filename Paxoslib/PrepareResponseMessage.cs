namespace Paxos
{
    public class PrepareResponseMessage<TValue> : Message  
    {          
        public int csn {  get; set; }
        public int minPsn {  get; set; }

        public Proposal<TValue> proposal {  get; set; } 
        
        public PrepareResponseMessage()
        {

        }

        public PrepareResponseMessage(int csn, int minPsn, Proposal<TValue> proposal)          
        {                  
            this.proposal = proposal;                  
            this.minPsn = minPsn;                  
            this.csn = csn;
           
        }                    
        
        public Proposal<TValue> getProposal()          
        {                  
            return proposal;          
        }                    
        
        public int getCsn()          
        {                  
            return csn;          
        }                    
        
        public int getMinPsn()          
        {                  
            return minPsn;          
        }  
    }  
}

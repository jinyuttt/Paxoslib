namespace Paxos
{
    public class PrepareResponseMessage<TValue> : Message  
    {          
        public int Csn {  get; set; }
        public int MinPsn {  get; set; }

        public Proposal<TValue> Proposal {  get; set; } 
        
      

        public PrepareResponseMessage(int csn, int minPsn, Proposal<TValue> proposal)          
        {                  
            this.Proposal = proposal;                  
            this.MinPsn = minPsn;                  
            this.Csn = csn;
           
        }                    
        
       
    }  
}

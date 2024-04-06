namespace Paxos
{

    public class PrepareRequestMessage : Message  
    {          
        public int Csn {  get; set; }       
        public int Psn {  get; set; } 
        public PrepareRequestMessage()
        {

        }
        public PrepareRequestMessage(int csn, int psn)          
        {                  
            this.Csn = csn;                  
            this.Psn = psn;
          
        }                    
        
     
    }
}

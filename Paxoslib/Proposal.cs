namespace Paxos
{

    public class Proposal<TValue>  
    {
        public int csn {  get; set; }
        public int psn {  get; set; }
        public TValue value { get;set; }                  
        
        public Proposal()
        {

        }
        public Proposal(int csn, int psn, TValue value)          
        {                  
            this.csn = csn;                  
            this.psn = psn;                  
            this.value = value;          
        }                    
        
        public int getCsn()          
        {                  
            return csn;          
        }                    
        
        public int getPsn()          
        {                  
            return psn;          
        }                    
        
        public TValue getValue()          
        {                  
            return value;          
        }                    
        
        public String toString()          
        {                  
            return "{" + csn + ", " + psn + ", " + value.ToString() + "}";          
        }  
    }  
}

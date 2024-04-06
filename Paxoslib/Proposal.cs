namespace Paxos
{

    public class Proposal<TValue>  
    {
        public int Csn {  get; set; }
        public int Psn {  get; set; }
        public TValue Value { get;set; }                  
        
        public Proposal()
        {

        }
        public Proposal(int csn, int psn, TValue value)          
        {                  
            this.Csn = csn;                  
            this.Psn = psn;                  
            this.Value = value;          
        }                    
        
        //public int getCsn()          
        //{                  
        //    return csn;          
        //}                    
        
        //public int getPsn()          
        //{                  
        //    return psn;          
        //}                    
        
        //public TValue getValue()          
        //{                  
        //    return value;          
        //}                    
        
        public String toString()          
        {                  
            return "{" + Csn + ", " + Psn + ", " + Value.ToString() + "}";          
        }  
    }  
}

namespace Paxos
{

    // For serialization reasons, this class is separate from the Node class  

    public class NodeLocation 
    {  
        public String Host {  get; set; }
        public int Port {  get; set; }

        public int Num {  get; set; }
        public bool IsLeader {get;set;}    

       public string NodeName {  get; set; }    
        
        public NodeLocation(String host, int port, int num)  
        {  
            this.Host = host;  
            this.Port = port;  
            this.Num = num;  
            this.IsLeader = false;  
        }    
        
        public void becomeLeader()  
        {  
            IsLeader = true;  
        }    
        
        public void BecomeNonLeader()  
        {  
            IsLeader = false;  
        }    
       
        public override string ToString()  
        {  
            return Num.ToString();  
        }  
    }  
}

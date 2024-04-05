namespace Paxos
{

    // For serialization reasons, this class is separate from the Node class  

    public class NodeLocation 
    {  
        public String host {  get; set; }
        public int port {  get; set; }

        public int num {  get; set; }
        public bool isLeader {get;set;}    

        public NodeLocation()
        {

        }
        
        public NodeLocation(String host, int port, int num)  
        {  
            this.host = host;  
            this.port = port;  
            this.num = num;  
            this.isLeader = false;  
        }    
        
        public void becomeLeader()  
        {  
            isLeader = true;  
        }    
        
        public void becomeNonLeader()  
        {  
            isLeader = false;  
        }    
        
        
        public String getHost()  
        {  
            return host;  
        }    
        
        public int getPort()  
        {  
            return port;  
        }    
        
        public int getNum()  
        {  
            return num;  
        }    
        
        public override String ToString()  
        {  
            return num.ToString();  
        }  
    }  
}

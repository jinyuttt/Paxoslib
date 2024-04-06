namespace Paxos
{

    public abstract class Message 
    {
       
       

        public NodeLocation Sender
        {
            get;set;
        }

      
        public NodeLocation Receiver
        {
            get;set;
        }

       
    }  
}

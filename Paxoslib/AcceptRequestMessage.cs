namespace Paxos
{

    public class AcceptRequestMessage<TValue> : Message
    {
        public Proposal<TValue> Proposal {  get; set; }
        
        public AcceptRequestMessage(Proposal<TValue> proposal)
        {
            this.Proposal = proposal;
          
        }


    }
}

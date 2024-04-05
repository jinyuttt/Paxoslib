namespace Paxos
{

    public class AcceptRequestMessage<TValue> : Message
    {
        public Proposal<TValue> proposal {  get; set; }
        
        public AcceptRequestMessage(Proposal<TValue> proposal)
        {
            this.proposal = proposal;
          
        }

        public Proposal<TValue> getProposal()
        {
            return proposal;
        }
    }
}

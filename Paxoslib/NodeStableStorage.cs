namespace Paxos
{

    //For serialization reasons, this class is separate from the Node class  

    public class NodeStableStorage<TValue> 
    {  
        public Dictionary<int, int> MinPsns { get;set; }
        public Dictionary<int, Proposal<TValue>> MaxAcceptedProposals {  get;set; }  
    }  
}

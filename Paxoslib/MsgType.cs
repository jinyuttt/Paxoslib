using Paxos;
using System.Diagnostics.CodeAnalysis;

namespace Paxoslib
{
    internal class MsgType
    {
        static Dictionary<string, byte>  keys = new Dictionary<string, byte>() { [nameof(HeartbeatMessage)]= 1,
            [nameof(AcceptNotificationMessage<string>)] = 2,
            [nameof(AcceptRequestMessage<string>)] = 3,
            [nameof(NewLeaderNotificationMessage)] = 4,
            [nameof(PrepareRequestMessage)] = 5,
            [nameof(PrepareResponseMessage<string>)] = 6,
        };
        static Dictionary<byte, Type> msgType = new Dictionary<byte, Type>() { [1] = typeof(HeartbeatMessage) ,
            [2]= typeof(AcceptNotificationMessage<string>) ,
            [3]= typeof(AcceptRequestMessage<string>) ,
            [4]=typeof(NewLeaderNotificationMessage),
            [5]=typeof(PrepareRequestMessage),
            [6]=typeof(PrepareResponseMessage<string>)
        };
     
        public static byte[] GetBytes(string name, byte[] data)
        {
            byte[] buf=new byte[data.Length+1];
            data.CopyTo(buf, 1);
            keys.TryGetValue(name, out buf[0]);
          
            return buf;
        }

        public static Message ConvertMsg(byte[] data)
        {
            Memory<byte> memory = new Memory<byte>(data);
            Type type = msgType.GetValueOrDefault(data[0], typeof(Msg));
            var span = memory.Slice(1).Span;
            object obj = Util.Deserialize(span.ToArray(), type);
            
            return (Message)obj;

        }
    }
}

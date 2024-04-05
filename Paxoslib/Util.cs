using Newtonsoft.Json;
using System.Text;
using System.Text.Unicode;


namespace Paxoslib
{
    internal class Util
    {
        public static byte[] Serializer<T>(T obj) 
        {
            string json= JsonConvert.SerializeObject(obj);
            byte[] bytes=Encoding.UTF8.GetBytes(json);
            return bytes;
           
        }

        public static T Deserialize<T>(byte[] bytes)
        {
            string json= Encoding.UTF8.GetString(bytes);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static Object Deserialize(byte[]  data,Type type)
        {
           string json = Encoding.UTF8.GetString(data);
            Object obj = JsonConvert.DeserializeObject(json, type);
            return obj;
        }
    }
}

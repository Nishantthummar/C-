using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace header
{
    public class DataHeader
    {
        public byte dataType;
        public byte sensorId;
        public byte timeStampuSec; // 4 byte
        public byte timeStampHrs;  // 6 bit
        public byte sampleCountIncre; // 5 bit
        public byte reserved1; // 1 bit
        public byte sampleCount; // 3 byte
        public byte timeDeltaUnit; // 4 bit
        public byte timeDelta; // 12 bit
        public byte dataFormat; // 4 bit
        public byte fixedPointM; // 5 bit
        public byte reserved2; // 1 bit
        public byte dataCount; // 10 bit

         public T serializ<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }
        
       
        /*public DataHeader (byte[] data)
        {
            if (data == null) { }
                //default(DataHeader);
            BinaryFormatter bf = new BinaryFormatter();
            using(MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                
            }

            
        }*/





    }
}

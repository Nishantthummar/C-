using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DataHeader
{
    class header
    {
        public  byte dataType;
        public byte SensorId;
        public byte[] timeStampUsec;
        public byte timeStampHrs;
        public byte sampleCountInc;
        public byte reserved1;
        public byte sampleCount;
        public byte timeDeltaUnit;
        public byte timeDelta;
        public byte dataFormat;
        public byte fixedPointM;
        public byte reserver2;
        public byte dataCount;

        public header () { 
        
            
        }
        public header (byte dataType, byte SensorId)
        {
            this.dataType = dataType;
            this.SensorId = SensorId;
        }

        /*public header Serializ(byte[] data)
        {
            //public T FromByteArray<T>(byte[] data)
            //{
            if (data == null)
                return default(header);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                // try
                //{
                object obj = bf.Deserialize(ms);
                return (header)obj;

                //  }
                //catch (Exception ex)
                // {
                //   MessageBox.Show("Exception");
                return default(header);
                //}
            }


        }*/

        public string Spiter(byte[] data)
        {
            //data.Reverse();
            /*this.dataType = data.ElementAt(0);
            this.SensorId = data.ElementAt(1);
            */
            int i = 0;
            int j = 0;
            byte[] temp = new byte[100];

            for (i = 8; i <15; i++)
             {
                temp[j] = data[i];
                j++;


             }
            byte[] dataCopy = new byte[100];
            //data.Reverse();
           
            //byte[] data1 = { };
            //data.CopyTo(data1, 2);

            /*if (dataCopy == null)
            {
                //return default(header);
                return "";
            }*/

            long x = BitConverter.ToInt64(data, 0);
            long z= (BitConverter.ToInt64(temp, 0));
            //string a = Convert.ToString(x) + Convert.ToString(z);

            string s = Convert.ToString(z, 2);
            string y = Convert.ToString(x, 2); // To convert into binary
            string tot = s + y;
            /*BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            object obj = bf.Deserialize(ms);*/
            

            Console.WriteLine(tot);
            return tot;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fheader
{
    class header
    {
        public byte dataType;
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

        public void spliter(byte[] data)
        {
            this.dataType = data.ElementAt(0); // done 1 byte
            this.SensorId = data.ElementAt(1); // done 1 byte
            int i = 0;
            byte cpy = new byte();
            int iTemp1, iTemp2 = new int();
            byte bTemp1, bTemp2 = new byte();

            byte[] vs = new byte[4];
            int j = 0;
            for (i=2; i<6; i++)
            {
                vs[j] = data[i];
                j++;
            }
            this.timeStampUsec = vs; // done 4 bytes
            cpy = data[6];
            int temp = Convert.ToInt32(cpy);
            int final = temp >> 2;
            this.timeStampHrs = Convert.ToByte(final); //done 6-bit
            iTemp1 = 6 << temp;
            cpy = data[7];
            temp = Convert.ToInt32(cpy);
            iTemp2 = temp >> 2;

           /* bTemp1 = Convert.ToByte(iTemp1);
            bTemp2 = Convert.ToByte(iTemp2);
            bTemp1 = bTemp1 | bTemp2;*/



            
            final = iTemp1 + iTemp2;
            final = final >> 3;
           // this.sampleCountInc = Convert.ToByte(final);










            Console.WriteLine(Convert.ToString(final));






        }

    }
}

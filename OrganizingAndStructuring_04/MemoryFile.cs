using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingAndStructuring_04
{
    public class MemoryFile
    {
        public byte[] Bytes { get; }

        public MemoryFile(string path)
        {
            Bytes = File.ReadAllBytes(path);

            // validation / error checking code omitted
        }

        public void SetFirstByte(byte b)
        {
            Bytes[0] = b;
        }
        //public byte this[int i]
        //{
        //    get { return Bytes[i]; }
        //    set { Bytes[i]=value; }
        //}
        public byte this[int i]
        {
            get => Bytes[i];
            set => Bytes[i] = value;
        }
            
    }
}

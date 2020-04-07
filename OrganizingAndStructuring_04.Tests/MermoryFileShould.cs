using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrganizingAndStructuring_04.Tests
{
    public class MemoryFileShould
    {
        [Fact]
        public void ReadFile()
        {
            MemoryFile file = new MemoryFile("testfile.txt");

            Assert.Equal(13, file.Bytes.Length);
        }


        [Fact]
        public void SetBytes()
        {
            MemoryFile file = new MemoryFile("testfile.txt");

            file.SetFirstByte(42);

            Assert.Equal(42, file.Bytes[0]);
        }
        [Fact]
        public void ProvideIndexer()
        {
            MemoryFile file = new MemoryFile("testfile.txt");

            file[0] = 42;

            Assert.Equal(42, file[0]);
        }

    }
}

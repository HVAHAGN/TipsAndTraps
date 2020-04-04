using DataObjectTypesClassLib_03.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataObjectTypes_03
{
   public class AdvancedStringProcessorV2Should
    {

        private AdvancedStringProcessorV2 sut = null;
        private List<string> inputStrings;

        public AdvancedStringProcessorV2Should()
        {
            sut = new AdvancedStringProcessorV2();
            inputStrings = new List<string> { "Hello", "Welcome", "Howdy" };
        }

        [Fact]
        public void ProcessNone()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV2.None);

            Assert.Equals(3, results.Count);

            Assert.Equals("Hello", results[0]);
            Assert.Equals("Welcome", results[1]);
            Assert.Equals("Howdy", results[2]);
        }

        [Fact]
        public void ProcessAddLength()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV2.AddLength);

            Assert.Equals(3, results.Count);

            Assert.Equals("5-Hello", results[0]);
            Assert.Equals("7-Welcome", results[1]);
            Assert.Equals("5-Howdy", results[2]);
        }

        [Fact]
        public void ProcessConvertToUppercase()
        {
            var results = sut.Process(inputStrings,
                                      StringProcessingOptionsV2.ConvertToUppercase);

            Assert.Equals(3, results.Count);

            Assert.Equals("HELLO", results[0]);
            Assert.Equals("WELCOME", results[1]);
            Assert.Equals("HOWDY", results[2]);
        }
    }
}


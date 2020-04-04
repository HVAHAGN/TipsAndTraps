using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectTypesClassLib_03.Enums
{
    [Flags]
    public enum StringProcessingOptionsV2
    {
        None=0,
        ConvertToUppercase=1,
        AddLength=2,
        All= ConvertToUppercase |AddLength
    }
    public class AdvancedStringProcessorV2
    {
        public List<string> Process(List<string> stringToProcess, StringProcessingOptionsV2 options)
        {
            bool noProcessingIsRequired = options == StringProcessingOptionsV2.None;
            bool conversionToUppercaseIsRequired = (options & StringProcessingOptionsV2.ConvertToUppercase)!=0;
            bool addingLengthIsRequired = options.HasFlag(StringProcessingOptionsV2.AddLength);

            var processedStrings = new List<string>();
            foreach (var originalString in stringToProcess)
            {
                string temp = " ";
                if (noProcessingIsRequired)
                {
                    processedStrings.Add(originalString);
                    continue;
                }
                else if (addingLengthIsRequired)
                {
                    temp += $"{originalString.Length}-";
                }
                else
                {
                    temp += originalString;
                }
                processedStrings.Add(temp);
            }

            return processedStrings;
        }
    }
}

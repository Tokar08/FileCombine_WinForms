using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FileCombine.Renamer
{
    internal interface IStringGenerator
    {
        public string GetNext();
    }


    internal class AutoincrementGenerator : IStringGenerator
    {
        public int CurrentValue { get; set; }
        public int Step { get; set; }
        public AutoincrementGenerator(int startValue, int step)
        {
            CurrentValue = startValue;
            Step = step;
        }
        public string GetNext()
        {
            return (CurrentValue += Step).ToString();
        }
    }

    internal class UuidGenerator : IStringGenerator
    {
        public string GetNext()
        {
            return Guid.NewGuid().ToString();
        }
    }

    internal class RandomNameGenerator : IStringGenerator
    {
        public string GetNext()
        {

            return Path.GetRandomFileName();

        }
    }




}

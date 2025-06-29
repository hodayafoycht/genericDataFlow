using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataFlow
{
    public class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null");
            }
            return input.ToUpper();
        }
    }
}

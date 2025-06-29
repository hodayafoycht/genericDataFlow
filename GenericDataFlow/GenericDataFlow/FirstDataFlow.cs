using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataFlow
{
    public class FirstDataFlow<T> : IDataFlow<T>
      where T : class
    {
        public List<IBlock<T>> Blocks;

        public FirstDataFlow()
        {
            Blocks = new List<IBlock<T>>();
        }


        public T RunFlow(T input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null");
            }
            
            T result = input;
            foreach (var block in Blocks)
            {
                result = block.Process(result);
            }

            return result;

        }
        public void AddBlock(IBlock<T> block)
        {
            Blocks.Add(block);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgram
{
    class CollectionInitializer
    {
        static void Main(string[] args)
        {
            var vals = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            int sum = vals.Sum();

            Console.WriteLine(sum);
        }
    }
}

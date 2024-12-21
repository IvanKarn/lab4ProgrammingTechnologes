using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Strategy
{
    internal class PayWithCash : IPayStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine("{0} paid with cash", amount);
        }
    }
}

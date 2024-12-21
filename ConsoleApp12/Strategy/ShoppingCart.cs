using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Strategy
{
    internal class ShoppingCart
    {
        private List<Tuple<string, int>> items;
        public ShoppingCart()
        {
            items = new List<Tuple<string, int>>();
        }
        public void AddItem(Tuple<string, int> item)
        {
            items.Add(item);
        }
        public void Pay(IPayStrategy strategy)
        {
            strategy.Pay((from i in items select i.Item2).Sum());
            items.Clear();
        }
    }
}

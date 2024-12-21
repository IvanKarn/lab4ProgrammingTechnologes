using ConsoleApp12.Iterator;
using ConsoleApp12.ResponsibilityChain;
using ConsoleApp12.Strategy;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new Tuple<string, int>("apple", 10));
            shoppingCart.AddItem(new Tuple<string, int>("apple", 10));
            shoppingCart.Pay(new PayWithCard());
            shoppingCart.AddItem(new Tuple<string, int>("apple", 10));
            shoppingCart.AddItem(new Tuple<string, int>("apple", 10));
            shoppingCart.Pay(new PayWithCash());

            Console.WriteLine();

            IMessageHandler messageHandler = new AdminHandler();
            messageHandler.SetNextHandler(new ModeratorHandler());
            messageHandler.SetNextHandler(new UserHandler());
            messageHandler.HandleMessage(new Message("lorem ipsum", PermissionLevel.Admin));
            messageHandler.HandleMessage(new Message("lorem ipsum", PermissionLevel.Moderator));
            messageHandler.HandleMessage(new Message("lorem ipsum", PermissionLevel.User));

            Console.WriteLine();

            List<Uri> urls = new List<Uri>();
            urls.Add(new Uri("https://google.com"));
            urls.Add(new Uri("https://ya.ru"));
            WebIterator iterator = new WebIterator(urls);
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}

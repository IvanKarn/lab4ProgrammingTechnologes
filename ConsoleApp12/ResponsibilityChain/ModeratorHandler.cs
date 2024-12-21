using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.ResponsibilityChain
{
    internal class ModeratorHandler : IMessageHandler
    {
        private IMessageHandler? NextHandler;
        public void HandleMessage(Message message)
        {
            if (message.Level == PermissionLevel.Moderator)
            {
                Console.WriteLine("Moderator: {0}", message.Content);
            }
            else
            {
                NextHandler?.HandleMessage(message);
            }
        }

        public void SetNextHandler(IMessageHandler nextHandler)
        {
            if (NextHandler != null)
            {
                NextHandler.SetNextHandler(nextHandler);
            }
            else
            {
                NextHandler = nextHandler;
            }
        }
    }
}

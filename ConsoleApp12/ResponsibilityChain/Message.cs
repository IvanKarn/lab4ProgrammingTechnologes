using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.ResponsibilityChain
{
    internal class Message
    {
        public readonly string Content;
        public readonly PermissionLevel Level;
        public Message(string content, PermissionLevel level)
        {
            Content = content;
            Level = level;
        }
    }
}

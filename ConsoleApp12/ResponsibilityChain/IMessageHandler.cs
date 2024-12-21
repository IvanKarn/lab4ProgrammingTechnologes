﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.ResponsibilityChain
{
    internal interface IMessageHandler
    {
        public void SetNextHandler(IMessageHandler nextHandler);
        public void HandleMessage(Message message);
    }
}

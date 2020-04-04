using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1
{
    public class BaseHandler : IHandler
    {
        public IHandler _nextHandler { get; set; }
        public virtual void Process(Request request)
        {
            
        }

        public virtual void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfWorkDesignPatternConsoleApp1
{
    class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;
        public BaseHandler()
        {

        }
        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public virtual void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}

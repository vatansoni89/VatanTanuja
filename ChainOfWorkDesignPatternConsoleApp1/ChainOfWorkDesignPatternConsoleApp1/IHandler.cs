using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfWorkDesignPatternConsoleApp1
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Process(Request request);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1
{
    public interface IHandler
    {
        void Process(Request request);
        void SetNextHandler(IHandler handler);
    }
}

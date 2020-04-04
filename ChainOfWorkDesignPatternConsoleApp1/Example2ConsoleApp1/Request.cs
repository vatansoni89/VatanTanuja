using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1
{
    public class Request
    {
        public object Data { get; set; }
        public List<string> ValidationMessages { get; set; }

        public Request()
        {
            ValidationMessages = new List<string>();
        }
    }
}

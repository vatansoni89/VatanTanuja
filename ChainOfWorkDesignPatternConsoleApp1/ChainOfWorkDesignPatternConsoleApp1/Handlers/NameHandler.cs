using ChainOfWorkDesignPatternConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfWorkDesignPatternConsoleApp1.Handlers
{
    class NameHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if (person.Name.Length > 5)
                    request.ValidationMessages.Add("Invalid Name");
                if (_nextHandler != null)
                    _nextHandler.Process(request);
            }
        }
    }
}

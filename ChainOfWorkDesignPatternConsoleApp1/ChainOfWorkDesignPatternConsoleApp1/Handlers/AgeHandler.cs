using ChainOfWorkDesignPatternConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfWorkDesignPatternConsoleApp1.Handlers
{
    class AgeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.Age > 5)
                    request.ValidationMessages.Add("Invalid Age");
                if (_nextHandler != null)
                    _nextHandler.Process(request);
            }
        }
    }
}

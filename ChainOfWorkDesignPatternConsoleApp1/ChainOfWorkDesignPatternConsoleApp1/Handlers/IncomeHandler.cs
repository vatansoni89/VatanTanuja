using ChainOfWorkDesignPatternConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfWorkDesignPatternConsoleApp1.Handlers
{
    class IncomeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.Income > 100)
                    request.ValidationMessages.Add("Invalid Income");
                if (_nextHandler != null)
                    _nextHandler.Process(request);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility_First_Look.Business.Handlers
{
    public interface IHandler<T> where T:class
    {
        Handler<T> SetNext(Handler<T> handler);
        void Handle(T request);
    }

    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private Handler<T> Next { get;set;}

        public virtual void Handle(T request)
        {
           Next?.Handle(request);
        }

        public Handler<T> SetNext(Handler<T> next)
        {
           Next = next;
           return Next;
        }
    }
}

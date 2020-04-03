using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            var jc_del = JobChanged as EventHandler<JobChangedEventArgs>;

            if (jc_del!=null)
            {
                jc_del(sender, new JobChangedEventArgs{ Job = job});
            }
        }
    }
}

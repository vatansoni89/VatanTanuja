using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public delegate void AnnouncementHandler(string msz);

    class Bank
    { 
        public event AnnouncementHandler AnnouncementHappened;

        public void OnAnnouncement(string msz1)
        { 
            AnnouncementHandler del = AnnouncementHappened as AnnouncementHandler;
            if (del !=null)
            {
                del(msz1);
            }
        }
    }

    /// <summary>
    /// Events using EventHandler delegate.
    /// </summary>
    public class Nation
    { 
        public event EventHandler<NationInfoEventArgs> NationSpoke;

        public void OnNationSpoke(string nation, int pop)
        { 
            EventHandler<NationInfoEventArgs> del = NationSpoke as EventHandler<NationInfoEventArgs>;
            if (del!=null)
            {
                del(this, new NationInfoEventArgs(){ Name = nation,Population=pop});
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AnnouncementHappened += Bank_AnnouncementHappenedIndia;
            bank.OnAnnouncement("India");

            Nation nation = new Nation();
            nation.NationSpoke += Nation_NationSpoke;
            nation.OnNationSpoke("USA",999);
        }

        private static void Nation_NationSpoke(object sender, NationInfoEventArgs e)
        {
            Console.WriteLine(e.Name+" is great nation. Its population is "+e.Population);
        }

        private static void Bank_AnnouncementHappenedIndia(string msz)
        {
            Console.WriteLine("Hello from bank of "+msz);
        }
    }
}

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
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AnnouncementHappened += Bank_AnnouncementHappenedIndia;
            bank.OnAnnouncement("India");
        }

        private static void Bank_AnnouncementHappenedIndia(string msz)
        {
            Console.WriteLine("Hello from bank of "+msz);
        }
    }
}

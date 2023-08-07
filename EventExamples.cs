using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate void Message(int num);
    public class EventExamples
    {
        public event Message Event;

        public void CallEvent(int num)
        {
            if(Event != null)
            {
                Event(num);
            }
        }
        public static void EventHandler(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Event Started");
            }
            else Console.WriteLine("Event has not started");
        }
    }
}

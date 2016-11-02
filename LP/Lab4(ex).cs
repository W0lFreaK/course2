using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class IndexOutOfRangeException : Exception
    {
        public delegate void MyEventHandler();
        public event MyEventHandler ioor;
        private string message;
        void except()
        {
            throw new IndexOutOfRangeException();
        }
        public override string Message
        {
            get
            {
                ioor();
                return message;
            }
        }
        public IndexOutOfRangeException()
        {
            message = "Выход за пределы";
            ioor += new MyEventHandler(Events.messageEx);
        }
        public IndexOutOfRangeException(String txt)
        {
            message = txt;
            ioor += new MyEventHandler(Events.messageEx);
        }
    }
}

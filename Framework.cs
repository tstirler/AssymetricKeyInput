using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Framework
    {
        Keyboard _keyboard;
        private bool _running;
        private static string _enteredLine;
        public bool Running { get { return _running; } }

        public Framework()
        {
            this._keyboard = new Keyboard();
            this._running = true;
            _enteredLine = "";
        }

        public void Update()
        {
            _keyboard.Update();
            if (!_enteredLine.Equals(""))
            {
                Console.Write("\r\nEntered line was: {0}", _enteredLine);
                _enteredLine = "";
            }
        }

        public static void EnterLine(string LineToEnter)
        {
            _enteredLine = LineToEnter;
        }
    }
}

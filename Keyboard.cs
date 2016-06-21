using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Keyboard
    {
        private ConsoleKeyInfo key;
        private string returnString;

        public Keyboard()
        {
        }
               
        public void Update()
        {
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true);
                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    Framework.EnterLine(returnString + "\r\n");
                    returnString = "";
                    
                } else if (key.Key.Equals(ConsoleKey.D0) || key.Key.Equals(ConsoleKey.D1) || key.Key.Equals(ConsoleKey.D2) ||
                    key.Key.Equals(ConsoleKey.D3) || key.Key.Equals(ConsoleKey.D4) || key.Key.Equals(ConsoleKey.D5) ||
                    key.Key.Equals(ConsoleKey.D6) || key.Key.Equals(ConsoleKey.D7) || key.Key.Equals(ConsoleKey.D8) ||
                    key.Key.Equals(ConsoleKey.D9))
                {
                    #region NumbersAndSymbols
                    switch (key.Key)
                    {
                        case ConsoleKey.D0:
                            Console.Write("0");
                            returnString = returnString + "0";
                            break;
                        case ConsoleKey.D1:
                            Console.Write("0");
                            returnString = returnString + "1";
                            break;
                        case ConsoleKey.D2:
                            Console.Write("2");
                            returnString = returnString + "2";
                            break;
                        case ConsoleKey.D3:
                            Console.Write("3");
                            returnString = returnString + "3";
                            break;
                        case ConsoleKey.D4:
                            Console.Write("4");
                            returnString = returnString + "4";
                            break;
                        case ConsoleKey.D5:
                            Console.Write("5");
                            returnString = returnString + "5";
                            break;
                        case ConsoleKey.D6:
                            Console.Write("6");
                            returnString = returnString + "6";
                            break;
                        case ConsoleKey.D7:
                            Console.Write("7");
                            returnString = returnString + "7";
                            break;
                        case ConsoleKey.D8:
                            Console.Write("8");
                            returnString = returnString + "8";
                            break;
                        case ConsoleKey.D9:
                            Console.Write("9");
                            returnString = returnString + "9";
                            break;
                        default:
                            break;
                    }
                    #endregion
                }
                else if(key.Key.Equals(ConsoleKey.A) || key.Key.Equals(ConsoleKey.B) || key.Key.Equals(ConsoleKey.C) || 
                    key.Key.Equals(ConsoleKey.D) || key.Key.Equals(ConsoleKey.E) || key.Key.Equals(ConsoleKey.F) || 
                    key.Key.Equals(ConsoleKey.G) || key.Key.Equals(ConsoleKey.H) || key.Key.Equals(ConsoleKey.I) || 
                    key.Key.Equals(ConsoleKey.J) || key.Key.Equals(ConsoleKey.K) || key.Key.Equals(ConsoleKey.L) || 
                    key.Key.Equals(ConsoleKey.M) || key.Key.Equals(ConsoleKey.N) || key.Key.Equals(ConsoleKey.O) || 
                    key.Key.Equals(ConsoleKey.P) || key.Key.Equals(ConsoleKey.Q) || key.Key.Equals(ConsoleKey.R) || 
                    key.Key.Equals(ConsoleKey.S) || key.Key.Equals(ConsoleKey.T) || key.Key.Equals(ConsoleKey.U) || 
                    key.Key.Equals(ConsoleKey.V) || key.Key.Equals(ConsoleKey.W) || key.Key.Equals(ConsoleKey.X) || 
                    key.Key.Equals(ConsoleKey.Y) || key.Key.Equals(ConsoleKey.Z))
                {
                    Console.Write(key.Key);
                    returnString = returnString + key.Key;
                }
            }
        }
    }
}

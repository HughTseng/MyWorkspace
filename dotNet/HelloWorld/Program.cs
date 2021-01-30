using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string _whosvisited = string.Empty;
            ConsoleColor _curBackgroundColor;
            ConsoleColor _curForegroundColor;
            try
            {
                if (args != null && args.Length > 0)
                {
                    _whosvisited = args[0];

                    if (_whosvisited.ToUpper() == "RunError".ToUpper())
                    {
                        throw new Exception("Test ERROR has Happened!!");
                    }
                    else
                    {
                        Console.Write("Hello! ");
                        _curBackgroundColor = Console.BackgroundColor;
                        _curForegroundColor = Console.ForegroundColor;

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($@"{_whosvisited}!!");
                        Console.BackgroundColor = _curBackgroundColor;
                        Console.ForegroundColor = _curForegroundColor;
                    }
                }
                else
                {
                    Console.Write("Hello! World!!");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"[Exception] {ex.ToString()}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }
    }
}

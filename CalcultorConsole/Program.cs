using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcultorConsole
{
    class Program
    {
        public void CheckEnter()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You entered an invalid value!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Sleep()
        {
            System.Threading.Thread.Sleep(2000);
        }

        public double InputInSum(double x, double y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum of {x} and {y} is {x+y}");
            Console.ForegroundColor = ConsoleColor.White;
            return x + y;
        }

        public double InputInMin(double x, double y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The Difference between {x} and {y} is {x - y}");
            Console.ForegroundColor = ConsoleColor.White;
            return x - y;
        }

        public double InputInSub(double x, double y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum multiplication  {x} and {y} is {x * y}");
            Console.ForegroundColor = ConsoleColor.White;
            return x * y;
        }

        public double InputInDiv(double x, double y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The Division  of {x} and {y} is {x / y}");
            Console.ForegroundColor = ConsoleColor.White;
            return x / y;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string headBig = @" 

.----------------. .----------------. .----------------. .----------------. 
| .--------------. | .--------------. | .--------------. | .--------------. |
| |      _       | | |              | | |      _       | | |        __    | |
| |     | |      | | |              | | |   /\| |/\    | | |       / /    | |
| |  ___| |___   | | |    ______    | | |   \     /    | | |      / /     | |
| | |___   ___|  | | |   |______|   | | |  |_     _|   | | |     / /      | |
| |     | |      | | |              | | |   /     \    | | |    / /       | |
| |     |_|      | | |              | | |   \/|_|\/    | | |   /_/        | |
| |              | | |              | | |              | | |              | |
| '--------------' | '--------------' | '--------------' | '--------------' |
 '----------------' '----------------' '----------------' '----------------' ";

                double firstValue, secondValue;
                bool logic = false;
                bool logicSec = false;
                bool action = false;
                string logAction;

                Console.ForegroundColor = ConsoleColor.White;

                Program hook = new Program();

                while (logic == false)
                {
                    Console.Clear();
                    try
                    {
                        Console.Write("Enter the first variable: ");
                        firstValue = double.Parse(Console.ReadLine());
                        logic = true;
                        while (logicSec == false)
                        {
                            try
                            {
                                Console.Write("Enter the second variable: ");
                                secondValue = double.Parse(Console.ReadLine());
                                logicSec = true;
                                while (action == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine(headBig);
                                    Console.WriteLine("Chosee the action: '+', '-', '*' ,'/'");

                                    logAction = Convert.ToString(Console.ReadLine());

                                    if (logAction == "+")
                                    {
                                        action = true;
                                        hook.InputInSum(firstValue, secondValue);
                                        hook.Sleep();

                                    }
                                    else if (logAction == "-")
                                    {
                                        action = true;
                                        hook.InputInMin(firstValue, secondValue);
                                        hook.Sleep();

                                    }
                                    else if (logAction == "*")
                                    {
                                        action = true;
                                        hook.InputInSub(firstValue, secondValue);
                                        hook.Sleep();

                                    }
                                    else if (logAction == "/")
                                    {
                                        action = true;
                                        hook.InputInDiv(firstValue, secondValue);
                                        hook.Sleep();

                                    }
                                    else
                                    {
                                        Program program = new Program();
                                        program.CheckEnter();
                                        program.Sleep();
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                hook.CheckEnter();
                                hook.Sleep();
                                Console.Clear();
                                Console.WriteLine($"First variable: {firstValue}");
                            }
                        }
                    }
                    catch (FormatException)
                    {

                        hook.CheckEnter();
                        hook.Sleep();
                    }
                }
            }            
        }
    }
}
            


        
    


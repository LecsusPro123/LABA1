using System;
using System.Collections.Generic;

namespace Практика
{
    class Program
    {
        public static bool TurnOn = true;
        public static List<Person> Notebook = new List<Person>();
        static void Main(string[] args)
        {
            Methods.ClearScr();

            while (TurnOn)
            {
                switch (Console.ReadLine())
                {
                    case "AddNew":
                        {
                            Methods.AddNew();
                        }
                        break;

                    case "Delete":
                        {
                            Methods.Delete();
                        }
                        break;

                    case "Edit":
                        {
                            Methods.Edit();
                        }
                        break;

                    case "Show":
                        {
                            Methods.Show();
                        }
                        break;

                    case "ShowAll":
                        {
                            Methods.ShowAll();
                        }
                        break;

                    case "Exit":
                        {
                            Console.WriteLine("Пока пока...");
                            TurnOn = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Такой команды нет попробуй еще раз...");
                        break;
                }
            }
        }
    }
}

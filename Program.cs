using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            Console.WriteLine("Enter Country Code");
            cCode = Console.ReadLine();
            switch(cCode)
            {
                case "uk":
                    {
                        lang = "English";
                            break;
                    }
                case "af":
                    {
                        lang = "Dari,Pashto";
                        break;
                    }
                case "in":
                    {
                        lang = "Hindi,English.Tamil.Telugu,Punjab";
                        break;
                    }
                case "uae":
                    {
                        lang = "Arabic";
                        break;
                    }
                default:

                    {
                        Console.WriteLine($"Sorry!! Your country {cCode}is not in ourDb");
                        lang = "Not Found!!!";
                        break;
                    }
            }
            Console.WriteLine("Country code " + cCode + "Language(s)" + lang);
            Console.WriteLine("Do you wanna continue ")
            Console.ReadKey();
        }
    }
}

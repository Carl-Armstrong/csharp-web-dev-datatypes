
using System;
using System.Text;

namespace HelloGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Allows unicode output
            string langCode = "en"; // English is default

            Console.WriteLine("What is your name?");        // Prompt for name
            string name = Console.ReadLine();               // Get name
            if (name.Length <=0) { name = "world"; }        // If no name given, name will be "world"

            Console.WriteLine("What is your prefered language?");
            Console.WriteLine("1=French, 2=English, 3=Spanish, 4=Russian, 5=Ukrainian");
            int language = int.Parse(Console.ReadLine());
            
            switch(language)
            {
                case 1:
                    langCode = "fr";
                    break;
                case 2:
                    break; // already English
                case 3:
                    langCode = "sp";
                    break;
                case 4:
                    langCode = "ru";
                    break;
                case 5:
                    langCode = "ua";
                    break;
                default:
                    break;
            }

            string message = Message.GetMessage(langCode, name);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
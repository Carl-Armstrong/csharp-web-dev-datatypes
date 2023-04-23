﻿namespace HelloMethods
{
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("ru"))
            {
                return "Privyet Mir";
            }
            else if (lang.Equals("ua"))
                return "Priveet Sveet";
            else
            {
                return "Hello World";
            }
        }
    }
}

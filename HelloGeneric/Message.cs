namespace HelloGeneric
{
    public class Message
    {
        public static string GetMessage(string lang, string name)
        {
            if (lang.Equals("sp"))
            {
                return "Hola " + name;
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour " + name;
            }
            else if (lang.Equals("ru"))
            {
                return "Привет " + name;
            }
            else if (lang.Equals("ua"))
                return "Привіт " + name;
            else
            {
                return "Hello World";
            }
        }
    }
}

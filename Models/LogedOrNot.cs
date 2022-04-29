namespace Banco_Toyko.Models
{
    public static class LogedOrNot
    {
        private static bool log = false;

        public static bool Get()
        {
            return log;
        }
        public static void Set(bool set)
        {
            log = set;
        }
    }
}

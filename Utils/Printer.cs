using System;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void WriteLine (int length = 10)
        {
            Console.WriteLine( new string('=', length));
        }
    }

}
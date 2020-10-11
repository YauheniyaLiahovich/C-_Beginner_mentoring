using System;

namespace HelloWorldCore
{
    /// <summary>
    /// HelloWorld
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            //add text to console
            //TODO refactor me
            Console.WriteLine("Hello World!");

            var todayDate = GetTodayDate();
            Console.WriteLine(todayDate);
        }

        public static DateTime GetTodayDate()
        {
            return DateTime.Now;
        }
    }
}

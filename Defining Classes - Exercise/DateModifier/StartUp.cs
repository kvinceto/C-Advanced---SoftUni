using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateTime statDateTime = DateTime.Parse(Console.ReadLine());
            DateTime endDateTime = DateTime.Parse(Console.ReadLine());
            if (statDateTime > endDateTime)
            {
                (statDateTime, endDateTime) = (endDateTime, statDateTime);
            }
            DateModifier d = new DateModifier(statDateTime, endDateTime);
            Console.WriteLine(d.Time);
        }
    }
}

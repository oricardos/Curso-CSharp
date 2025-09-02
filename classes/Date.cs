using System;

namespace CursoCSharp
{
    class Date
    {
        public static void Aula()
        {
            DateTime d = new DateTime(2025, 8, 30, 15, 26, 05);
            DateTime d1 = DateTime.Now;

            DateTime treeDays = d1.AddDays(3);
            TimeSpan difference = d.Subtract(d1);

            System.Console.WriteLine(d.ToLongDateString());
            System.Console.WriteLine(treeDays);
            System.Console.WriteLine(difference);

            System.Console.WriteLine("-------");

            TimeSpan t = TimeSpan.MaxValue;
            TimeSpan t1 = TimeSpan.MinValue;
            TimeSpan t0 = TimeSpan.Zero;

            TimeSpan t2 = new TimeSpan(1, 10, 15);

            System.Console.WriteLine("-------");


            DateTime d2 = new DateTime(2025, 8, 30, 15, 53, 00, DateTimeKind.Local);
            DateTime d3 = new DateTime(2025, 8, 30, 15, 53, 00, DateTimeKind.Utc);
            DateTime d4 = new DateTime(2025, 8, 30, 15, 53, 00);

            System.Console.WriteLine($"d2: {d2}");
            System.Console.WriteLine($"d2 Kind: {d2.Kind}");
            System.Console.WriteLine($"d2 to local: {d2.ToLocalTime()}");
            System.Console.WriteLine($"d2 to utc: {d2.ToUniversalTime()}");
        }
    }
}
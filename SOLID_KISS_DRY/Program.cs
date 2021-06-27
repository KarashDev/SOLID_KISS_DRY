using System;

namespace SOLID_KISS_DRY
{
    //Single-responsibility principle /Принцип единственной ответственности
    class Program
    {
        //ПЛОХО
        class TempTime
        {
            public double Temperature { get; set; }
            public DateTime Time  { get; set; }
        }

        //ХОРОШО
        class Temp
        {
            public double Temperature { get; set; }
        }
        
        class Time
        {
            public DateTime Time { get; set; }
        }

        class TempTime
        {
            public Temp Temperature { get; set; }
            public Time Time { get; set; }
        }

        static void Main(string[] args)
        {
        
        }
    }
}

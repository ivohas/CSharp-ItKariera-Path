using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Convert_Speed_Units
    {
        static void Main(string[] args)
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            uint hours = uint.Parse(Console.ReadLine());
            uint minutes = uint.Parse(Console.ReadLine());
            uint seconds = uint.Parse(Console.ReadLine());
            uint InSeconds = (hours * 60 + minutes) * 60 + seconds;
            float inHours = ((float)seconds / 60 + minutes) / 60 + hours;
            float inMiles = (float)distanceInMeters / 1609;
            float Inkilometers = (float)distanceInMeters / 1000;
            float speedMetersPerSecond = (float)distanceInMeters / InSeconds;
            float speedKilometersPerHour = Inkilometers / inHours;
            float speedMilesPerHour = inMiles / inHours;
            Console.WriteLine(speedMetersPerSecond);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
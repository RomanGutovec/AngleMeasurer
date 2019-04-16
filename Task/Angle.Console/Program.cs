using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;

            Measurer angle = new Measurer();

            System.Console.WriteLine("Input amount of hours:");
            bool successHourParsing = Int32.TryParse(System.Console.ReadLine(), out hours);

            System.Console.WriteLine("Input amount of minutes:");
            bool successMinuteParsing = Int32.TryParse(System.Console.ReadLine(), out minutes);

            if (successHourParsing && successMinuteParsing)
            {
                System.Console.WriteLine($"Angle between arrows:{angle.MeasureAngle(hours, minutes)}");
            }

            System.Console.ReadLine();
        }
    }
}

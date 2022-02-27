using System;
using JsonLogger.TestObjects;
using TrackingLibrary;

namespace JsonLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer("AMD RYZEN", 2020, "RYZEN4", "Nvidia 1050Ti", "ASUS G8790");

            const string path = "C:\\Users\\pocht\\OneDrive\\Documents\\GitHub\\Coherent-Hometasks\\Homework6\\JsonLogger\\bin\\Debug\\net5.0\\Test.json";

            var logger = new Logger(path);
            logger.Track(computer);

            Console.WriteLine($"Terminated successfully. Check the file on - {path}.");
        }
    }
}

using TrackingLibrary.TrackingClasses;

namespace JsonLogger.TestObjects
{
    [TrackingEntity]
    public class Computer
    {
        [TrackingProperty]
        public string Model { get; set; }
        public int Year;
        [TrackingProperty]
        public string CPU;
        [TrackingProperty("Testing attribute name!")]
        public string GPU { get; set; }
        public string Motherboard { get; set; }


        public Computer(string model, int year, string cPU, string gPU, string motherboard)
        {
            Model = model;
            Year = year;
            CPU = cPU;
            GPU = gPU;
            Motherboard = motherboard;
        }
    }
}

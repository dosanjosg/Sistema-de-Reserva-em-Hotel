namespace HotelReservation.Entities 
{
    public class Suite (string suiteType, int size, double valueDaily)
    {
        public string? SuiteType { get; set; } = suiteType;
        public int Size { get; set; } = size;
        public double ValueDaily { get; set; } = valueDaily;
    }
}
using System.Diagnostics.Contracts;

namespace HotelReservation.Entities 
{
    public class Reservation (int reservedDays)
    {
        public List<Person> GuestHotel { get; set; } = [];
        public Suite? Suite { get; set; }
        public int ReservedDays { get; set; } = reservedDays;


        public void GuestHotelRegister(List<Person> guestHotel) 
        {
            if(Suite!.Size >= guestHotel.Count) 
            {
                GuestHotel = guestHotel;
            }
            else 
            {
                try 
                {
                    GuestHotelRegister();
                }
                catch (Exception) 
                {
                    Console.WriteLine("Suite with unavailable capacity! Try again.");
                    System.Environment.Exit(0);
                }
            }
        }

        private void GuestHotelRegister()
        {
            throw new NotImplementedException();
        }

        public void SuiteRegister (Suite suite) 
        {
            Suite = suite;
        }

        public int NumberGuestHotel () 
        {
            return GuestHotel.Count;
        }

        public double CalcValueDaily () 
        {
            double value = ReservedDays * Suite!.ValueDaily;

            if (ReservedDays >= 10) 
            {
                value = value - (value * 0.1);
            }

            return value;
        }
    }
}
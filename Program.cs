using HotelReservation.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        //Essa tela será otimizada! Criada apenas para teste.

        List <Person> guest = [];

        Person p1 = new (name: "Fulano", lastName: "Silva");
        Person p2 = new (name: "Ciclano", lastName: "Ribeiro");

        guest.Add(p1); 
        guest.Add(p2);

        Suite suite = new(suiteType: "Premium", size: 2, valueDaily: 30.0);

        Reservation reservation = new(reservedDays: 5);

        reservation.SuiteRegister(suite);
        reservation.GuestHotelRegister(guest);

        Console.WriteLine($"Guest at the hotel: {reservation.NumberGuestHotel()}");
        Console.WriteLine($"Value daily: {reservation.CalcValueDaily()}");

    }
}
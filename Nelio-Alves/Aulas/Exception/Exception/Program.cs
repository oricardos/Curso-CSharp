using Exception.Entities;
using Exception.Entities.Exception;

try
{
    Console.Write("Room Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());


    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine($"Reservation: {reservation}");

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation");


    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine($"Reserva: {reservation}");
}
catch (DomainException error)
{
    Console.WriteLine($"Erro na reserva: {error.Message}");
}
catch (FormatException e)
{
    Console.WriteLine($"Erro de formatação: {e.Message}");
}


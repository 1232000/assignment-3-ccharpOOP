namespace Program;
public class StandardTicket(string movie, decimal price, string seat) : Ticket(movie, price)
{
    private string SeatNumber { get; } = seat;
    public override string ToString()
    {
        return base.ToString() + $" | Seat: {SeatNumber}";
    }
    // assignment 4-----------------------------------
    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Seat Number: {SeatNumber}");
    }
}
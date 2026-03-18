namespace Program;
public class StandardTicket(string movie, decimal price, string seat) : Ticket(movie, price)
{
    private string SeatNumber { get; } = seat;
    public override string ToString()
    {
        return base.ToString() + $" | Seat: {SeatNumber}";
    }
}
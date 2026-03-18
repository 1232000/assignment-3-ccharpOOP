namespace Program;
public class Cinema
{
    public string CinemaName { get; private set; } = "my cinema"; 
    Projector projector = new Projector();
    
    private Ticket[] _tickets = new Ticket[20];
    
    public bool AddTicket(Ticket? t)
    {
        for(int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = t;
                return true;
            }
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("\n====== All Tickets ======");
        foreach (var ticket in _tickets)
        {
            if (ticket != null)
                Console.WriteLine(ticket);
        }
        
        Console.WriteLine("\n========= Statistics =========");
        Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTickets()}");
        Console.WriteLine($"\nBooking Reference 1: {BookingHelper.GenerateBookingReference()}");
        Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

        int numberOfTickets = 5;
        decimal pricePerTicket = 100;
        decimal discount = BookingHelper.CalcGroupDiscount(numberOfTickets, pricePerTicket);
        Console.WriteLine($"Group Discount ({numberOfTickets} tickets * {pricePerTicket} EGP): {discount} EGP (10% off)");

    }

    public void OpenCinema()
    {
        Console.WriteLine("====== Cinema Opened ======");
        projector.Start();
    }
    
    public void CloseCinema()
    {
        Console.WriteLine("\n====== Cinema Closed ======");
        projector.Stopped();
    }
    
    public Ticket? this[int index]
    {
        get
        {
            if (index < 0 || index >= _tickets.Length)
                return null;
            return _tickets[index];
        }
        set
        {
            if (index < 0 || index >= _tickets.Length)
                return;
            _tickets[index] = value!;
        }
    }

    public Ticket? GetMovie (string movieName)
    {
        foreach (var ticket in _tickets)
        {
            if (ticket.MovieName == movieName)
                return ticket;
        }
        return null;
    }

}
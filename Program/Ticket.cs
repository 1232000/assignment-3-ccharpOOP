namespace Program;

public class Ticket
{
    private string _movieName ;
    protected decimal price;
    private static int _ticketCounter = 0;

    public string MovieName
    {
        get => _movieName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                return;
            _movieName = value;
        }
    }
    public decimal Price 
    {
        get => price;
        set
        {
            if (value <= 0)
                return;
            price = value;
        }
    }
    public int TicketId {get;}
    public decimal PriceAfterTax => price * 1.14m;
    public static int GetTotalTickets() => _ticketCounter;
    public Ticket(string movieName, decimal price)
    {
        _ticketCounter++;
        TicketId = _ticketCounter;
        _movieName = movieName;
        this.price = price;
    }

//assignment 4-----------------------------------
    // overloading
    public void SetPrice(decimal newPrice)
    {
        Price = newPrice;
    }

    public void SetPrice(decimal basePrice, decimal multiplier)
    {
        Price = basePrice * multiplier;
    }

    // overriding
    public virtual void PrintTicket()
    {
        Console.WriteLine($"Ticket id: {TicketId}");
        Console.WriteLine($"Movie Name: {MovieName}");
        Console.WriteLine($"Price: {Price} EGP");
        Console.WriteLine($"Price After Tax: {PriceAfterTax} EGP");
    }

// ToString-----------------------------------
    public override string ToString()
     {
         return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax}";
     }
}
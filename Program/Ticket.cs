namespace Program;

public class Ticket
{
    private string _movieName ;
    protected decimal price;
    private static int _ticketCounter = 0;
// property-----------------------------------
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
// Get Total Tickets Sold-----------------------------------
    public static int GetTotalTickets() => _ticketCounter;
// constructor-----------------------------------
    public Ticket(string movieName, decimal price)
    {
        _ticketCounter++;
        TicketId = _ticketCounter;
        _movieName = movieName;
        this.price = price;
    }
// ToString-----------------------------------
     public override string ToString()
     {
         return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax}";
     }
}
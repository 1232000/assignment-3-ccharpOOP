namespace Program;

public class VIPTicket(string movie, decimal price, bool isLounge) : Ticket(movie, price)
{
    private bool LoungeAccess { get; } = isLounge;
    private readonly decimal _serviceFee = 50;

    public override string ToString()
    {
        return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | ServiceFee: {_serviceFee} EGP";
    }

    // assignment 4-----------------------------------
    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Lounge Access: {(LoungeAccess ? "Yes" : "No")}");
        Console.WriteLine($"Service Fee: {_serviceFee} EGP");
    }
}

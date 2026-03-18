namespace Program;

public class VIPTicket(string movie, decimal price, bool isLounge) : Ticket(movie, price)
{
    private bool LoungeAccess { get; } = isLounge;
    private readonly decimal _serviceFee = 50;

    public override string ToString()
    {
        return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | ServiceFee: {_serviceFee} EGP";
    }
}

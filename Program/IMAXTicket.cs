namespace Program;
public class IMAXTicket : Ticket
{
    private bool Is3D { get; set; } 
    
    public IMAXTicket(string movie, decimal price, bool is3D)
        : base(movie, price)
    {
        Is3D = is3D;
        if (Is3D)
            base.price += 30;
    }
    
    public override string ToString()
    {
        return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
    }
}
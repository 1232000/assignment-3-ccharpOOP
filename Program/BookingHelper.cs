namespace Program;

public static class BookingHelper
{
    private static int _counter = 0;
    
    public static decimal CalcGroupDiscount(int numberOfTickets, decimal pricePerTicket)
    {
        var total = pricePerTicket * numberOfTickets;
        if(numberOfTickets >= 5)
            total *= 0.9m;
        return total;
    }

    public static string GenerateBookingReference()
    {
        _counter++;
        return $"BK-{_counter}";
    }
}
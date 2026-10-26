namespace Program;

class Program
{
    public static void ProcessTicket(Ticket t)
    {
        t.PrintTicket();
    }

    public static void Main()
    {
	    Cinema cinema = new Cinema();
	    cinema.OpenCinema();
	    
	    StandardTicket t1 = new StandardTicket("Inception", 120, "A-5"); 
	    VIPTicket t2 = new VIPTicket("Avengers", 200, true);
	    IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

        t1.SetPrice(100m);
        Console.WriteLine("\nAfter setting the direct price:");
        t1.PrintTicket();

        t1.SetPrice(100m, 1.5m);
        Console.WriteLine("\nAfter setting the price with a multiplier:");
        t1.PrintTicket();


        cinema.AddTicket(t1);
	    cinema.AddTicket(t2);
	    cinema.AddTicket(t3);
	    
	    cinema.PrintAllTickets();

        Console.WriteLine("\n====== Process One Ticket ======");
        ProcessTicket(t2);

        cinema.CloseCinema();
    }
}
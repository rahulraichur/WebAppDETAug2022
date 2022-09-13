using APIDemo.Models;



namespace APIDemo.Services
{
    public class TicketService
    {



        static List<Ticket> Tickets { get; }




        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket { Id = 1,BookedFor = "PlatinumPlus", Price = 5000, Qty = 200 },
                new Ticket { Id = 1,BookedFor = "Platinum", Price = 4000, Qty = 30 },
                new Ticket { Id = 1,BookedFor = "Gold", Price = 3000, Qty = 500 },
                new Ticket { Id = 1,BookedFor = "Silver", Price = 2000, Qty = 50 },
                new Ticket { Id = 1,BookedFor = "General", Price = 800, Qty = 10 },



           };
        }



        public static List<Ticket> GetAll() => Tickets;



        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.Id == id);
            return ticket;
        }



    }
}
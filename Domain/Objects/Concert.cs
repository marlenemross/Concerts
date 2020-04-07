using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Objects
{
    public class Concert
    {
        public int ConcertId { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public List<String> Musicians { get; set; }
        public Decimal TicketPrice { get; set; }
        public int NumberOfTickets { get; set; }
        public int NumberOfTicketsSold { get; set; }
            
    }
}

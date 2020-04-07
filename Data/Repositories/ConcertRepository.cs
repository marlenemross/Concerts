using Domain.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ConcertRepository
    {
        private List<Concert> concerts = new List<Concert>();

        public void CreateConcert(String name, DateTime date, int numberOfTickets, int numberOfTicketsSold, decimal ticketPrice)
        {
            Concert concert = new Concert()
            {
                Name = name,
                Date = date,
                Musicians = new List<String>(),
                NumberOfTickets = numberOfTickets,
                NumberOfTicketsSold = numberOfTicketsSold,
                TicketPrice = ticketPrice
            };
            concerts.Add(concert);
        }

        public Boolean AddMusician(String concertName, String musicianName)
        {
            Concert concert = GetConcert(concertName);
            if (concert != null)
            {
                concert.Musicians.Add(musicianName);
                return true;
            }
            else return false;


        }

        public Concert GetConcert(String name)
        {
            int i = 0;
            while (i < concerts.Count || concerts[i].Name != name)
            {
                i++;
            };
            if (i == concerts.Count)
                return null;
            else
                return concerts[i];
            
        }

        public List<Concert> GetAllConcerts()
        {
            return concerts;
        }


    }
}

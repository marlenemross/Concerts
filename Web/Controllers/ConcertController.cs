using Data.Repositories;
using Domain.Objects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ConcertController
    {
        public ConcertRepository concertRepository = new ConcertRepository();

        [HttpPut("create-concert")]
        public String CreateConcert([FromBody] String name, DateTime date, int nrOfTickets, int nrOfTicketsSold, decimal ticketPrice)
        {
            concertRepository.CreateConcert(name, date, nrOfTickets, nrOfTicketsSold, ticketPrice);
                return (name + " added");
        }

        [HttpGet("concert")]
        public Concert GetConcert([FromBody] String name)
        {
            Concert concert = concertRepository.GetConcert(name);
            return concert;
        }

        [HttpGet("all-concerts")]
        public IEnumerable<Concert> GetConcerts()
        {
            return concertRepository.GetAllConcerts();
        }

        [HttpPut("add-musician")]
        public String AddMusicianToConcert([FromBody] String concertName, String musicianName)
        {
            if (concertRepository.AddMusician(concertName, musicianName) == true)
                return "Musician added";
            else return "Concert not found";
        }
    }
}

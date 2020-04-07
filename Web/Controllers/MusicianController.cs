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

    public class MusicianController
    {
        public MusicianRepository musicianRepository = new MusicianRepository();

        [HttpGet("all-musicians")]
        public IEnumerable<Musician> GetAllMusicians()
        {
            return musicianRepository.GetAllMusicians();
            
        }

        [HttpGet("musician")]
        public Musician GetMusician([FromBody] String name)
        {
            return musicianRepository.GetMusician(name);
        }

        [HttpPost("create-musician")]
        public String CreateMusician([FromBody] String firstName, String lastName, String instrument, decimal fee)
        {
            String name = firstName + ' ' + lastName;
            musicianRepository.CreateMusician(name, instrument, fee);
            return (name + " added"); 
        }





    }
}

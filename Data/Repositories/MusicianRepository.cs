using Domain.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class MusicianRepository
    {
        private List<Musician> musicians = new List<Musician>();
        public void CreateMusician(String name, String instrument, Decimal fee)
        {
            Musician musician = new Musician()
            {
                Name = name,
                Instrument = instrument,
                Fee = fee
            };
            musicians.Add(musician);

        }
        
        public List<Musician> GetAllMusicians()
        {
            return musicians;
        }
        
        public Musician GetMusician(String name)
        {
            int i = 0;
            while (i < musicians.Count || musicians[i].Name != name)
            { i++; }
            if (i == musicians.Count)
                return null;
            else
                return musicians[i];

        }

    }
}

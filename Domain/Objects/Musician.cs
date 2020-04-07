using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Objects
{
    public class Musician
    {
        public int MusicianId { get; set; }
        public String Name { get; set; }
        public String Instrument { get; set; }
        public Decimal Fee { get; set; }
    }
}

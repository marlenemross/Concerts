using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Objects
{
    class ConcertMusician
    {
        public int ConcertMusicianId { get; set; }
        public int ConcertId { get; set; }
        public int MusicianId { get; set; }
    }
}

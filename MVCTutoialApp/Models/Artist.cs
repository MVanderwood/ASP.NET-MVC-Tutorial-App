using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutoialApp.Models
{
    public class Artist
    {
        //properties
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }

    }
}
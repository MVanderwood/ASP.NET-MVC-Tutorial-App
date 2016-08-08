using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutoialApp.Models
{
    public class Album
    {
        //properties
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<Review> Review { get; set; }
    }
}
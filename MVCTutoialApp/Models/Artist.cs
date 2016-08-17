using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutoialApp.Models
{
	public class Artist
	{
        public int ArtistID { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Bio { get; set; }

        public virtual List<Album> Albums { get; set; }

        public decimal GetTotalSales()
        {
            decimal total = 0;
            foreach(Album album in Albums)
            {
                total += album.Sales;
            }
            return total;
        }

        public int GetTotalAlbumsSold()
        {
            int total = 0;
            foreach(Album album in Albums)
            {
                total += album.AmountSold;
            }
            return total;
        }
    }
}
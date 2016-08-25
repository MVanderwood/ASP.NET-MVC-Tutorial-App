using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCTutoialApp.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required()]
        public string Title { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual List<Review> Reviews { get; set; }

        public int AmountSold { get; set; }

        [DataType(DataType.Currency)]
        public decimal Sales { get; set; }

        public string Status()
        {
            if (AmountSold >= 500000 && AmountSold < 1000000)
            {
                return "Gold Status";
            }
            else if (AmountSold >= 1000000 && AmountSold < 2000000)
            {
                return "Platinum Status";
            }
            else if (AmountSold >= 2000000)
            {
                return "Double Platinum Status";
            }
            else
            {
                return "";
            }
        }
    }
}
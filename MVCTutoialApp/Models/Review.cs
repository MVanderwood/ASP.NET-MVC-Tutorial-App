using System.ComponentModel.DataAnnotations;

namespace MVCTutoialApp.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Required()]
        public string Content { get; set; }

        public int Rating { get; set; }

        [Required()]
        public int AlbumID { get; set; }

        [Required()]
        public virtual Album Album { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string ReviewerEmail { get; set; }

        public Artist Artist()
        {
            return Album.Artist;
        }
    }
}
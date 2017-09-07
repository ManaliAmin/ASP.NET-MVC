using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assign9.Controllers
{
    public class ArtistAddForm : ArtistAdd 
    {
        
        public SelectList GenreList { get; set; }
    }

    public class ArtistAdd
    {
        
        [Required, StringLength(100)]
        [Display(Name = "Artist name or stage name")]
        public string Name { get; set; }

        [StringLength(100)]
        [Display(Name = "If applicable, artist's birth name")]
        public string BirthName { get; set; }

        [Required]
        [Display(Name = "Birth date, or start date")]
        [DataType(DataType.Date)]
        public DateTime BirthOrStartDate { get; set; }

        [Required, StringLength(200)]
        [Display(Name = "Artist photo")]
        
        public string UrlArtist { get; set; }
        public int GenreId { get; set; }
        [Required]
        [Display(Name = "Artist's primary genre")]
        public string Genre { get; set; }
        public string Executive { get; set; }
        //[Display(Name = "Artist's primary genre")]
        //public SelectList GenreList { get; set; }
        [DataType(DataType.MultilineText)]
        public string Portrayal { get; set; }
        public int AlbumsCount { get; set; }

        public SelectList GenreList { get; set; }

    }

    public class ArtistBase : ArtistAdd
    {
        public int Id { get; set; }
    }

    public class ArtistWithDetails : ArtistBase
    {
      public ArtistWithDetails()
        {
            MediaItems = new List<MediaItemBase>();
        }
        public IEnumerable<MediaItemBase> MediaItems { get; set; }
        [Display(Name = "Number of albums")]
        public int AlbumsCount { get; set; }
        //public IEnumerable<MediaItemBase> MediaItems { get; set; }
    }
  
}

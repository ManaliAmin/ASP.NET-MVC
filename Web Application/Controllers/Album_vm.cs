using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assign9.Controllers
{


    public class AlbumBase : AlbumAdd
    {
        public int Id { get; set; }
    }

    public class AlbumAdd
    {
        public AlbumAdd()
        {
            ReleaseDate = DateTime.Now;
        }

        [Display(Name = "Coordinator who looks after the album")]
        public string Coordinator { get; set; }

        [Display(Name = "Album's primary genre")]
        public string Genre { get; set; }

        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Album name")]
        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Album image (cover art)")]
        public string UrlAlbum { get; set; }

        [DataType(DataType.MultilineText)]
        public string Depiction { get; set; }

        public IEnumerable<int> TrackIds { get; set; }

        public IEnumerable<int> ArtistIds { get; set; }
    }

    public class AlbumAddForm : AlbumAdd
    {
        public string ArtistName { get; set; }

        public SelectList GenreList { get; set; }

        public MultiSelectList TrackList { get; set; }

        public MultiSelectList ArtistList { get; set; }
    }

    public class AlbumWithDetail : AlbumBase
    {
        public AlbumWithDetail()
        {
           // Tracks = new List<TrackBase>();
            Artists = new List<ArtistBase>();
        }

        public IEnumerable<String> ArtistNames { get; set; }

        public IEnumerable<ArtistBase> Artists { get; set; }

       // public IEnumerable<TrackBase> Tracks { get; set; }
    }

}
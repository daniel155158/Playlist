using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Playlist.Models
{
    public class Album
    {
        public int ID { get; set; }

        [Display(Name = "專輯名稱")]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int SingerID { get; set; }

        // one album has many songs
        public virtual ICollection<Song> Songs { get; set; }
        // one album belongs to one singer
        public virtual Singer Singer { get; set; }
    }
}
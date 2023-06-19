using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Playlist.Models
{
    public class Singer
    {
        public int ID { get; set; }

        [Display(Name = "歌手")]
        public string Name { get; set; }

        // one singer has many albums
        public virtual ICollection<Album> Albums { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Playlist.Models
{
    public class Singer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // one singer has many albums
        public virtual ICollection<Album> Albums { get; set; }
    }
}
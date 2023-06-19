using System;
using System.Collections.Generic;

namespace Playlist.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        // one album has many songs
        public virtual ICollection<Song> Songs { get; set; }
    }
}
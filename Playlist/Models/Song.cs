using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Playlist.Models
{
    public class Song
    {
        public int ID { get; set; }

        [Display(Name = "歌曲名稱")]
        public string Title { get; set; }
        public int AlbumID { get; set; }

        // one song belongs to one album
        public virtual Album Album { get; set; }
    }
}
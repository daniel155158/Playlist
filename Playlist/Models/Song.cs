namespace Playlist.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int SingerID { get; set; }
        public int AlbumID { get; set; }

        // one song belongs to one singer
        public virtual Singer Singer { get; set; }
        // one song belongs to one album
        public virtual Album Album { get; set; }
    }
}
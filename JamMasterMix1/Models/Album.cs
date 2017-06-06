using System;
namespace JamMasterMax1.Models
{
    public class Album
    {
        public Guid AlbumID
        {
            get; set;
        }

        public string AlbumName
        {
            get; set;
        }

        public Guid ArtistID
        {
            get; set;
        }

        public Guid AlbumGenreID
        {
            get; set;
        }

        public DateTime AlbumReleaseDate
        {
            get; set;
        }

        public Album()
        {
        }
    }
}

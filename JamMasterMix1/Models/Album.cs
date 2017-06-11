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

        public Guid AlbumArtistID
        {
            get; set;
        }

  //      public DateTime AlbumReleaseDate
  //      {
  //          get; set;
  //      }

		//public Guid AlbumGenreID
		//{
		//	get; set;
		//}

        public Album()
        {
        }
    }
}
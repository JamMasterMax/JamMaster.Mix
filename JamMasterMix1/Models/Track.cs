using System;
namespace JamMasterMax1.Models
{
    public class Track
    {
        public Guid TrackID
        {
            get; set;
        }

        public string TrackName
        {
            get; set;
        }

        public Guid TrackArtistID
        {
            get; set;
        }

        public Guid TrackAlbumID
        {
            get; set;
        }

		//public Guid TrackFeature1ArtistID
		//{
		//	get; set;
		//}

		//public Guid TrackFeature2ArtistID
		//{
		//	get; set;
		//}

		//public Guid TrackFeature3ArtistID
		//{
		//	get; set;
		//}

		public Track()
        {
        }
    }
}

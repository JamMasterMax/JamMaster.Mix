using System;
namespace JamMasterMax1.Models
{
    public class MixTrack
    {
        public Guid MixTrackID
        {
            get; set;
        }

        public Guid MixID
        {
            get; set;
        }

        public Guid TrackID
        {
            get; set;
        }

        public int MixTrackLikeTally
        {
            get; set;
        }

        public MixTrack()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using JamMasterMax1.Models;
using System.IO;

namespace JamMasterMax1.App_Data
{
    public class TrackManager
    {
        public static List<Track> GetTracks()
        {
            List<Track> tracks = new List<Track>();

            //string repositoryDirectory = System.Configuration.AppSettingsReader.AppSettings["PFUserName"];
            IEnumerable<string> trackRepo = File.ReadLines("/Users/jmmax/Projects/JMM_Repositories/TrackRepository_1704.csv");
            foreach(string trackLine in trackRepo){
                string[] trackData = trackLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Track track = new Track();
                track.TrackID = Guid.Parse(trackData[0]);
                track.TrackName = trackData[1];
                track.TrackArtistID = Guid.Parse(trackData[2]);
                track.TrackAlbumID = Guid.Parse(trackData[3]);

                tracks.Add(track);
            }


            return tracks;
        }

        public TrackManager()
        {
        }
    }
}
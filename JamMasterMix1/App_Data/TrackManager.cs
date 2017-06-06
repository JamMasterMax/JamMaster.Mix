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

            string repositoryDirectory = System.Configuration.AppSettingsReader.AppSettings["PFUserName"];
            var tracks = File.ReadLines(Path.Combine())

            return tracks;
        }

        public TrackManager()
        {
        }
    }
}

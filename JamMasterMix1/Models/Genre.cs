using System;
namespace JamMasterMax1.Models
{
    public class Genre
    {
        public Guid GenreID
        {
            get; set;
        }

        public string GenreName
        {
            get; set;
        }

        public Guid GenreParentID
        {
            get; set;
        }

        public Genre()
        {
        }
    }
}

using System;
namespace JamMasterMax1.Models
{
    public class Mix
    {
        public Guid MixID
        {
            get; set;
        }

        public string MixName
        {
            get; set;
        }

        public DateTime MixPublishDate
        {
            get; set;
        }

        //public Curator MixCuratorID
        //{
        //    get; set;
        //}

        public Mix()
        {
        }
    }
}

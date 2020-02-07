using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Revision
    {
        public short RevId { get; set; }
        public string RevisionEn { get; set; }
        public string RevisionSi { get; set; }
        public string RevisionTa { get; set; }
        public string Tag { get; set; }
        public string Des { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

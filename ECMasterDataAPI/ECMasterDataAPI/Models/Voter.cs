using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Voter
    {
        public long VoterId { get; set; }
        public short? Revid { get; set; }
        public string RegType { get; set; }
        public long PerId { get; set; }
        public short? PerInsId { get; set; }
        public int? Hhid { get; set; }
        public byte? Hhext { get; set; }
        public short? SerNo { get; set; }
        public string Cm { get; set; }
        public byte? RelCode { get; set; }
        public byte? Adisid { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
        public short? VerifyBy { get; set; }
        public DateTime? DateVerify { get; set; }
        public short? SerNoLg { get; set; }
        public short? SerNoPc { get; set; }
    }
}

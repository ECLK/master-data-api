using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class PollingStation
    {
        public int Psid { get; set; }
        public int Psidold { get; set; }
        public byte? AdisId { get; set; }
        public short? PdivId { get; set; }
        public string PsnameEn { get; set; }
        public string PsnameSi { get; set; }
        public string PsnameTa { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

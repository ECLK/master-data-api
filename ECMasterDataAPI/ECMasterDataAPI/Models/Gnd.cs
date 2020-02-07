using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Gnd
    {
        public short Gndid { get; set; }
        public short? Dsdid { get; set; }
        public byte? AdisId { get; set; }
        public string Gndno { get; set; }
        public int? Gndidold { get; set; }
        public string GndnameEn { get; set; }
        public string GndnameSi { get; set; }
        public string GndnameTa { get; set; }
        public short? LocCodeId { get; set; }
        public string LocCode { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

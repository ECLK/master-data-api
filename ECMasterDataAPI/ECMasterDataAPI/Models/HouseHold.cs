using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class HouseHold
    {
        public int Hhid { get; set; }
        public string HhnumberEn { get; set; }
        public string HhnumberSi { get; set; }
        public string HhnumberTa { get; set; }
        public string HhnumberOld { get; set; }
        public byte? AdisId { get; set; }
        public int? Vsid { get; set; }
        public short? Gndid { get; set; }
        public short? Lgaid { get; set; }
        public int? Paid { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
        public byte? Hhinsid { get; set; }
    }
}

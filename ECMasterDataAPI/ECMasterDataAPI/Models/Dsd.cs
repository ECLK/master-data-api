using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Dsd
    {
        public short Dsdid { get; set; }
        public int? Dsdcode { get; set; }
        public byte? AdisId { get; set; }
        public string DsdnameEn { get; set; }
        public string DsdnameSi { get; set; }
        public string DsdnameTa { get; set; }
        public bool? Status { get; set; }
        public byte? LocCodeId { get; set; }
        public string LocCode { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

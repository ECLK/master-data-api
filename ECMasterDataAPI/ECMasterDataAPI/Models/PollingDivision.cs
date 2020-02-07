using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class PollingDivision
    {
        public short PdivId { get; set; }
        public short? PdivIdold { get; set; }
        public byte? EdisId { get; set; }
        public byte? Ext { get; set; }
        public byte? AdisId { get; set; }
        public string PdivCodeEn { get; set; }
        public string PdivCodeSi { get; set; }
        public string PdivCodeTa { get; set; }
        public string PdivEn { get; set; }
        public string PdivSi { get; set; }
        public string PdivTa { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

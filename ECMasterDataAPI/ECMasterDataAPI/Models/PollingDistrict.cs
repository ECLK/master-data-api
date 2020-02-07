using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class PollingDistrict
    {
        public int Pdid { get; set; }
        public short? PdivId { get; set; }
        public short? Pdnumber { get; set; }
        public byte? Ext { get; set; }
        public byte? AdisId { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

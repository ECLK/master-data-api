using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Designation
    {
        public short Did { get; set; }
        public string DesignationEn { get; set; }
        public string DesignationSi { get; set; }
        public string DesignationTa { get; set; }
        public byte? Sort { get; set; }
        public bool? Publish { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

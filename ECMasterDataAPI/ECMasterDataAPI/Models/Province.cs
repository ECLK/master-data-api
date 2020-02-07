using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Province
    {
        public byte ProvId { get; set; }
        public string ProvinceEn { get; set; }
        public string ProvinceSi { get; set; }
        public string ProvinceTa { get; set; }
        public byte? LocCode { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

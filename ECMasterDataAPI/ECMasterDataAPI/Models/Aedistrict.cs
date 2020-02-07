using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Aedistrict
    {
        public byte AdisId { get; set; }
        public byte EdisId { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

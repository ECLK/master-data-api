using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Lga
    {
        public short Lgaid { get; set; }
        public byte? Lgatype { get; set; }
        public short? Lganumber { get; set; }
        public byte? AdisId { get; set; }
        public string LganameEn { get; set; }
        public string LganameSi { get; set; }
        public string LganameTa { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

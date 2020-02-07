using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class PostalArea
    {
        public short Paid { get; set; }
        public string PostalCode { get; set; }
        public byte? AdisId { get; set; }
        public string PanameEn { get; set; }
        public string PanameSi { get; set; }
        public string PanameTa { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

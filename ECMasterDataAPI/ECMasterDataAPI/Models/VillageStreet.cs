using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class VillageStreet
    {
        public int Vsid { get; set; }
        public short? Gndid { get; set; }
        public short? Vsono { get; set; }
        public int? Vsidold { get; set; }
        public byte? AdisId { get; set; }
        public string VsnameEn { get; set; }
        public string VsnameSi { get; set; }
        public string VsnameTa { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

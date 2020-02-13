using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECMasterDataAPI.Models.StoredProceduers
{
    public class SpAdminDistricts
    {
        public byte AdisId { get; set; }
        public string DisCode { get; set; }
        public byte? EdisId { get; set; }
        public string DistrictNameEN { get; set; }
        public string DistrictNameSI { get; set; }
        public string DistrictNameTA { get; set; }
        public string Des { get; set; }
        public byte? ProvID { get; set; }
        public byte? LocCodeID { get; set; }
        public string LocCode { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Person
    {
        public long PerId { get; set; }
        public short? PerInsId { get; set; }
        public string Slin { get; set; }
        public string Nic { get; set; }
        public string Nicold { get; set; }
        public byte? AdisId { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameSi { get; set; }
        public string FullNameTa { get; set; }
        public string Sex { get; set; }
        public DateTime? Dob { get; set; }
        public string CommLanguage { get; set; }
        public byte? InsTag { get; set; }
        public short? AddBy { get; set; }
        public DateTime? DateAdd { get; set; }
        public short? UpdateBy { get; set; }
        public DateTime? DateUpdate { get; set; }
        public byte? Slinnictag { get; set; }
    }
}

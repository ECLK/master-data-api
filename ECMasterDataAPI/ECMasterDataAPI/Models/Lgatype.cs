using System;
using System.Collections.Generic;

namespace ECMasterDataAPI.Models
{
    public partial class Lgatype
    {
        public byte Tid { get; set; }
        public byte[] Lgatype1 { get; set; }
        public string LgatypeEn { get; set; }
        public string LgatypeSi { get; set; }
        public string LgatypeTa { get; set; }
        public string Description { get; set; }
    }
}

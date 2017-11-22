using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class AbandonVM
    {
        public Guid EIAttachmentID { get; set; }
        public string BleedingAmount { get; set; }
        public Nullable<decimal> BleedingArea { get; set; }
        public Nullable<decimal> BleedingMostArea { get; set; }
        public string ExudeAmount { get; set; }
        public Nullable<decimal> ExudeArea { get; set; }
        public Nullable<decimal> ExudeMostArea { get; set; }
        public string ImageQualityCD { get; set; }
        public string DetailQualityCD { get; set; }
        public string LensSituationCD { get; set; }
        public string UnitCD { get; set; }
        public string EITypeCD { get; set; }
        public string Suggestion { get; set; }
        public string EIAttachmentPath { get; set; }
    }
}

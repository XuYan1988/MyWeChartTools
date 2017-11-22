using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class MEyeImageAttachmentVM
    {
        public Guid EIAttachmentID { get; set; }

    
        public Nullable<Guid> EyeImageID { get; set; }

        public string EITypeV { get; set; }
        public string EIAttachmentPath { get; set; }

        public int EIOrder { get; set; }
        public int EIAttachmentSize { get; set; }
        public string EyeMiddle_X { get; set; }
        public string EyeMiddle_Y { get; set; }
        public string EyeInner_X { get; set; }
        public string EyeInner_Y { get; set; }
 
    }
}

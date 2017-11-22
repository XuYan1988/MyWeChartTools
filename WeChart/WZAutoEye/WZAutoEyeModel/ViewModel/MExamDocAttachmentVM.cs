using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    [Serializable]
    public partial class MExamDocAttachmentVM
    {
        public Guid ExamAttachmentID { get; set; }

        public Guid EIAttachmentID { get; set; }
        public Nullable<Guid> EyeImageID { get; set; }

        public string ExamTypeV { get; set; }
        public string ExamAttachmentPath { get; set; }

        public int ExamOrder { get; set; }
    }
}

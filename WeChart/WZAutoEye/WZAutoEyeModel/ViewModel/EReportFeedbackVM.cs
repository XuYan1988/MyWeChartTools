using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    [Serializable]
    public partial class EReportFeedbackVM
    {
        public Guid ReportFeedbackID { get; set; }
        public Guid EyeImageID { get; set; }
        public string HospitalCD { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Guid? InsUserID { get; set; }
        public DateTime? InsTime { get; set; }
        public Guid? UpdUserID { get; set; }
        public DateTime? UpdTime { get; set; }
        public string FeedbackStatusCD { get; set; }
        public string ReportTempletCD { get; set; }
        public Guid EIAttachmentID { get; set; }
        public Guid UserID { get; set; }
        public string HospitalName { get; set; }
        public string MobilePhone { get; set; }
        public string UserName { get; set; }

    }
}

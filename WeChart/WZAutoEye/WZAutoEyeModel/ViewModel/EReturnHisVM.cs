using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    [Serializable]
    public partial class EReturnHisVM
    {
        public Guid EyeImageID { get; set; }
        public string ImageCode { get; set; }
        public string PatientNM { get; set; }
        public string sex { get; set; }
        public int Age { get; set; }
        public string Distinguish { get; set; }
        public string Remark { get; set; }
        public DateTime UploadTime { get; set; }
        public DateTime InsTime { get; set; }
        public string ProcessType { get; set; }
        public string ProcessTypeCD { get; set; }
        public string StatusCD { get; set; }
        public string StatusName { get; set; }
        public string Readed { get; set; }
    }
}

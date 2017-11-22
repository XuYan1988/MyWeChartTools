using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class MEyeImageExamDocVM
    {
        public Guid UserID { get; set; }
        //[MEyeImage("EyeImage主键")]
        public Guid EyeImageID { get; set; }

        //[ImageCode("编号")]
        public string ImageCode { get; set; }
        //[PatientNM("患者姓名")]
        public string PatientNM { get; set; }
        //[SexCD("性别")]
        public string SexCD { get; set; }
        //[Age("年龄")]
        public int Age { get; set; }
        //[MDistinguish("区分")]
        public string MDistinguish { get; set; }
        //[HospitalName("医院名称")]
        public string HospitalName { get; set; }
        public string UserName { get; set; }
        //[UploadTime("生成报表日期		")]
        public DateTime UploadTime { get; set; }
        //[CheckTypeCD(“检查类型”)]
        public string CheckTypeCD { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class EExamDocVM
    {
        //[EExamDoc("主键")]
        public Guid ExamDocID { get; set; }
        //[UserID("User主键")]
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
        //[UserName("阅片医生")]
        public string UserName { get; set; }
        //[ReadTime("考核日期")]
        public DateTime InsTime { get; set; }
        //[MStatusCD("状态")]
        public string MStatusCD { get; set; }
        //[ReadTime1("考核开始日期")]
        public DateTime InsTime1 { get; set; }
        //[ReadTime1("考核结束日期")]
        public DateTime InsTime2 { get; set; }
        //[CheckTypeCD(“检查类型”)]
        public string CheckTypeCD { get; set; }
    }
}

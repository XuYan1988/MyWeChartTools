using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class DoctorManagementVM
    {
        //[DisplayName("主键")]
        public Guid UserID { get; set; }

        //[DisplayName("用户姓名")]
        public string UserName { get; set; }

        //[DisplayName("用户姓氏")]
        public string FirstName { get; set; }

        //[DisplayName("性别：0.女;1.男")]
        public string SexCD { get; set; }

        //[DisplayName("性别：0.女;1.男")]
        public string SexName { get; set; }

        //[DisplayName("身份证号")]
        public string IDCard { get; set; }

        //[DisplayName("生日")]
        public string Birthday { get; set; }

        //[DisplayName("电话号码")]
        public string Phone { get; set; }

        //[DisplayName("电子邮箱")]
        public string Email { get; set; }

        //[DisplayName("医院CD")]
        public string HospitalCD { get; set; }

        //[DisplayName("输入的医院名称（阅片医生）")]
        public string InputHospitalNM { get; set; }

        //[DisplayName("科室CD")]
        public string OfficeCD { get; set; }

        //[DisplayName("输入的科室名称（阅片医生）")]
        public string InputOfficeNM { get; set; }

        //[DisplayName("工作年限")]
        public Nullable<int> WorkPeriod { get; set; }

        //[DisplayName("职称:0.主任医师;1.副主任医师;2.主治医师;3.住院医师;4.其他")]
        public string JobTitleCD { get; set; }

        //[DisplayName("职称:0.主任医师;1.副主任医师;2.主治医师;3.住院医师;4.其他")]
        public string JobTitleName { get; set; }

        //[DisplayName("学历:0.学士;1.硕士;2.博士")]
        public string EducationCD { get; set; }

        //[DisplayName("学历:0.学士;1.硕士;2.博士")]
        public string EducationName { get; set; }

        //[DisplayName("特长")]
        public string Speciality { get; set; }

        //[DisplayName("照片")]
        public string PhotoURL { get; set; }

        //[DisplayName("登陆用户名")]
        public string LoginID { get; set; }

        //[DisplayName("密码")]
        public string Passwd { get; set; }

        //[DisplayName("医生签名")]
        public string SignatureURL { get; set; }

        //[DisplayName("允许登陆   0：不可访问   1：可访问")]
        public string CanLogin { get; set; }

        //[DisplayName("用户类型：   UserType-1：医院账户   UserType-2：医生账户   UserType-3：管理员账户")]
        public string UserTypeCD { get; set; }
        public int StatusCD { get; set; }
        public decimal? BaseNum { get; set; }
        public decimal? Quotiety { get; set; }
        public DateTime? ValidTime { get; set; }

    }
}

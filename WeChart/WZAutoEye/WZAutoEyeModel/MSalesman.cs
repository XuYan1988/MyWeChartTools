using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 销售人员信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MSalesman
    {
        public MSalesman()
        {
          this.MHospital_SalesmanIDList = new List<MHospital>();
          this.MRegion_SalesmanIDList = new List<MRegion>();
        }
 
        [Key]
        public Guid SalesmanID { get; set; }
 
        [DisplayName("销售姓名")]
        public string SalesmanNM { get; set; }
 
        [DisplayName("销售员等级：   SalesmanLevel-1：大区总监   SalesmanLevel-2：省直经理   SalesmanLevel-3：地市经理   ")]
        public string SalesmanLevelCD { get; set; }
 
        [DisplayName("父PSalesmanID")]
        public Nullable<Guid> PSalesmanID { get; set; }
 
        [DisplayName("性别：0.女;1.男")]
        public string SexCD { get; set; }
 
        [DisplayName("身份证号")]
        public string IDCard { get; set; }
 
        [DisplayName("生日")]
        public Nullable<DateTime> Birthday { get; set; }
 
        [DisplayName("电话号码")]
        public string Phone { get; set; }
 
        [DisplayName("电子邮箱")]
        public string Email { get; set; }
 
        [DisplayName("手机号码")]
        public string MobilePhone { get; set; }
 
        [DisplayName("学历:0.学士;1.硕士;2.博士")]
        public string EducationCD { get; set; }
 
        [DisplayName("照片")]
        public string PhotoURL { get; set; }
 
        [DisplayName("登陆用户名")]
        public string LoginID { get; set; }
 
        [DisplayName("密码")]
        public string Passwd { get; set; }
 
        [DisplayName("医生签名")]
        public string SignatureURL { get; set; }
 
        [DisplayName("允许登陆   0：不可访问   1：可访问")]
        public bool CanLogin { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        [DisplayName("更新日期")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建日期")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<MHospital> MHospital_SalesmanIDList { get; set; }
        public virtual ICollection<MRegion> MRegion_SalesmanIDList { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}

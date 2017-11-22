using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MPatient
    {
        public MPatient()
        {
          this.MEyeImage_PatientIDList = new List<MEyeImage>();
        }
 
        [Key]
        public Guid PatientID { get; set; }
 
        public string WXID { get; set; }
 
        public string IDCard { get; set; }
 
        public string PatientNM { get; set; }
 
        public Nullable<int> Age { get; set; }
 
        public string SexCD { get; set; }
 
        public string Email { get; set; }
 
        public string Phone { get; set; }
 
        public string WXAddress { get; set; }
 
        public string WXRegion { get; set; }
 
        public string Remark { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<MEyeImage> MEyeImage_PatientIDList { get; set; }
        public virtual MCodeTable SexCD_FK { get; set; }
    }
}

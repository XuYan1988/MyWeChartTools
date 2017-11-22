using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 科室信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MOffice
    {
        public MOffice()
        {
          this.MUser_OfficeCDList = new List<MUser>();
        }
 
        [Key]
        public string OfficeCD { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("科室名称")]
        public string OfficeName { get; set; }
 
        [DisplayName("科室名称_英文")]
        public string OfficeName_EN { get; set; }
 
        public virtual ICollection<MUser> MUser_OfficeCDList { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}

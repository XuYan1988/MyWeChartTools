using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医院项目类别对照表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MHospitalProjectType
    {
        [Key]
        public Guid HosProjectTypeID { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("项目类别:   ProjectType-1：糖网筛防工程   ProjectType-2：绿通项目   ProjectType-3：糖尿病小屋   ProjectType-99：其他")]
        public string ProjectTypeCD { get; set; }
 
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MCodeTable ProjectTypeCD_FK { get; set; }
    }
}

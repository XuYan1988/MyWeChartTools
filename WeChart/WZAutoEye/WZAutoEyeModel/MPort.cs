using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 端口类型表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MPort
    {
        public MPort()
        {
          this.MLoginLog_PortCDList = new List<MLoginLog>();
          this.MUserRole_PortCDList = new List<MUserRole>();
        }
 
        [Key]
        public string PortCD { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        public virtual ICollection<MLoginLog> MLoginLog_PortCDList { get; set; }
        public virtual ICollection<MUserRole> MUserRole_PortCDList { get; set; }
    }
}

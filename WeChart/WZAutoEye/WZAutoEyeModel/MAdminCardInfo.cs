using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医院点卡信息（管理员导入系统）信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MAdminCardInfo
    {
        [Key]
        public Guid AdminCardInfoID { get; set; }
 
        [DisplayName("卡号")]
        public string CardNo { get; set; }
 
        [DisplayName("点数")]
        public Nullable<decimal> CardNum { get; set; }
 
        [DisplayName("导入时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("点卡密码")]
        public string CardPassword { get; set; }
 
    }
}

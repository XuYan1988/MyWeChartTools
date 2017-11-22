using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 操作日志信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MOperationHistory
    {
        [Key]
        public Guid OperationHistoryID { get; set; }
 
        [DisplayName("操作模块")]
        public string Operation { get; set; }
 
        [DisplayName("操作者")]
        public string Operator { get; set; }
 
        [DisplayName("操作时间")]
        public Nullable<DateTime> OperateTime { get; set; }
 
        [DisplayName("是否操作成功")]
        public Nullable<bool> IsSuccess { get; set; }
 
    }
}

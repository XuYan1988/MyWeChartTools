using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 系统设置（只有一条记录）信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月12日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MSystemConfig
    {
        [Key]
        public Guid SystemConfigID { get; set; }

        [DisplayName("阅片模式：   ReadType-1：限制模式   ReadType-2：自由模式")]
        public string ReadTypeCD { get; set; }

        [DisplayName("可否退回：   0：不可退回   1：可退回")]
        public bool CanReturn { get; set; }

        [DisplayName("退回次数")]
        public Nullable<int> ReturnCount { get; set; }

        [DisplayName("点卡充值预警点数")]
        public Nullable<int> WarningCount { get; set; }

        [DisplayName("保留显示时间（月）")]
        public Nullable<int> RetentionTime { get; set; }

        [DisplayName("纠错延缓时间(小时)")]
        public Nullable<int> ErrorCorrectionDelayTime { get; set; }

        public bool ReturnType { get; set; }

        public virtual MCodeTable ReadTypeCD_FK { get; set; }
    }
}

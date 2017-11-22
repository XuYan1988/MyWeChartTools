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
    public partial class MCamera
    {
        public MCamera()
        {
          this.MHospital_CameraCDList = new List<MHospital>();
        }
 
        [Key]
        public string CameraCD { get; set; }
 
        public string PCameraCD { get; set; }
 
        public string CameraNM { get; set; }
 
        public string Remark { get; set; }
 
        public virtual ICollection<MHospital> MHospital_CameraCDList { get; set; }
    }
}

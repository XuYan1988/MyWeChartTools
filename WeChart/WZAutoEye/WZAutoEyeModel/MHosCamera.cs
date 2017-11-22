using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医院相机信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MHosCamera
    {
        public MHosCamera()
        {
          this.MEyeImage_HosCameraIDList = new List<MEyeImage>();
        }
 
        [Key]
        public Guid HosCameraID { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("相机用户名")]
        public string CameraCD { get; set; }
 
        [DisplayName("相机密码")]
        public string CameraPW { get; set; }
 
        [DisplayName("唯一验证码")]
        public string IdenVerCD { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        public virtual ICollection<MEyeImage> MEyeImage_HosCameraIDList { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}

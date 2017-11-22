using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
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

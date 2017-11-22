using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
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
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("����û���")]
        public string CameraCD { get; set; }
 
        [DisplayName("�������")]
        public string CameraPW { get; set; }
 
        [DisplayName("Ψһ��֤��")]
        public string IdenVerCD { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        public virtual ICollection<MEyeImage> MEyeImage_HosCameraIDList { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}

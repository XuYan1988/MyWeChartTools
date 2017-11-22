using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ����ҽ����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MPrescriptionDoctor
    {
        public MPrescriptionDoctor()
        {
          this.MEyeImage_PrescriptionDoctorIDList = new List<MEyeImage>();
        }
 
        [Key]
        public Guid PrescriptionDoctorID { get; set; }
 
        [DisplayName("����ҽ������")]
        public string DoctorName { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        public virtual ICollection<MEyeImage> MEyeImage_PrescriptionDoctorIDList { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}

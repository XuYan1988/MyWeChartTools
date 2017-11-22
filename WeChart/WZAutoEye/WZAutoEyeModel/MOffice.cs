using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MOffice
    {
        public MOffice()
        {
          this.MUser_OfficeCDList = new List<MUser>();
        }
 
        [Key]
        public string OfficeCD { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("��������")]
        public string OfficeName { get; set; }
 
        [DisplayName("��������_Ӣ��")]
        public string OfficeName_EN { get; set; }
 
        public virtual ICollection<MUser> MUser_OfficeCDList { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}

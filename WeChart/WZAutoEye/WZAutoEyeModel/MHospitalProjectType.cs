using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ��Ŀ�����ձ���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MHospitalProjectType
    {
        [Key]
        public Guid HosProjectTypeID { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("��Ŀ���:   ProjectType-1������ɸ������   ProjectType-2����ͨ��Ŀ   ProjectType-3������С��   ProjectType-99������")]
        public string ProjectTypeCD { get; set; }
 
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MCodeTable ProjectTypeCD_FK { get; set; }
    }
}

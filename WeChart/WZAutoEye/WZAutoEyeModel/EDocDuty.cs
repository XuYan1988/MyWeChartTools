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
    public partial class EDocDuty
    {
        [Key]
        public Guid DocDutyID { get; set; }
 
        public Nullable<Guid> UserID { get; set; }
 
        public string DutyTypeCD { get; set; }
 
        public string DutySche { get; set; }
 
        public Nullable<DateTime> StartDate { get; set; }
 
        public string Remark { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MCodeTable DutyTypeCD_FK { get; set; }
    }
}

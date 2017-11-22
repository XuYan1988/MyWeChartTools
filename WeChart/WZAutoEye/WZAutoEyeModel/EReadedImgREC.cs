using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ����Ƭ��¼��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EReadedImgREC
    {
        public EReadedImgREC()
        {
          this.EHosSettleDTL_ReadedImgIDList = new List<EHosSettleDTL>();
        }
 
        [Key]
        public Guid ReadedImgID { get; set; }
 
        [DisplayName("�û�ID(��Ƭҽ��)")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("�۵�ͼ��ID")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("��Ƭʱ��")]
        public Nullable<DateTime> ReadedTime { get; set; }
 
        [DisplayName("����ģʽ��1.�㿨;2.�½�")]
        public string SettleTypeCD { get; set; }
 
        [DisplayName("��Ƭģʽ��   ProcessType-1���˹�����   ProcessType-2���Զ�����")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("����״̬��1.�ѽ�;0.δ��   ��ҽԺ���н����״̬")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_ReadedImgIDList { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MCodeTable SettleTypeCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
    }
}

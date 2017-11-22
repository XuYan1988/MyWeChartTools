using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽ����Ƭ������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MUserDocLevel
    {
        [Key]
        public Guid UserDocLevelID { get; set; }
 
        [DisplayName("�û�ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("����CD��   DocLevel-1��һ��   DocLevel-2������   DocLevel-3������")]
        public string DocLevelCD { get; set; }
 
        [DisplayName("��������CD��   ProcessType-1���˹�����   ProcessType-2���Զ�����   ProcessType-3�����������")]
        public string ProcessTypeCD { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MCodeTable DocLevelCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ϵͳ����֪ͨ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class ENotice
    {
        [Key]
        public Guid NoticeID { get; set; }
 
        [DisplayName("֪ͨ����")]
        public string Title { get; set; }
 
        [DisplayName("֪ͨ����")]
        public string Content { get; set; }
 
        [DisplayName("����֪ͨ���û�ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("���������ͣ�1�������˻����ͣ�RoleType-0��2����������˻����ͣ�MCodeTable��RoleTypeCD")]
        public string RecipientType { get; set; }
 
        [DisplayName("�Ƿ񷢲�1.������0.δ����")]
        public Nullable<bool> IsPublic { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> ReleaseTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
    }
}

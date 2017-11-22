using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��ɫ�˵��м����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MRoleMenu
    {
        [Key]
        public Guid RoleMenuID { get; set; }
 
        [DisplayName("��ɫID")]
        public Nullable<Guid> RoleID { get; set; }
 
        [DisplayName("�˵�ID")]
        public string MenuCD { get; set; }
 
        public virtual MMenu MenuCD_FK { get; set; }
        public virtual MRole RoleID_FK { get; set; }
    }
}

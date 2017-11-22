using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��ɫ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MRole
    {
        public MRole()
        {
          this.MRoleMenu_RoleIDList = new List<MRoleMenu>();
          this.MUserRole_RoleIDList = new List<MUserRole>();
        }
 
        [Key]
        public Guid RoleID { get; set; }
 
        [DisplayName("��ɫ����")]
        public string RoleName { get; set; }
 
        [DisplayName("��ɫ����_Ӣ��")]
        public string RoleName_EN { get; set; }
 
        public virtual ICollection<MRoleMenu> MRoleMenu_RoleIDList { get; set; }
        public virtual ICollection<MUserRole> MUserRole_RoleIDList { get; set; }
    }
}

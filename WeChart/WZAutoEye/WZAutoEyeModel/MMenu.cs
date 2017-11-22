using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �˵���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MMenu
    {
        public MMenu()
        {
          this.MRoleMenu_MenuCDList = new List<MRoleMenu>();
        }
 
        [Key]
        public string MenuCD { get; set; }
 
        [DisplayName("�����˵�CD")]
        public string ParentMenuCD { get; set; }
 
        [DisplayName("�˵�����")]
        public string MenuName { get; set; }
 
        [DisplayName("�˵�����_Ӣ��")]
        public string MenuName_EN { get; set; }
 
        [DisplayName("�˵�KEY")]
        public string MenuKey { get; set; }
 
        [DisplayName("�˵�URL")]
        public string MenuURL { get; set; }
 
        [DisplayName("����")]
        public Nullable<int> OrderNum { get; set; }
 
        [DisplayName("�˵�:0.��˵�;1.�Ҳ˵�")]
        public bool LeftOrRight { get; set; }
 
        [DisplayName("MENUǰ��Сͼ��")]
        public string ImgUrl { get; set; }
 
        public virtual ICollection<MRoleMenu> MRoleMenu_MenuCDList { get; set; }
    }
}

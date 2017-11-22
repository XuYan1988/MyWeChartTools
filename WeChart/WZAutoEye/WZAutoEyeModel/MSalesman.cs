using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ������Ա��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MSalesman
    {
        public MSalesman()
        {
          this.MHospital_SalesmanIDList = new List<MHospital>();
          this.MRegion_SalesmanIDList = new List<MRegion>();
        }
 
        [Key]
        public Guid SalesmanID { get; set; }
 
        [DisplayName("��������")]
        public string SalesmanNM { get; set; }
 
        [DisplayName("����Ա�ȼ���   SalesmanLevel-1�������ܼ�   SalesmanLevel-2��ʡֱ����   SalesmanLevel-3�����о���   ")]
        public string SalesmanLevelCD { get; set; }
 
        [DisplayName("��PSalesmanID")]
        public Nullable<Guid> PSalesmanID { get; set; }
 
        [DisplayName("�Ա�0.Ů;1.��")]
        public string SexCD { get; set; }
 
        [DisplayName("���֤��")]
        public string IDCard { get; set; }
 
        [DisplayName("����")]
        public Nullable<DateTime> Birthday { get; set; }
 
        [DisplayName("�绰����")]
        public string Phone { get; set; }
 
        [DisplayName("��������")]
        public string Email { get; set; }
 
        [DisplayName("�ֻ�����")]
        public string MobilePhone { get; set; }
 
        [DisplayName("ѧ��:0.ѧʿ;1.˶ʿ;2.��ʿ")]
        public string EducationCD { get; set; }
 
        [DisplayName("��Ƭ")]
        public string PhotoURL { get; set; }
 
        [DisplayName("��½�û���")]
        public string LoginID { get; set; }
 
        [DisplayName("����")]
        public string Passwd { get; set; }
 
        [DisplayName("ҽ��ǩ��")]
        public string SignatureURL { get; set; }
 
        [DisplayName("�����½   0�����ɷ���   1���ɷ���")]
        public bool CanLogin { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        [DisplayName("��������")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("������")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("��������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<MHospital> MHospital_SalesmanIDList { get; set; }
        public virtual ICollection<MRegion> MRegion_SalesmanIDList { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}

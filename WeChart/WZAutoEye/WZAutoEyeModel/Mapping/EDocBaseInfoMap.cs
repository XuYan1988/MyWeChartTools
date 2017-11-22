using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽ��������Ϣ��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EDocBaseInfoMap : EntityTypeConfiguration<EDocBaseInfo>
    {
      public EDocBaseInfoMap()
      {
        //����
        this.HasKey(t => t.DocBaseInfo);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("EDocBaseInfo");
        this.Property(t => t.DocBaseInfo).HasColumnName("DocBaseInfo");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.ValidTime).HasColumnName("ValidTime");
        this.Property(t => t.Updtime).HasColumnName("Updtime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocBaseInfo_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocBaseInfo_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocBaseInfo_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
      }
    }
}

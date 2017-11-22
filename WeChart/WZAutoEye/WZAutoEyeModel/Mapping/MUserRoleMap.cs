using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �û���ɫ����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MUserRoleMap : EntityTypeConfiguration<MUserRole>
    {
      public MUserRoleMap()
      {
        //����
        this.HasKey(t => t.UserRoleID);
        
        //����
        
        this.Property(t => t.PortCD)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("MUserRole");
        this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        
         //�����ϵ
        this.HasOptional(t => t.RoleID_FK)
            .WithMany(t => t.MUserRole_RoleIDList)
            .HasForeignKey(d => d.RoleID);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MUserRole_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.PortCD_FK)
            .WithMany(t => t.MUserRole_PortCDList)
            .HasForeignKey(d => d.PortCD);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��ɫ�˵��м����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MRoleMenuMap : EntityTypeConfiguration<MRoleMenu>
    {
      public MRoleMenuMap()
      {
        //����
        this.HasKey(t => t.RoleMenuID);
        
        //����
        
        this.Property(t => t.MenuCD)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("MRoleMenu");
        this.Property(t => t.RoleMenuID).HasColumnName("RoleMenuID");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.MenuCD).HasColumnName("MenuCD");
        
         //�����ϵ
        this.HasOptional(t => t.MenuCD_FK)
            .WithMany(t => t.MRoleMenu_MenuCDList)
            .HasForeignKey(d => d.MenuCD);
        this.HasOptional(t => t.RoleID_FK)
            .WithMany(t => t.MRoleMenu_RoleIDList)
            .HasForeignKey(d => d.RoleID);
      }
    }
}

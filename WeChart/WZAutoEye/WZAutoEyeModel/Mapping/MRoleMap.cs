using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��ɫ��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MRoleMap : EntityTypeConfiguration<MRole>
    {
      public MRoleMap()
      {
        //����
        this.HasKey(t => t.RoleID);
        
        //����
        
        this.Property(t => t.RoleName)
            .HasMaxLength(100);
        
        this.Property(t => t.RoleName_EN)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MRole");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.RoleName).HasColumnName("RoleName");
        this.Property(t => t.RoleName_EN).HasColumnName("RoleName_EN");
        
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 角色信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MRoleMap : EntityTypeConfiguration<MRole>
    {
      public MRoleMap()
      {
        //主键
        this.HasKey(t => t.RoleID);
        
        //属性
        
        this.Property(t => t.RoleName)
            .HasMaxLength(100);
        
        this.Property(t => t.RoleName_EN)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MRole");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.RoleName).HasColumnName("RoleName");
        this.Property(t => t.RoleName_EN).HasColumnName("RoleName_EN");
        
      }
    }
}

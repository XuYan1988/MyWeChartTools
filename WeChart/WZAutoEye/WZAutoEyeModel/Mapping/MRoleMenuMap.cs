using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 角色菜单中间表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MRoleMenuMap : EntityTypeConfiguration<MRoleMenu>
    {
      public MRoleMenuMap()
      {
        //主键
        this.HasKey(t => t.RoleMenuID);
        
        //属性
        
        this.Property(t => t.MenuCD)
            .HasMaxLength(32);
        
        //表与列的对应
        this.ToTable("MRoleMenu");
        this.Property(t => t.RoleMenuID).HasColumnName("RoleMenuID");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.MenuCD).HasColumnName("MenuCD");
        
         //外键关系
        this.HasOptional(t => t.MenuCD_FK)
            .WithMany(t => t.MRoleMenu_MenuCDList)
            .HasForeignKey(d => d.MenuCD);
        this.HasOptional(t => t.RoleID_FK)
            .WithMany(t => t.MRoleMenu_RoleIDList)
            .HasForeignKey(d => d.RoleID);
      }
    }
}

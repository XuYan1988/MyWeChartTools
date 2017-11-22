using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 用户角色表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MUserRoleMap : EntityTypeConfiguration<MUserRole>
    {
      public MUserRoleMap()
      {
        //主键
        this.HasKey(t => t.UserRoleID);
        
        //属性
        
        this.Property(t => t.PortCD)
            .HasMaxLength(32);
        
        //表与列的对应
        this.ToTable("MUserRole");
        this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
        this.Property(t => t.RoleID).HasColumnName("RoleID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        
         //外键关系
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

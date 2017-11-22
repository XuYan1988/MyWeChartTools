using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 登录日志：记录登录者，登录时间，登录或者退出信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MLoginLogMap : EntityTypeConfiguration<MLoginLog>
    {
      public MLoginLogMap()
      {
        //主键
        this.HasKey(t => t.LoginLogID);
        
        //属性
        
        this.Property(t => t.LoginType)
            .HasMaxLength(64);
        
        this.Property(t => t.PortCD)
            .HasMaxLength(32);
        
        //表与列的对应
        this.ToTable("MLoginLog");
        this.Property(t => t.LoginLogID).HasColumnName("LoginLogID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.LoginType).HasColumnName("LoginType");
        this.Property(t => t.LoginTime).HasColumnName("LoginTime");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MLoginLog_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.PortCD_FK)
            .WithMany(t => t.MLoginLog_PortCDList)
            .HasForeignKey(d => d.PortCD);
        this.HasOptional(t => t.LoginType_FK)
            .WithMany(t => t.MLoginLog_LoginTypeList)
            .HasForeignKey(d => d.LoginType);
      }
    }
}

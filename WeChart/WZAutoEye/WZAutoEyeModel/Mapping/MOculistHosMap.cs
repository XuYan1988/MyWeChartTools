using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 片源眼科医生对照表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MOculistHosMap : EntityTypeConfiguration<MOculistHos>
    {
      public MOculistHosMap()
      {
        //主键
        this.HasKey(t => t.OculistHosID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //表与列的对应
        this.ToTable("MOculistHos");
        this.Property(t => t.OculistHosID).HasColumnName("OculistHosID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
         //外键关系
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MOculistHos_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MOculistHos_UserIDList)
            .HasForeignKey(d => d.UserID);
      }
    }
}

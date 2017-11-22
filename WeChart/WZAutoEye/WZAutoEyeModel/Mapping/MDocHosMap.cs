using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 片源医生对照表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MDocHosMap : EntityTypeConfiguration<MDocHos>
    {
      public MDocHosMap()
      {
        //主键
        this.HasKey(t => t.DocHosID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //表与列的对应
        this.ToTable("MDocHos");
        this.Property(t => t.DocHosID).HasColumnName("DocHosID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MDocHos_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MDocHos_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

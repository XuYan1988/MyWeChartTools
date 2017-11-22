using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 科室信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MOfficeMap : EntityTypeConfiguration<MOffice>
    {
      public MOfficeMap()
      {
        //主键
        this.HasKey(t => t.OfficeCD);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.OfficeName)
            .HasMaxLength(100);
        
        this.Property(t => t.OfficeName_EN)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MOffice");
        this.Property(t => t.OfficeCD).HasColumnName("OfficeCD");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.OfficeName).HasColumnName("OfficeName");
        this.Property(t => t.OfficeName_EN).HasColumnName("OfficeName_EN");
        
         //外键关系
        this.HasRequired(t => t.HospitalCD_FK)
            .WithMany(t => t.MOffice_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

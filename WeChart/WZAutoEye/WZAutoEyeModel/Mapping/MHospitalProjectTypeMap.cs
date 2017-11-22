using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院项目类别对照表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MHospitalProjectTypeMap : EntityTypeConfiguration<MHospitalProjectType>
    {
      public MHospitalProjectTypeMap()
      {
        //主键
        this.HasKey(t => t.HosProjectTypeID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.ProjectTypeCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MHospitalProjectType");
        this.Property(t => t.HosProjectTypeID).HasColumnName("HosProjectTypeID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.ProjectTypeCD).HasColumnName("ProjectTypeCD");
        
         //外键关系
        this.HasRequired(t => t.HospitalCD_FK)
            .WithMany(t => t.MHospitalProjectType_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasRequired(t => t.ProjectTypeCD_FK)
            .WithMany(t => t.MHospitalProjectType_ProjectTypeCDList)
            .HasForeignKey(d => d.ProjectTypeCD);
      }
    }
}

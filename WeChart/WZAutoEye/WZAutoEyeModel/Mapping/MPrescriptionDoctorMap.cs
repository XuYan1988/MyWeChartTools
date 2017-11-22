using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 处方医生信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MPrescriptionDoctorMap : EntityTypeConfiguration<MPrescriptionDoctor>
    {
      public MPrescriptionDoctorMap()
      {
        //主键
        this.HasKey(t => t.PrescriptionDoctorID);
        
        //属性
        
        this.Property(t => t.DoctorName)
            .HasMaxLength(100);
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        //表与列的对应
        this.ToTable("MPrescriptionDoctor");
        this.Property(t => t.PrescriptionDoctorID).HasColumnName("PrescriptionDoctorID");
        this.Property(t => t.DoctorName).HasColumnName("DoctorName");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        
         //外键关系
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MPrescriptionDoctor_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

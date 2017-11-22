using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 评估眼底复查图像参数信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MExamDocBleedingMap : EntityTypeConfiguration<MExamDocBleeding>
    {
      public MExamDocBleedingMap()
      {
        //主键
        this.HasKey(t => t.ExBleedingID);
        
        //属性
        
        this.Property(t => t.C_D)
            .HasMaxLength(20);
        
        this.Property(t => t.DiskEdgeShape)
            .HasMaxLength(20);
        
        this.Property(t => t.A_V)
            .HasMaxLength(20);
        
        this.Property(t => t.MacularRegion_Hemorrhage)
            .HasMaxLength(20);
        
        this.Property(t => t.MacularRegion_Exudation)
            .HasMaxLength(20);
        
        this.Property(t => t.PeripheralRetina_Hemorrhage)
            .HasMaxLength(20);
        
        this.Property(t => t.PeripheralRetina_Exudation)
            .HasMaxLength(20);
        
        this.Property(t => t.Other)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MExamDocBleeding");
        this.Property(t => t.ExBleedingID).HasColumnName("ExBleedingID");
        this.Property(t => t.ExamAttachmentID).HasColumnName("ExamAttachmentID");
        this.Property(t => t.C_D).HasColumnName("C_D");
        this.Property(t => t.DiskEdgeShape).HasColumnName("DiskEdgeShape");
        this.Property(t => t.A_V).HasColumnName("A_V");
        this.Property(t => t.MacularRegion_Hemorrhage).HasColumnName("MacularRegion_Hemorrhage");
        this.Property(t => t.MacularRegion_Exudation).HasColumnName("MacularRegion_Exudation");
        this.Property(t => t.PeripheralRetina_Hemorrhage).HasColumnName("PeripheralRetina_Hemorrhage");
        this.Property(t => t.PeripheralRetina_Exudation).HasColumnName("PeripheralRetina_Exudation");
        this.Property(t => t.Other).HasColumnName("Other");
        
         //外键关系
        this.HasOptional(t => t.ExamAttachmentID_FK)
            .WithMany(t => t.MExamDocBleeding_ExamAttachmentIDList)
            .HasForeignKey(d => d.ExamAttachmentID);
      }
    }
}

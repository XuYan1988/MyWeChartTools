using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MCameraMap : EntityTypeConfiguration<MCamera>
    {
      public MCameraMap()
      {
        //主键
        this.HasKey(t => t.CameraCD);
        
        //属性
        
        this.Property(t => t.PCameraCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CameraNM)
            .HasMaxLength(10);
        
        //表与列的对应
        this.ToTable("MCamera");
        this.Property(t => t.CameraCD).HasColumnName("CameraCD");
        this.Property(t => t.PCameraCD).HasColumnName("PCameraCD");
        this.Property(t => t.CameraNM).HasColumnName("CameraNM");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

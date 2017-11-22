using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 端口类型表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MPortMap : EntityTypeConfiguration<MPort>
    {
      public MPortMap()
      {
        //主键
        this.HasKey(t => t.PortCD);
        
        //属性
        
        this.Property(t => t.Remark)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MPort");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

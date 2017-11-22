using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 地址码表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MAddressMap : EntityTypeConfiguration<MAddress>
    {
      public MAddressMap()
      {
        //主键
        this.HasKey(t => t.AddressCD);
        
        //属性
        
        this.Property(t => t.ParentAddressCD)
            .HasMaxLength(5);
        
        this.Property(t => t.Name_EN)
            .HasMaxLength(100);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MAddress");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.ParentAddressCD).HasColumnName("ParentAddressCD");
        this.Property(t => t.Name_EN).HasColumnName("Name_EN");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        
      }
    }
}

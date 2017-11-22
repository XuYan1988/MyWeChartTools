using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 大区省市对应表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MRegionAddressMap : EntityTypeConfiguration<MRegionAddress>
    {
      public MRegionAddressMap()
      {
        //主键
        this.HasKey(t => t.RegionAddressID);
        
        //属性
        
        this.Property(t => t.RegionCD)
            .HasMaxLength(64);
        
        this.Property(t => t.AddressCD)
            .HasMaxLength(5);
        
        //表与列的对应
        this.ToTable("MRegionAddress");
        this.Property(t => t.RegionAddressID).HasColumnName("RegionAddressID");
        this.Property(t => t.RegionCD).HasColumnName("RegionCD");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.RegionCD_FK)
            .WithMany(t => t.MRegionAddress_RegionCDList)
            .HasForeignKey(d => d.RegionCD);
        this.HasOptional(t => t.AddressCD_FK)
            .WithMany(t => t.MRegionAddress_AddressCDList)
            .HasForeignKey(d => d.AddressCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.MRegionAddress_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.MRegionAddress_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 菜单信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MMenuMap : EntityTypeConfiguration<MMenu>
    {
      public MMenuMap()
      {
        //主键
        this.HasKey(t => t.MenuCD);
        
        //属性
        
        this.Property(t => t.ParentMenuCD)
            .HasMaxLength(32);
        
        this.Property(t => t.MenuName)
            .HasMaxLength(100);
        
        this.Property(t => t.MenuName_EN)
            .HasMaxLength(100);
        
        this.Property(t => t.MenuKey)
            .HasMaxLength(100);
        
        this.Property(t => t.MenuURL)
            .HasMaxLength(150);
        
        this.Property(t => t.ImgUrl)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MMenu");
        this.Property(t => t.MenuCD).HasColumnName("MenuCD");
        this.Property(t => t.ParentMenuCD).HasColumnName("ParentMenuCD");
        this.Property(t => t.MenuName).HasColumnName("MenuName");
        this.Property(t => t.MenuName_EN).HasColumnName("MenuName_EN");
        this.Property(t => t.MenuKey).HasColumnName("MenuKey");
        this.Property(t => t.MenuURL).HasColumnName("MenuURL");
        this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        this.Property(t => t.LeftOrRight).HasColumnName("LeftOrRight");
        this.Property(t => t.ImgUrl).HasColumnName("ImgUrl");
        
      }
    }
}

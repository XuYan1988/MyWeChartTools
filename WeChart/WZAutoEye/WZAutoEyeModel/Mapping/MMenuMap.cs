using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �˵���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MMenuMap : EntityTypeConfiguration<MMenu>
    {
      public MMenuMap()
      {
        //����
        this.HasKey(t => t.MenuCD);
        
        //����
        
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
        
        //�����еĶ�Ӧ
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

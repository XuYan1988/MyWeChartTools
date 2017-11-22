using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��ַ�����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MAddressMap : EntityTypeConfiguration<MAddress>
    {
      public MAddressMap()
      {
        //����
        this.HasKey(t => t.AddressCD);
        
        //����
        
        this.Property(t => t.ParentAddressCD)
            .HasMaxLength(5);
        
        this.Property(t => t.Name_EN)
            .HasMaxLength(100);
        
        this.Property(t => t.Name)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MAddress");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.ParentAddressCD).HasColumnName("ParentAddressCD");
        this.Property(t => t.Name_EN).HasColumnName("Name_EN");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        
      }
    }
}

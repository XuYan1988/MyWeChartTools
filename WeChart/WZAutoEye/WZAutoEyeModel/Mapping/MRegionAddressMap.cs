using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ����ʡ�ж�Ӧ����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MRegionAddressMap : EntityTypeConfiguration<MRegionAddress>
    {
      public MRegionAddressMap()
      {
        //����
        this.HasKey(t => t.RegionAddressID);
        
        //����
        
        this.Property(t => t.RegionCD)
            .HasMaxLength(64);
        
        this.Property(t => t.AddressCD)
            .HasMaxLength(5);
        
        //�����еĶ�Ӧ
        this.ToTable("MRegionAddress");
        this.Property(t => t.RegionAddressID).HasColumnName("RegionAddressID");
        this.Property(t => t.RegionCD).HasColumnName("RegionCD");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
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

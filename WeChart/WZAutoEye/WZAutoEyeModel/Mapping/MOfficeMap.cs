using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MOfficeMap : EntityTypeConfiguration<MOffice>
    {
      public MOfficeMap()
      {
        //����
        this.HasKey(t => t.OfficeCD);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.OfficeName)
            .HasMaxLength(100);
        
        this.Property(t => t.OfficeName_EN)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MOffice");
        this.Property(t => t.OfficeCD).HasColumnName("OfficeCD");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.OfficeName).HasColumnName("OfficeName");
        this.Property(t => t.OfficeName_EN).HasColumnName("OfficeName_EN");
        
         //�����ϵ
        this.HasRequired(t => t.HospitalCD_FK)
            .WithMany(t => t.MOffice_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

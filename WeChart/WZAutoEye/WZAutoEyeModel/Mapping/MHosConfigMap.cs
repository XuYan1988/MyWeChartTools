using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MHosConfigMap : EntityTypeConfiguration<MHosConfig>
    {
      public MHosConfigMap()
      {
        //����
        this.HasKey(t => t.HosConfigID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("MHosConfig");
        this.Property(t => t.HosConfigID).HasColumnName("HosConfigID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        
         //�����ϵ
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MHosConfig_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

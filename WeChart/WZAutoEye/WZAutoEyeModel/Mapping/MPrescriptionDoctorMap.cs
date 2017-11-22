using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ����ҽ����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MPrescriptionDoctorMap : EntityTypeConfiguration<MPrescriptionDoctor>
    {
      public MPrescriptionDoctorMap()
      {
        //����
        this.HasKey(t => t.PrescriptionDoctorID);
        
        //����
        
        this.Property(t => t.DoctorName)
            .HasMaxLength(100);
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("MPrescriptionDoctor");
        this.Property(t => t.PrescriptionDoctorID).HasColumnName("PrescriptionDoctorID");
        this.Property(t => t.DoctorName).HasColumnName("DoctorName");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        
         //�����ϵ
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MPrescriptionDoctor_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ��Ŀ�����ձ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MHospitalProjectTypeMap : EntityTypeConfiguration<MHospitalProjectType>
    {
      public MHospitalProjectTypeMap()
      {
        //����
        this.HasKey(t => t.HosProjectTypeID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.ProjectTypeCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("MHospitalProjectType");
        this.Property(t => t.HosProjectTypeID).HasColumnName("HosProjectTypeID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.ProjectTypeCD).HasColumnName("ProjectTypeCD");
        
         //�����ϵ
        this.HasRequired(t => t.HospitalCD_FK)
            .WithMany(t => t.MHospitalProjectType_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasRequired(t => t.ProjectTypeCD_FK)
            .WithMany(t => t.MHospitalProjectType_ProjectTypeCDList)
            .HasForeignKey(d => d.ProjectTypeCD);
      }
    }
}

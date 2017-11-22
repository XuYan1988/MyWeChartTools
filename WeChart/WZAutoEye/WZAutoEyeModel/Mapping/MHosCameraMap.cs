using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MHosCameraMap : EntityTypeConfiguration<MHosCamera>
    {
      public MHosCameraMap()
      {
        //����
        this.HasKey(t => t.HosCameraID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.CameraCD)
            .HasMaxLength(32);
        
        this.Property(t => t.CameraPW)
            .HasMaxLength(32);
        
        this.Property(t => t.IdenVerCD)
            .HasMaxLength(128);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MHosCamera");
        this.Property(t => t.HosCameraID).HasColumnName("HosCameraID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.CameraCD).HasColumnName("CameraCD");
        this.Property(t => t.CameraPW).HasColumnName("CameraPW");
        this.Property(t => t.IdenVerCD).HasColumnName("IdenVerCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
         //�����ϵ
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MHosCamera_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MPatientMap : EntityTypeConfiguration<MPatient>
    {
      public MPatientMap()
      {
        //����
        this.HasKey(t => t.PatientID);
        
        //����
        
        this.Property(t => t.WXID)
            .HasMaxLength(200);
        
        this.Property(t => t.IDCard)
            .HasMaxLength(100);
        
        this.Property(t => t.PatientNM)
            .HasMaxLength(100);
        
        this.Property(t => t.SexCD)
            .HasMaxLength(64);
        
        this.Property(t => t.Email)
            .HasMaxLength(100);
        
        this.Property(t => t.Phone)
            .HasMaxLength(100);
        
        this.Property(t => t.WXAddress)
            .HasMaxLength(200);
        
        this.Property(t => t.WXRegion)
            .HasMaxLength(200);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MPatient");
        this.Property(t => t.PatientID).HasColumnName("PatientID");
        this.Property(t => t.WXID).HasColumnName("WXID");
        this.Property(t => t.IDCard).HasColumnName("IDCard");
        this.Property(t => t.PatientNM).HasColumnName("PatientNM");
        this.Property(t => t.Age).HasColumnName("Age");
        this.Property(t => t.SexCD).HasColumnName("SexCD");
        this.Property(t => t.Email).HasColumnName("Email");
        this.Property(t => t.Phone).HasColumnName("Phone");
        this.Property(t => t.WXAddress).HasColumnName("WXAddress");
        this.Property(t => t.WXRegion).HasColumnName("WXRegion");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.SexCD_FK)
            .WithMany(t => t.MPatient_SexCDList)
            .HasForeignKey(d => d.SexCD);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ƬԴ�ۿ�ҽ�����ձ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MOculistHosMap : EntityTypeConfiguration<MOculistHos>
    {
      public MOculistHosMap()
      {
        //����
        this.HasKey(t => t.OculistHosID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MOculistHos");
        this.Property(t => t.OculistHosID).HasColumnName("OculistHosID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
         //�����ϵ
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MOculistHos_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MOculistHos_UserIDList)
            .HasForeignKey(d => d.UserID);
      }
    }
}

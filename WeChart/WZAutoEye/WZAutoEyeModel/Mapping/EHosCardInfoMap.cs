using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�㿨��Ϣ��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EHosCardInfoMap : EntityTypeConfiguration<EHosCardInfo>
    {
      public EHosCardInfoMap()
      {
        //����
        this.HasKey(t => t.HosCardInfoID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.CardNo)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("EHosCardInfo");
        this.Property(t => t.HosCardInfoID).HasColumnName("HosCardInfoID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.CardNo).HasColumnName("CardNo");
        this.Property(t => t.CardNum).HasColumnName("CardNum");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EHosCardInfo_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosCardInfo_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosCardInfo_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
      }
    }
}

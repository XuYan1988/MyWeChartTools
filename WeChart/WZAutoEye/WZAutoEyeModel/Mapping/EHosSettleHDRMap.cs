using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ����HDR��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EHosSettleHDRMap : EntityTypeConfiguration<EHosSettleHDR>
    {
      public EHosSettleHDRMap()
      {
        //����
        this.HasKey(t => t.HosSettleHID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Remark)
            .HasMaxLength(200);
        
        //�����еĶ�Ӧ
        this.ToTable("EHosSettleHDR");
        this.Property(t => t.HosSettleHID).HasColumnName("HosSettleHID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Price).HasColumnName("Price");
        this.Property(t => t.Quantity).HasColumnName("Quantity");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.HosSettleBID).HasColumnName("HosSettleBID");
        
         //�����ϵ
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosSettleHDR_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EHosSettleHDR_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosSettleHDR_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.HosSettleBID_FK)
            .WithMany(t => t.EHosSettleHDR_HosSettleBIDList)
            .HasForeignKey(d => d.HosSettleBID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ����DTL��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EHosSettleDTLMap : EntityTypeConfiguration<EHosSettleDTL>
    {
      public EHosSettleDTLMap()
      {
        //����
        this.HasKey(t => t.HosSettleDID);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("EHosSettleDTL");
        this.Property(t => t.HosSettleDID).HasColumnName("HosSettleDID");
        this.Property(t => t.HosSettleHID).HasColumnName("HosSettleHID");
        this.Property(t => t.ReadedImgID).HasColumnName("ReadedImgID");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.HosSettleHID_FK)
            .WithMany(t => t.EHosSettleDTL_HosSettleHIDList)
            .HasForeignKey(d => d.HosSettleHID);
        this.HasOptional(t => t.ReadedImgID_FK)
            .WithMany(t => t.EHosSettleDTL_ReadedImgIDList)
            .HasForeignKey(d => d.ReadedImgID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosSettleDTL_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosSettleDTL_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ƭҽ������DTL��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EDocSettleDTLMap : EntityTypeConfiguration<EDocSettleDTL>
    {
      public EDocSettleDTLMap()
      {
        //����
        this.HasKey(t => t.DocSettleDID);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("EDocSettleDTL");
        this.Property(t => t.DocSettleDID).HasColumnName("DocSettleDID");
        this.Property(t => t.DocSettleHID).HasColumnName("DocSettleHID");
        this.Property(t => t.ReadRECID).HasColumnName("ReadRECID");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.GlaucomaReadID).HasColumnName("GlaucomaReadID");
        this.Property(t => t.AutoReadID).HasColumnName("AutoReadID");
        
         //�����ϵ
        this.HasOptional(t => t.GlaucomaReadID_FK)
            .WithMany(t => t.EDocSettleDTL_GlaucomaReadIDList)
            .HasForeignKey(d => d.GlaucomaReadID);
        this.HasOptional(t => t.DocSettleHID_FK)
            .WithMany(t => t.EDocSettleDTL_DocSettleHIDList)
            .HasForeignKey(d => d.DocSettleHID);
        this.HasOptional(t => t.ReadRECID_FK)
            .WithMany(t => t.EDocSettleDTL_ReadRECIDList)
            .HasForeignKey(d => d.ReadRECID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocSettleDTL_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocSettleDTL_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.ExamDocID_FK)
            .WithMany(t => t.EDocSettleDTL_ExamDocIDList)
            .HasForeignKey(d => d.ExamDocID);
        this.HasOptional(t => t.AutoReadID_FK)
            .WithMany(t => t.EDocSettleDTL_AutoReadIDList)
            .HasForeignKey(d => d.AutoReadID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �������Ƭ��¼��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EGlaucomaReadRECMap : EntityTypeConfiguration<EGlaucomaReadREC>
    {
      public EGlaucomaReadRECMap()
      {
        //����
        this.HasKey(t => t.GlaucomaReadID);
        
        //����
        
        this.Property(t => t.ReportTempletCD)
            .HasMaxLength(64);
        
        this.Property(t => t.GlaucomaStatusCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EGlaucomaReadREC");
        this.Property(t => t.GlaucomaReadID).HasColumnName("GlaucomaReadID");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.ManualReadTime).HasColumnName("ManualReadTime");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.AutoReadTime).HasColumnName("AutoReadTime");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.Impression).HasColumnName("Impression");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.ReportTempletCD).HasColumnName("ReportTempletCD");
        this.Property(t => t.GlaucomaStatusCD).HasColumnName("GlaucomaStatusCD");
        
         //�����ϵ
        this.HasOptional(t => t.GlaucomaStatusCD_FK)
            .WithMany(t => t.EGlaucomaReadREC_GlaucomaStatusCDList)
            .HasForeignKey(d => d.GlaucomaStatusCD);
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EGlaucomaReadREC_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EGlaucomaReadREC_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EGlaucomaReadREC_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EGlaucomaReadREC_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.ReportTempletCD_FK)
            .WithMany(t => t.EGlaucomaReadREC_ReportTempletCDList)
            .HasForeignKey(d => d.ReportTempletCD);
      }
    }
}

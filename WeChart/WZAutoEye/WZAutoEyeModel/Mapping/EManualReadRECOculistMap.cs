using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �˹���Ƭ��¼�ۿ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EManualReadRECOculistMap : EntityTypeConfiguration<EManualReadRECOculist>
    {
      public EManualReadRECOculistMap()
      {
        //����
        this.HasKey(t => t.ManualReadOLID);
        
        //����
        
        this.Property(t => t.ReportTempletCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ImpressionCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EManualReadRECOculist");
        this.Property(t => t.ManualReadOLID).HasColumnName("ManualReadOLID");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.ReadTime).HasColumnName("ReadTime");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.EyeOffice).HasColumnName("EyeOffice");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.ReportTempletCD).HasColumnName("ReportTempletCD");
        this.Property(t => t.ImpressionCD).HasColumnName("ImpressionCD");
        
         //�����ϵ
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EManualReadRECOculist_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EManualReadRECOculist_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EManualReadRECOculist_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.ReportTempletCD_FK)
            .WithMany(t => t.EManualReadRECOculist_ReportTempletCDList)
            .HasForeignKey(d => d.ReportTempletCD);
        this.HasOptional(t => t.ImpressionCD_FK)
            .WithMany(t => t.EManualReadRECOculist_ImpressionCDList)
            .HasForeignKey(d => d.ImpressionCD);
      }
    }
}

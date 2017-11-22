using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ���淴������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EReportFeedbackMap : EntityTypeConfiguration<EReportFeedback>
    {
      public EReportFeedbackMap()
      {
        //����
        this.HasKey(t => t.ReportFeedbackID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.FeedbackStatusCD)
            .HasMaxLength(64);
        
        this.Property(t => t.QuestionTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.MisAttributionCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EReportFeedback");
        this.Property(t => t.ReportFeedbackID).HasColumnName("ReportFeedbackID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Question).HasColumnName("Question");
        this.Property(t => t.Answer).HasColumnName("Answer");
        this.Property(t => t.FeedbackStatusCD).HasColumnName("FeedbackStatusCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.QuestionTypeCD).HasColumnName("QuestionTypeCD");
        this.Property(t => t.MisAttributionCD).HasColumnName("MisAttributionCD");
        
         //�����ϵ
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EReportFeedback_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EReportFeedback_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.FeedbackStatusCD_FK)
            .WithMany(t => t.EReportFeedback_FeedbackStatusCDList)
            .HasForeignKey(d => d.FeedbackStatusCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EReportFeedback_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EReportFeedback_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.QuestionTypeCD_FK)
            .WithMany(t => t.EReportFeedback_QuestionTypeCDList)
            .HasForeignKey(d => d.QuestionTypeCD);
        this.HasOptional(t => t.MisAttributionCD_FK)
            .WithMany(t => t.EReportFeedback_MisAttributionCDList)
            .HasForeignKey(d => d.MisAttributionCD);
      }
    }
}

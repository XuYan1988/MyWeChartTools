using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ����ҽ����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EExamDocMap : EntityTypeConfiguration<EExamDoc>
    {
      public EExamDocMap()
      {
        //����
        this.HasKey(t => t.ExamDocID);
        
        //����
        
        this.Property(t => t.StatusCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ImpressionCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EExamDoc");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.EyeOffice).HasColumnName("EyeOffice");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.StatusCD).HasColumnName("StatusCD");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.ReadTime).HasColumnName("ReadTime");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.ImpressionCD).HasColumnName("ImpressionCD");
        
         //�����ϵ
        this.HasOptional(t => t.ImpressionCD_FK)
            .WithMany(t => t.EExamDoc_ImpressionCDList)
            .HasForeignKey(d => d.ImpressionCD);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EExamDoc_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EExamDoc_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EExamDoc_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.StatusCD_FK)
            .WithMany(t => t.EExamDoc_StatusCDList)
            .HasForeignKey(d => d.StatusCD);
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EExamDoc_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
      }
    }
}

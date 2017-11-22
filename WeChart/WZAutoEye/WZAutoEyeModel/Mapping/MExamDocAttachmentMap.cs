using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �������۵׸���ͼ�񸽼�����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MExamDocAttachmentMap : EntityTypeConfiguration<MExamDocAttachment>
    {
      public MExamDocAttachmentMap()
      {
        //����
        this.HasKey(t => t.ExamAttachmentID);
        
        //����
        
        this.Property(t => t.ExamTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ExamAttachmentName)
            .HasMaxLength(100);
        
        this.Property(t => t.ExamAttachmentType)
            .HasMaxLength(10);
        
        this.Property(t => t.ExamAttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MExamDocAttachment");
        this.Property(t => t.ExamAttachmentID).HasColumnName("ExamAttachmentID");
        this.Property(t => t.ExamTypeCD).HasColumnName("ExamTypeCD");
        this.Property(t => t.ExamAttachmentName).HasColumnName("ExamAttachmentName");
        this.Property(t => t.ExamAttachmentSize).HasColumnName("ExamAttachmentSize");
        this.Property(t => t.ExamAttachmentType).HasColumnName("ExamAttachmentType");
        this.Property(t => t.ExamAttachmentPath).HasColumnName("ExamAttachmentPath");
        this.Property(t => t.UploadTime).HasColumnName("UploadTime");
        this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UploadOrder).HasColumnName("UploadOrder");
        
         //�����ϵ
        this.HasOptional(t => t.ExamDocID_FK)
            .WithMany(t => t.MExamDocAttachment_ExamDocIDList)
            .HasForeignKey(d => d.ExamDocID);
        this.HasOptional(t => t.ExamTypeCD_FK)
            .WithMany(t => t.MExamDocAttachment_ExamTypeCDList)
            .HasForeignKey(d => d.ExamTypeCD);
        this.HasOptional(t => t.UploadUserID_FK)
            .WithMany(t => t.MExamDocAttachment_UploadUserIDList)
            .HasForeignKey(d => d.UploadUserID);
      }
    }
}

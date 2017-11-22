using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MAttachmentMap : EntityTypeConfiguration<MAttachment>
    {
      public MAttachmentMap()
      {
        //����
        this.HasKey(t => t.AttachmentID);
        
        //����
        
        this.Property(t => t.ObjectType)
            .HasMaxLength(100);
        
        this.Property(t => t.AttachmentName)
            .HasMaxLength(100);
        
        this.Property(t => t.AttachmentType)
            .HasMaxLength(10);
        
        this.Property(t => t.AttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MAttachment");
        this.Property(t => t.AttachmentID).HasColumnName("AttachmentID");
        this.Property(t => t.ObjectType).HasColumnName("ObjectType");
        this.Property(t => t.ObjectID).HasColumnName("ObjectID");
        this.Property(t => t.AttachmentName).HasColumnName("AttachmentName");
        this.Property(t => t.AttachmentSize).HasColumnName("AttachmentSize");
        this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
        this.Property(t => t.AttachmentPath).HasColumnName("AttachmentPath");
        this.Property(t => t.UploadTime).HasColumnName("UploadTime");
        this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

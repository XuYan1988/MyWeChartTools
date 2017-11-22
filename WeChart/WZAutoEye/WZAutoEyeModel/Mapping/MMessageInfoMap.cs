using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MMessageInfoMap : EntityTypeConfiguration<MMessageInfo>
    {
      public MMessageInfoMap()
      {
        //����
        this.HasKey(t => t.MessageInfoID);
        
        //����
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.MessageType)
            .HasMaxLength(64);
        
        this.Property(t => t.MessageContent)
            .HasMaxLength(200);
        
        //�����еĶ�Ӧ
        this.ToTable("MMessageInfo");
        this.Property(t => t.MessageInfoID).HasColumnName("MessageInfoID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.MessageType).HasColumnName("MessageType");
        this.Property(t => t.MessageContent).HasColumnName("MessageContent");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        
         //�����ϵ
        this.HasOptional(t => t.MessageType_FK)
            .WithMany(t => t.MMessageInfo_MessageTypeList)
            .HasForeignKey(d => d.MessageType);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MMessageInfo_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MMessageInfo_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

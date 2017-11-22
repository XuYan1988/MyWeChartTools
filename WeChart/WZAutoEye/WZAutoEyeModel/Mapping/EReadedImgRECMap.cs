using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ����Ƭ��¼��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EReadedImgRECMap : EntityTypeConfiguration<EReadedImgREC>
    {
      public EReadedImgRECMap()
      {
        //����
        this.HasKey(t => t.ReadedImgID);
        
        //����
        
        this.Property(t => t.SettleTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ProcessTypeCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EReadedImgREC");
        this.Property(t => t.ReadedImgID).HasColumnName("ReadedImgID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.ReadedTime).HasColumnName("ReadedTime");
        this.Property(t => t.SettleTypeCD).HasColumnName("SettleTypeCD");
        this.Property(t => t.ProcessTypeCD).HasColumnName("ProcessTypeCD");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EReadedImgREC_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EReadedImgREC_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EReadedImgREC_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EReadedImgREC_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.SettleTypeCD_FK)
            .WithMany(t => t.EReadedImgREC_SettleTypeCDList)
            .HasForeignKey(d => d.SettleTypeCD);
        this.HasOptional(t => t.ProcessTypeCD_FK)
            .WithMany(t => t.EReadedImgREC_ProcessTypeCDList)
            .HasForeignKey(d => d.ProcessTypeCD);
      }
    }
}

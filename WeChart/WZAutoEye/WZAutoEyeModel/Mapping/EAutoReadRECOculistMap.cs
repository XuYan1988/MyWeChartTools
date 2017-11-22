using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �Զ���Ƭ��¼�ۿ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EAutoReadRECOculistMap : EntityTypeConfiguration<EAutoReadRECOculist>
    {
      public EAutoReadRECOculistMap()
      {
        //����
        this.HasKey(t => t.AutoReadOLID);
        
        //����
        
        this.Property(t => t.Unit)
            .HasMaxLength(64);
        
        this.Property(t => t.ReportTempletCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EAutoReadRECOculist");
        this.Property(t => t.AutoReadOLID).HasColumnName("AutoReadOLID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.Unit).HasColumnName("Unit");
        this.Property(t => t.ReportTempletCD).HasColumnName("ReportTempletCD");
        this.Property(t => t.EyeOffice).HasColumnName("EyeOffice");
        
         //�����ϵ
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EAutoReadRECOculist_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EAutoReadRECOculist_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EAutoReadRECOculist_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.ReportTempletCD_FK)
            .WithMany(t => t.EAutoReadRECOculist_ReportTempletCDList)
            .HasForeignKey(d => d.ReportTempletCD);
      }
    }
}

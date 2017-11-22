using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽ����Ƭ������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MUserDocLevelMap : EntityTypeConfiguration<MUserDocLevel>
    {
      public MUserDocLevelMap()
      {
        //����
        this.HasKey(t => t.UserDocLevelID);
        
        //����
        
        this.Property(t => t.DocLevelCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ProcessTypeCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("MUserDocLevel");
        this.Property(t => t.UserDocLevelID).HasColumnName("UserDocLevelID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DocLevelCD).HasColumnName("DocLevelCD");
        this.Property(t => t.ProcessTypeCD).HasColumnName("ProcessTypeCD");
        
         //�����ϵ
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MUserDocLevel_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.DocLevelCD_FK)
            .WithMany(t => t.MUserDocLevel_DocLevelCDList)
            .HasForeignKey(d => d.DocLevelCD);
        this.HasOptional(t => t.ProcessTypeCD_FK)
            .WithMany(t => t.MUserDocLevel_ProcessTypeCDList)
            .HasForeignKey(d => d.ProcessTypeCD);
      }
    }
}

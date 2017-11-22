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
    public class EDocDutyMap : EntityTypeConfiguration<EDocDuty>
    {
      public EDocDutyMap()
      {
        //����
        this.HasKey(t => t.DocDutyID);
        
        //����
        
        this.Property(t => t.DutyTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.DutySche)
            .HasMaxLength(1000);
        
        //�����еĶ�Ӧ
        this.ToTable("EDocDuty");
        this.Property(t => t.DocDutyID).HasColumnName("DocDutyID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DutyTypeCD).HasColumnName("DutyTypeCD");
        this.Property(t => t.DutySche).HasColumnName("DutySche");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocDuty_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.DutyTypeCD_FK)
            .WithMany(t => t.EDocDuty_DutyTypeCDList)
            .HasForeignKey(d => d.DutyTypeCD);
      }
    }
}

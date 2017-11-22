using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽ������HDR��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EDocSettleHDRMap : EntityTypeConfiguration<EDocSettleHDR>
    {
      public EDocSettleHDRMap()
      {
        //����
        this.HasKey(t => t.DocSettleHID);
        
        //����
        
        //�����еĶ�Ӧ
        this.ToTable("EDocSettleHDR");
        this.Property(t => t.DocSettleHID).HasColumnName("DocSettleHID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DocPoint).HasColumnName("DocPoint");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        this.Property(t => t.SumPoint).HasColumnName("SumPoint");
        this.Property(t => t.NotClearPoint).HasColumnName("NotClearPoint");
        this.Property(t => t.ClearPoint).HasColumnName("ClearPoint");
        this.Property(t => t.DocSettleBID).HasColumnName("DocSettleBID");
        
         //�����ϵ
        this.HasOptional(t => t.DocSettleBID_FK)
            .WithMany(t => t.EDocSettleHDR_DocSettleBIDList)
            .HasForeignKey(d => d.DocSettleBID);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocSettleHDR_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocSettleHDR_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocSettleHDR_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

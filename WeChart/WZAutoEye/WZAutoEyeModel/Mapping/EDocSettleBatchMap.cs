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
    public class EDocSettleBatchMap : EntityTypeConfiguration<EDocSettleBatch>
    {
      public EDocSettleBatchMap()
      {
        //����
        this.HasKey(t => t.DocSettleBID);
        
        //����
        
        this.Property(t => t.DocSettleBNO)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("EDocSettleBatch");
        this.Property(t => t.DocSettleBID).HasColumnName("DocSettleBID");
        this.Property(t => t.DocSettleBNO).HasColumnName("DocSettleBNO");
        this.Property(t => t.DocCount).HasColumnName("DocCount");
        this.Property(t => t.DocSumPoint).HasColumnName("DocSumPoint");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        
      }
    }
}

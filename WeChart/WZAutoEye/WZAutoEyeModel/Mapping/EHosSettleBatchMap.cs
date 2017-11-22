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
    public class EHosSettleBatchMap : EntityTypeConfiguration<EHosSettleBatch>
    {
      public EHosSettleBatchMap()
      {
        //����
        this.HasKey(t => t.HosSettleBID);
        
        //����
        
        this.Property(t => t.HosSettleBNO)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("EHosSettleBatch");
        this.Property(t => t.HosSettleBID).HasColumnName("HosSettleBID");
        this.Property(t => t.HosSettleBNO).HasColumnName("HosSettleBNO");
        this.Property(t => t.HosCount).HasColumnName("HosCount");
        this.Property(t => t.HosSum).HasColumnName("HosSum");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        
      }
    }
}

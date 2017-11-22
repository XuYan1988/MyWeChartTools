using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ������־��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MOperationHistoryMap : EntityTypeConfiguration<MOperationHistory>
    {
      public MOperationHistoryMap()
      {
        //����
        this.HasKey(t => t.OperationHistoryID);
        
        //����
        
        this.Property(t => t.Operation)
            .HasMaxLength(200);
        
        this.Property(t => t.Operator)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MOperationHistory");
        this.Property(t => t.OperationHistoryID).HasColumnName("OperationHistoryID");
        this.Property(t => t.Operation).HasColumnName("Operation");
        this.Property(t => t.Operator).HasColumnName("Operator");
        this.Property(t => t.OperateTime).HasColumnName("OperateTime");
        this.Property(t => t.IsSuccess).HasColumnName("IsSuccess");
        
      }
    }
}

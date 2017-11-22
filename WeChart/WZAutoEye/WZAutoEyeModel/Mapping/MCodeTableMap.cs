using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��10��23��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MCodeTableMap : EntityTypeConfiguration<MCodeTable>
    {
      public MCodeTableMap()
      {
        //����
        this.HasKey(t => t.CodeTableCD);
        
        //����
        
        this.Property(t => t.CodeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CodeType)
            .HasMaxLength(64);
        
        this.Property(t => t.CodeDesc)
            .HasMaxLength(500);
        
        this.Property(t => t.CodeDesc_EN)
            .HasMaxLength(500);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //�����еĶ�Ӧ
        this.ToTable("MCodeTable");
        this.Property(t => t.CodeTableCD).HasColumnName("CodeTableCD");
        this.Property(t => t.CodeCD).HasColumnName("CodeCD");
        this.Property(t => t.CodeType).HasColumnName("CodeType");
        this.Property(t => t.CodeDesc).HasColumnName("CodeDesc");
        this.Property(t => t.CodeDesc_EN).HasColumnName("CodeDesc_EN");
        this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �˿����ͱ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MPortMap : EntityTypeConfiguration<MPort>
    {
      public MPortMap()
      {
        //����
        this.HasKey(t => t.PortCD);
        
        //����
        
        this.Property(t => t.Remark)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MPort");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

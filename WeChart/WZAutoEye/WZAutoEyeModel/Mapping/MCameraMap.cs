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
    public class MCameraMap : EntityTypeConfiguration<MCamera>
    {
      public MCameraMap()
      {
        //����
        this.HasKey(t => t.CameraCD);
        
        //����
        
        this.Property(t => t.PCameraCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CameraNM)
            .HasMaxLength(10);
        
        //�����еĶ�Ӧ
        this.ToTable("MCamera");
        this.Property(t => t.CameraCD).HasColumnName("CameraCD");
        this.Property(t => t.PCameraCD).HasColumnName("PCameraCD");
        this.Property(t => t.CameraNM).HasColumnName("CameraNM");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}

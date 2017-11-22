using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �����۵׸���ͼ�������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MExamDocBleedingMap : EntityTypeConfiguration<MExamDocBleeding>
    {
      public MExamDocBleedingMap()
      {
        //����
        this.HasKey(t => t.ExBleedingID);
        
        //����
        
        this.Property(t => t.C_D)
            .HasMaxLength(20);
        
        this.Property(t => t.DiskEdgeShape)
            .HasMaxLength(20);
        
        this.Property(t => t.A_V)
            .HasMaxLength(20);
        
        this.Property(t => t.MacularRegion_Hemorrhage)
            .HasMaxLength(20);
        
        this.Property(t => t.MacularRegion_Exudation)
            .HasMaxLength(20);
        
        this.Property(t => t.PeripheralRetina_Hemorrhage)
            .HasMaxLength(20);
        
        this.Property(t => t.PeripheralRetina_Exudation)
            .HasMaxLength(20);
        
        this.Property(t => t.Other)
            .HasMaxLength(100);
        
        //�����еĶ�Ӧ
        this.ToTable("MExamDocBleeding");
        this.Property(t => t.ExBleedingID).HasColumnName("ExBleedingID");
        this.Property(t => t.ExamAttachmentID).HasColumnName("ExamAttachmentID");
        this.Property(t => t.C_D).HasColumnName("C_D");
        this.Property(t => t.DiskEdgeShape).HasColumnName("DiskEdgeShape");
        this.Property(t => t.A_V).HasColumnName("A_V");
        this.Property(t => t.MacularRegion_Hemorrhage).HasColumnName("MacularRegion_Hemorrhage");
        this.Property(t => t.MacularRegion_Exudation).HasColumnName("MacularRegion_Exudation");
        this.Property(t => t.PeripheralRetina_Hemorrhage).HasColumnName("PeripheralRetina_Hemorrhage");
        this.Property(t => t.PeripheralRetina_Exudation).HasColumnName("PeripheralRetina_Exudation");
        this.Property(t => t.Other).HasColumnName("Other");
        
         //�����ϵ
        this.HasOptional(t => t.ExamAttachmentID_FK)
            .WithMany(t => t.MExamDocBleeding_ExamAttachmentIDList)
            .HasForeignKey(d => d.ExamAttachmentID);
      }
    }
}

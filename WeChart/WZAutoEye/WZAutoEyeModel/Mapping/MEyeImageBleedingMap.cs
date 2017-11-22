using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �۵׸���ͼ���Ѫ/������Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MEyeImageBleedingMap : EntityTypeConfiguration<MEyeImageBleeding>
    {
      public MEyeImageBleedingMap()
      {
        //����
        this.HasKey(t => t.EIBleedingID);
        
        //����
        
        this.Property(t => t.BleedingAmount)
            .HasMaxLength(100);
        
        this.Property(t => t.ExudeAmount)
            .HasMaxLength(100);
        
        this.Property(t => t.ImageQualityCD)
            .HasMaxLength(64);
        
        this.Property(t => t.DetailQualityCD)
            .HasMaxLength(64);
        
        this.Property(t => t.LensSituationCD)
            .HasMaxLength(64);
        
        this.Property(t => t.UnitCD)
            .HasMaxLength(64);
        
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
        this.ToTable("MEyeImageBleeding");
        this.Property(t => t.EIBleedingID).HasColumnName("EIBleedingID");
        this.Property(t => t.EIAttachmentID).HasColumnName("EIAttachmentID");
        this.Property(t => t.BleedingAmount).HasColumnName("BleedingAmount");
        this.Property(t => t.BleedingArea).HasColumnName("BleedingArea");
        this.Property(t => t.BleedingMostArea).HasColumnName("BleedingMostArea");
        this.Property(t => t.ExudeAmount).HasColumnName("ExudeAmount");
        this.Property(t => t.ExudeArea).HasColumnName("ExudeArea");
        this.Property(t => t.ExudeMostArea).HasColumnName("ExudeMostArea");
        this.Property(t => t.ImageQualityCD).HasColumnName("ImageQualityCD");
        this.Property(t => t.DetailQualityCD).HasColumnName("DetailQualityCD");
        this.Property(t => t.LensSituationCD).HasColumnName("LensSituationCD");
        this.Property(t => t.UnitCD).HasColumnName("UnitCD");
        this.Property(t => t.MVOCDRR_OD).HasColumnName("MVOCDRR_OD");
        this.Property(t => t.MVOCDRR_OS).HasColumnName("MVOCDRR_OS");
        this.Property(t => t.MVOCDRR_Normal).HasColumnName("MVOCDRR_Normal");
        this.Property(t => t.IsntScore_OD).HasColumnName("IsntScore_OD");
        this.Property(t => t.IsntScore_OS).HasColumnName("IsntScore_OS");
        this.Property(t => t.IsntScore_Normal).HasColumnName("IsntScore_Normal");
        this.Property(t => t.Inferior_OD).HasColumnName("Inferior_OD");
        this.Property(t => t.Inferior_OS).HasColumnName("Inferior_OS");
        this.Property(t => t.Inferior_Normal).HasColumnName("Inferior_Normal");
        this.Property(t => t.Superior_OD).HasColumnName("Superior_OD");
        this.Property(t => t.Superior_OS).HasColumnName("Superior_OS");
        this.Property(t => t.Superior_Normal).HasColumnName("Superior_Normal");
        this.Property(t => t.Nasal_OD).HasColumnName("Nasal_OD");
        this.Property(t => t.Nasal_OS).HasColumnName("Nasal_OS");
        this.Property(t => t.Nasal_Normal).HasColumnName("Nasal_Normal");
        this.Property(t => t.Temporal_OD).HasColumnName("Temporal_OD");
        this.Property(t => t.Temporal_OS).HasColumnName("Temporal_OS");
        this.Property(t => t.Temporal_Normal).HasColumnName("Temporal_Normal");
        this.Property(t => t.C_D).HasColumnName("C_D");
        this.Property(t => t.DiskEdgeShape).HasColumnName("DiskEdgeShape");
        this.Property(t => t.A_V).HasColumnName("A_V");
        this.Property(t => t.MacularRegion_Hemorrhage).HasColumnName("MacularRegion_Hemorrhage");
        this.Property(t => t.MacularRegion_Exudation).HasColumnName("MacularRegion_Exudation");
        this.Property(t => t.PeripheralRetina_Hemorrhage).HasColumnName("PeripheralRetina_Hemorrhage");
        this.Property(t => t.PeripheralRetina_Exudation).HasColumnName("PeripheralRetina_Exudation");
        this.Property(t => t.Other).HasColumnName("Other");
        
         //�����ϵ
        this.HasOptional(t => t.EIAttachmentID_FK)
            .WithMany(t => t.MEyeImageBleeding_EIAttachmentIDList)
            .HasForeignKey(d => d.EIAttachmentID);
        this.HasOptional(t => t.UnitCD_FK)
            .WithMany(t => t.MEyeImageBleeding_UnitCDList)
            .HasForeignKey(d => d.UnitCD);
        this.HasOptional(t => t.ImageQualityCD_FK)
            .WithMany(t => t.MEyeImageBleeding_ImageQualityCDList)
            .HasForeignKey(d => d.ImageQualityCD);
        this.HasOptional(t => t.DetailQualityCD_FK)
            .WithMany(t => t.MEyeImageBleeding_DetailQualityCDList)
            .HasForeignKey(d => d.DetailQualityCD);
        this.HasOptional(t => t.LensSituationCD_FK)
            .WithMany(t => t.MEyeImageBleeding_LensSituationCDList)
            .HasForeignKey(d => d.LensSituationCD);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ϵͳ���ã�ֻ��һ����¼����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��10��12��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MSystemConfigMap : EntityTypeConfiguration<MSystemConfig>
    {
        public MSystemConfigMap()
        {
            //����
            this.HasKey(t => t.SystemConfigID);

            //����

            this.Property(t => t.ReadTypeCD)
                .HasMaxLength(64);

            //�����еĶ�Ӧ
            this.ToTable("MSystemConfig");
            this.Property(t => t.SystemConfigID).HasColumnName("SystemConfigID");
            this.Property(t => t.ReadTypeCD).HasColumnName("ReadTypeCD");
            this.Property(t => t.CanReturn).HasColumnName("CanReturn");
            this.Property(t => t.ReturnCount).HasColumnName("ReturnCount");
            this.Property(t => t.WarningCount).HasColumnName("WarningCount");
            this.Property(t => t.RetentionTime).HasColumnName("RetentionTime");
            this.Property(t => t.ErrorCorrectionDelayTime).HasColumnName("ErrorCorrectionDelayTime");
            this.Property(t => t.ReturnType).HasColumnName("ReturnType");

            //�����ϵ
            this.HasOptional(t => t.ReadTypeCD_FK)
                .WithMany(t => t.MSystemConfig_ReadTypeCDList)
                .HasForeignKey(d => d.ReadTypeCD);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 系统设置（只有一条记录）信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月12日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MSystemConfigMap : EntityTypeConfiguration<MSystemConfig>
    {
        public MSystemConfigMap()
        {
            //主键
            this.HasKey(t => t.SystemConfigID);

            //属性

            this.Property(t => t.ReadTypeCD)
                .HasMaxLength(64);

            //表与列的对应
            this.ToTable("MSystemConfig");
            this.Property(t => t.SystemConfigID).HasColumnName("SystemConfigID");
            this.Property(t => t.ReadTypeCD).HasColumnName("ReadTypeCD");
            this.Property(t => t.CanReturn).HasColumnName("CanReturn");
            this.Property(t => t.ReturnCount).HasColumnName("ReturnCount");
            this.Property(t => t.WarningCount).HasColumnName("WarningCount");
            this.Property(t => t.RetentionTime).HasColumnName("RetentionTime");
            this.Property(t => t.ErrorCorrectionDelayTime).HasColumnName("ErrorCorrectionDelayTime");
            this.Property(t => t.ReturnType).HasColumnName("ReturnType");

            //外键关系
            this.HasOptional(t => t.ReadTypeCD_FK)
                .WithMany(t => t.MSystemConfig_ReadTypeCDList)
                .HasForeignKey(d => d.ReadTypeCD);
        }
    }
}

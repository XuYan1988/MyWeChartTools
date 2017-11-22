using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医生阅片级别信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MUserDocLevelMap : EntityTypeConfiguration<MUserDocLevel>
    {
      public MUserDocLevelMap()
      {
        //主键
        this.HasKey(t => t.UserDocLevelID);
        
        //属性
        
        this.Property(t => t.DocLevelCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ProcessTypeCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MUserDocLevel");
        this.Property(t => t.UserDocLevelID).HasColumnName("UserDocLevelID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DocLevelCD).HasColumnName("DocLevelCD");
        this.Property(t => t.ProcessTypeCD).HasColumnName("ProcessTypeCD");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MUserDocLevel_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.DocLevelCD_FK)
            .WithMany(t => t.MUserDocLevel_DocLevelCDList)
            .HasForeignKey(d => d.DocLevelCD);
        this.HasOptional(t => t.ProcessTypeCD_FK)
            .WithMany(t => t.MUserDocLevel_ProcessTypeCDList)
            .HasForeignKey(d => d.ProcessTypeCD);
      }
    }
}

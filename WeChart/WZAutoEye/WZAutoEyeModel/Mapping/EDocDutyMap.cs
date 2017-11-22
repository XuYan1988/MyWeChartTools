using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EDocDutyMap : EntityTypeConfiguration<EDocDuty>
    {
      public EDocDutyMap()
      {
        //主键
        this.HasKey(t => t.DocDutyID);
        
        //属性
        
        this.Property(t => t.DutyTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.DutySche)
            .HasMaxLength(1000);
        
        //表与列的对应
        this.ToTable("EDocDuty");
        this.Property(t => t.DocDutyID).HasColumnName("DocDutyID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DutyTypeCD).HasColumnName("DutyTypeCD");
        this.Property(t => t.DutySche).HasColumnName("DutySche");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocDuty_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.DutyTypeCD_FK)
            .WithMany(t => t.EDocDuty_DutyTypeCDList)
            .HasForeignKey(d => d.DutyTypeCD);
      }
    }
}

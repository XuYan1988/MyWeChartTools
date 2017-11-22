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
    public class EDocSettleBatchMap : EntityTypeConfiguration<EDocSettleBatch>
    {
      public EDocSettleBatchMap()
      {
        //主键
        this.HasKey(t => t.DocSettleBID);
        
        //属性
        
        this.Property(t => t.DocSettleBNO)
            .HasMaxLength(32);
        
        //表与列的对应
        this.ToTable("EDocSettleBatch");
        this.Property(t => t.DocSettleBID).HasColumnName("DocSettleBID");
        this.Property(t => t.DocSettleBNO).HasColumnName("DocSettleBNO");
        this.Property(t => t.DocCount).HasColumnName("DocCount");
        this.Property(t => t.DocSumPoint).HasColumnName("DocSumPoint");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        
      }
    }
}

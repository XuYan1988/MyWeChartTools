using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 操作日志信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MOperationHistoryMap : EntityTypeConfiguration<MOperationHistory>
    {
      public MOperationHistoryMap()
      {
        //主键
        this.HasKey(t => t.OperationHistoryID);
        
        //属性
        
        this.Property(t => t.Operation)
            .HasMaxLength(200);
        
        this.Property(t => t.Operator)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("MOperationHistory");
        this.Property(t => t.OperationHistoryID).HasColumnName("OperationHistoryID");
        this.Property(t => t.Operation).HasColumnName("Operation");
        this.Property(t => t.Operator).HasColumnName("Operator");
        this.Property(t => t.OperateTime).HasColumnName("OperateTime");
        this.Property(t => t.IsSuccess).HasColumnName("IsSuccess");
        
      }
    }
}

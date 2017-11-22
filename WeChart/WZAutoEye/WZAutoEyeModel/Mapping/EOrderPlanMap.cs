using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 下达计划信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EOrderPlanMap : EntityTypeConfiguration<EOrderPlan>
    {
      public EOrderPlanMap()
      {
        //主键
        this.HasKey(t => t.OrderPlanID);
        
        //属性
        
        this.Property(t => t.RegionCD)
            .HasMaxLength(64);
        
        this.Property(t => t.PlanYear)
            .HasMaxLength(4);
        
        this.Property(t => t.PlanMonth)
            .HasMaxLength(2);
        
        //表与列的对应
        this.ToTable("EOrderPlan");
        this.Property(t => t.OrderPlanID).HasColumnName("OrderPlanID");
        this.Property(t => t.RegionCD).HasColumnName("RegionCD");
        this.Property(t => t.PlanYear).HasColumnName("PlanYear");
        this.Property(t => t.PlanMonth).HasColumnName("PlanMonth");
        this.Property(t => t.ScreenQuantity).HasColumnName("ScreenQuantity");
        this.Property(t => t.DevelopQuantity).HasColumnName("DevelopQuantity");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.RegionCD_FK)
            .WithMany(t => t.EOrderPlan_RegionCDList)
            .HasForeignKey(d => d.RegionCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EOrderPlan_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EOrderPlan_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

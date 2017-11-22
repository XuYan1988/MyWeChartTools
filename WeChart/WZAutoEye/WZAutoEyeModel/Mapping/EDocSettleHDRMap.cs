using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医生结算HDR信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EDocSettleHDRMap : EntityTypeConfiguration<EDocSettleHDR>
    {
      public EDocSettleHDRMap()
      {
        //主键
        this.HasKey(t => t.DocSettleHID);
        
        //属性
        
        //表与列的对应
        this.ToTable("EDocSettleHDR");
        this.Property(t => t.DocSettleHID).HasColumnName("DocSettleHID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.DocPoint).HasColumnName("DocPoint");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        this.Property(t => t.SumPoint).HasColumnName("SumPoint");
        this.Property(t => t.NotClearPoint).HasColumnName("NotClearPoint");
        this.Property(t => t.ClearPoint).HasColumnName("ClearPoint");
        this.Property(t => t.DocSettleBID).HasColumnName("DocSettleBID");
        
         //外键关系
        this.HasOptional(t => t.DocSettleBID_FK)
            .WithMany(t => t.EDocSettleHDR_DocSettleBIDList)
            .HasForeignKey(d => d.DocSettleBID);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocSettleHDR_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocSettleHDR_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocSettleHDR_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

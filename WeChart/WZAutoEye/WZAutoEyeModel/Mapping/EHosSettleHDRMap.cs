using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院结算HDR信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EHosSettleHDRMap : EntityTypeConfiguration<EHosSettleHDR>
    {
      public EHosSettleHDRMap()
      {
        //主键
        this.HasKey(t => t.HosSettleHID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Remark)
            .HasMaxLength(200);
        
        //表与列的对应
        this.ToTable("EHosSettleHDR");
        this.Property(t => t.HosSettleHID).HasColumnName("HosSettleHID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.Price).HasColumnName("Price");
        this.Property(t => t.Quantity).HasColumnName("Quantity");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.StartDate).HasColumnName("StartDate");
        this.Property(t => t.EndDate).HasColumnName("EndDate");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.HosSettleBID).HasColumnName("HosSettleBID");
        
         //外键关系
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosSettleHDR_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EHosSettleHDR_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosSettleHDR_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.HosSettleBID_FK)
            .WithMany(t => t.EHosSettleHDR_HosSettleBIDList)
            .HasForeignKey(d => d.HosSettleBID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院结算DTL信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EHosSettleDTLMap : EntityTypeConfiguration<EHosSettleDTL>
    {
      public EHosSettleDTLMap()
      {
        //主键
        this.HasKey(t => t.HosSettleDID);
        
        //属性
        
        //表与列的对应
        this.ToTable("EHosSettleDTL");
        this.Property(t => t.HosSettleDID).HasColumnName("HosSettleDID");
        this.Property(t => t.HosSettleHID).HasColumnName("HosSettleHID");
        this.Property(t => t.ReadedImgID).HasColumnName("ReadedImgID");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.HosSettleHID_FK)
            .WithMany(t => t.EHosSettleDTL_HosSettleHIDList)
            .HasForeignKey(d => d.HosSettleHID);
        this.HasOptional(t => t.ReadedImgID_FK)
            .WithMany(t => t.EHosSettleDTL_ReadedImgIDList)
            .HasForeignKey(d => d.ReadedImgID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosSettleDTL_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosSettleDTL_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

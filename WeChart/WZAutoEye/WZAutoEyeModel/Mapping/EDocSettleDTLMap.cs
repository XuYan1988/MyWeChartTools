using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 阅片医生结算DTL信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EDocSettleDTLMap : EntityTypeConfiguration<EDocSettleDTL>
    {
      public EDocSettleDTLMap()
      {
        //主键
        this.HasKey(t => t.DocSettleDID);
        
        //属性
        
        //表与列的对应
        this.ToTable("EDocSettleDTL");
        this.Property(t => t.DocSettleDID).HasColumnName("DocSettleDID");
        this.Property(t => t.DocSettleHID).HasColumnName("DocSettleHID");
        this.Property(t => t.ReadRECID).HasColumnName("ReadRECID");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.GlaucomaReadID).HasColumnName("GlaucomaReadID");
        this.Property(t => t.AutoReadID).HasColumnName("AutoReadID");
        
         //外键关系
        this.HasOptional(t => t.GlaucomaReadID_FK)
            .WithMany(t => t.EDocSettleDTL_GlaucomaReadIDList)
            .HasForeignKey(d => d.GlaucomaReadID);
        this.HasOptional(t => t.DocSettleHID_FK)
            .WithMany(t => t.EDocSettleDTL_DocSettleHIDList)
            .HasForeignKey(d => d.DocSettleHID);
        this.HasOptional(t => t.ReadRECID_FK)
            .WithMany(t => t.EDocSettleDTL_ReadRECIDList)
            .HasForeignKey(d => d.ReadRECID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocSettleDTL_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocSettleDTL_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.ExamDocID_FK)
            .WithMany(t => t.EDocSettleDTL_ExamDocIDList)
            .HasForeignKey(d => d.ExamDocID);
        this.HasOptional(t => t.AutoReadID_FK)
            .WithMany(t => t.EDocSettleDTL_AutoReadIDList)
            .HasForeignKey(d => d.AutoReadID);
      }
    }
}

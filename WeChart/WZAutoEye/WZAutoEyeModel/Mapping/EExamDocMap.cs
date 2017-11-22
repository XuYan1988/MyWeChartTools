using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 考核医生信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EExamDocMap : EntityTypeConfiguration<EExamDoc>
    {
      public EExamDocMap()
      {
        //主键
        this.HasKey(t => t.ExamDocID);
        
        //属性
        
        this.Property(t => t.StatusCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ImpressionCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("EExamDoc");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.EyeOffice).HasColumnName("EyeOffice");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.StatusCD).HasColumnName("StatusCD");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.ReadTime).HasColumnName("ReadTime");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.ImpressionCD).HasColumnName("ImpressionCD");
        
         //外键关系
        this.HasOptional(t => t.ImpressionCD_FK)
            .WithMany(t => t.EExamDoc_ImpressionCDList)
            .HasForeignKey(d => d.ImpressionCD);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EExamDoc_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EExamDoc_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EExamDoc_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.StatusCD_FK)
            .WithMany(t => t.EExamDoc_StatusCDList)
            .HasForeignKey(d => d.StatusCD);
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EExamDoc_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
      }
    }
}

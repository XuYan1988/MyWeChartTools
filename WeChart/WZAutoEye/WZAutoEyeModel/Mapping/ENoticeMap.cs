using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 系统公告通知信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class ENoticeMap : EntityTypeConfiguration<ENotice>
    {
      public ENoticeMap()
      {
        //主键
        this.HasKey(t => t.NoticeID);
        
        //属性
        
        this.Property(t => t.Title)
            .HasMaxLength(50);
        
        this.Property(t => t.Content)
            .HasMaxLength(200);
        
        this.Property(t => t.RecipientType)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("ENotice");
        this.Property(t => t.NoticeID).HasColumnName("NoticeID");
        this.Property(t => t.Title).HasColumnName("Title");
        this.Property(t => t.Content).HasColumnName("Content");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.RecipientType).HasColumnName("RecipientType");
        this.Property(t => t.IsPublic).HasColumnName("IsPublic");
        this.Property(t => t.ReleaseTime).HasColumnName("ReleaseTime");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.ENotice_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.ENotice_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.ENotice_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
      }
    }
}

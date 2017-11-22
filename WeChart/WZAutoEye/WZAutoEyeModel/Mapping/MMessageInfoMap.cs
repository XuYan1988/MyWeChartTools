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
    public class MMessageInfoMap : EntityTypeConfiguration<MMessageInfo>
    {
      public MMessageInfoMap()
      {
        //主键
        this.HasKey(t => t.MessageInfoID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.MessageType)
            .HasMaxLength(64);
        
        this.Property(t => t.MessageContent)
            .HasMaxLength(200);
        
        //表与列的对应
        this.ToTable("MMessageInfo");
        this.Property(t => t.MessageInfoID).HasColumnName("MessageInfoID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.MessageType).HasColumnName("MessageType");
        this.Property(t => t.MessageContent).HasColumnName("MessageContent");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        
         //外键关系
        this.HasOptional(t => t.MessageType_FK)
            .WithMany(t => t.MMessageInfo_MessageTypeList)
            .HasForeignKey(d => d.MessageType);
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MMessageInfo_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MMessageInfo_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
      }
    }
}

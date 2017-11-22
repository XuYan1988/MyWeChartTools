using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医生基数信息信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EDocBaseInfoMap : EntityTypeConfiguration<EDocBaseInfo>
    {
      public EDocBaseInfoMap()
      {
        //主键
        this.HasKey(t => t.DocBaseInfo);
        
        //属性
        
        //表与列的对应
        this.ToTable("EDocBaseInfo");
        this.Property(t => t.DocBaseInfo).HasColumnName("DocBaseInfo");
        this.Property(t => t.BaseNum).HasColumnName("BaseNum");
        this.Property(t => t.Quotiety).HasColumnName("Quotiety");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.ValidTime).HasColumnName("ValidTime");
        this.Property(t => t.Updtime).HasColumnName("Updtime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.EDocBaseInfo_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EDocBaseInfo_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EDocBaseInfo_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
      }
    }
}

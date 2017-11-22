using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医生退回记录信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EReturnHisMap : EntityTypeConfiguration<EReturnHis>
    {
      public EReturnHisMap()
      {
        //主键
        this.HasKey(t => t.ReturnHisID);
        
        //属性
        
        this.Property(t => t.DocLevelCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("EReturnHis");
        this.Property(t => t.ReturnHisID).HasColumnName("ReturnHisID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.ReturnUserID).HasColumnName("ReturnUserID");
        this.Property(t => t.Readed).HasColumnName("Readed");
        this.Property(t => t.DocLevelCD).HasColumnName("DocLevelCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EReturnHis_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.ReturnUserID_FK)
            .WithMany(t => t.EReturnHis_ReturnUserIDList)
            .HasForeignKey(d => d.ReturnUserID);
        this.HasOptional(t => t.DocLevelCD_FK)
            .WithMany(t => t.EReturnHis_DocLevelCDList)
            .HasForeignKey(d => d.DocLevelCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EReturnHis_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EReturnHis_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

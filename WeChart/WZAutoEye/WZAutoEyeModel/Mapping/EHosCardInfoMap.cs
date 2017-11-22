using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院点卡信息信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EHosCardInfoMap : EntityTypeConfiguration<EHosCardInfo>
    {
      public EHosCardInfoMap()
      {
        //主键
        this.HasKey(t => t.HosCardInfoID);
        
        //属性
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.CardNo)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("EHosCardInfo");
        this.Property(t => t.HosCardInfoID).HasColumnName("HosCardInfoID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.CardNo).HasColumnName("CardNo");
        this.Property(t => t.CardNum).HasColumnName("CardNum");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EHosCardInfo_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EHosCardInfo_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EHosCardInfo_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
      }
    }
}

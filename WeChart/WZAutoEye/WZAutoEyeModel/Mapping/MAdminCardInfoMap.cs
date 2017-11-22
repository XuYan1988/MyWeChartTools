using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院点卡信息（管理员导入系统）信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MAdminCardInfoMap : EntityTypeConfiguration<MAdminCardInfo>
    {
      public MAdminCardInfoMap()
      {
        //主键
        this.HasKey(t => t.AdminCardInfoID);
        
        //属性
        
        this.Property(t => t.CardNo)
            .HasMaxLength(100);
        
        this.Property(t => t.CardPassword)
            .HasMaxLength(128);
        
        //表与列的对应
        this.ToTable("MAdminCardInfo");
        this.Property(t => t.AdminCardInfoID).HasColumnName("AdminCardInfoID");
        this.Property(t => t.CardNo).HasColumnName("CardNo");
        this.Property(t => t.CardNum).HasColumnName("CardNum");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.CardPassword).HasColumnName("CardPassword");
        
      }
    }
}

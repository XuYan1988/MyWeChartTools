using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 医院表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月23日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MHospitalMap : EntityTypeConfiguration<MHospital>
    {
      public MHospitalMap()
      {
        //主键
        this.HasKey(t => t.HospitalCD);
        
        //属性
        
        this.Property(t => t.AddressCD)
            .HasMaxLength(5);
        
        this.Property(t => t.HospitalName)
            .HasMaxLength(100);
        
        this.Property(t => t.AddressName)
            .HasMaxLength(200);
        
        this.Property(t => t.HospitalName_EN)
            .HasMaxLength(100);
        
        this.Property(t => t.AddressName_EN)
            .HasMaxLength(200);
        
        this.Property(t => t.CheckTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ProcessTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.SettleTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ReportTempletCD)
            .HasMaxLength(64);
        
        this.Property(t => t.TemplateRemarkOne)
            .HasMaxLength(200);
        
        this.Property(t => t.TemplateRemarkTwo)
            .HasMaxLength(200);
        
        this.Property(t => t.CameraCD)
            .HasMaxLength(64);
        
        this.Property(t => t.BindRuleCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CameraOwnerCD)
            .HasMaxLength(64);
        
        this.Property(t => t.HospitalLevelCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ReadTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.AutoReportTempletCD)
            .HasMaxLength(64);
        
        this.Property(t => t.GlaReportTempletCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MHospital");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.HospitalName).HasColumnName("HospitalName");
        this.Property(t => t.AddressName).HasColumnName("AddressName");
        this.Property(t => t.HospitalName_EN).HasColumnName("HospitalName_EN");
        this.Property(t => t.AddressName_EN).HasColumnName("AddressName_EN");
        this.Property(t => t.CheckTypeCD).HasColumnName("CheckTypeCD");
        this.Property(t => t.ProcessTypeCD).HasColumnName("ProcessTypeCD");
        this.Property(t => t.CanAccess).HasColumnName("CanAccess");
        this.Property(t => t.NowCardCount).HasColumnName("NowCardCount");
        this.Property(t => t.SettleTypeCD).HasColumnName("SettleTypeCD");
        this.Property(t => t.ImageQualityView).HasColumnName("ImageQualityView");
        this.Property(t => t.LensSituationView).HasColumnName("LensSituationView");
        this.Property(t => t.AutoReport).HasColumnName("AutoReport");
        this.Property(t => t.SaveInk).HasColumnName("SaveInk");
        this.Property(t => t.ReportTempletCD).HasColumnName("ReportTempletCD");
        this.Property(t => t.BleedingNumType).HasColumnName("BleedingNumType");
        this.Property(t => t.TemplateRemarkOne).HasColumnName("TemplateRemarkOne");
        this.Property(t => t.TemplateRemarkTwo).HasColumnName("TemplateRemarkTwo");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.CameraCD).HasColumnName("CameraCD");
        this.Property(t => t.BindRuleCD).HasColumnName("BindRuleCD");
        this.Property(t => t.Signed).HasColumnName("Signed");
        this.Property(t => t.SignedAmount).HasColumnName("SignedAmount");
        this.Property(t => t.SignedDate).HasColumnName("SignedDate");
        this.Property(t => t.CameraOwnerCD).HasColumnName("CameraOwnerCD");
        this.Property(t => t.HospitalLevelCD).HasColumnName("HospitalLevelCD");
        this.Property(t => t.ReadTypeCD).HasColumnName("ReadTypeCD");
        this.Property(t => t.SalesmanID).HasColumnName("SalesmanID");
        this.Property(t => t.AutoReportTempletCD).HasColumnName("AutoReportTempletCD");
        this.Property(t => t.GlaReportTempletCD).HasColumnName("GlaReportTempletCD");
        
         //外键关系
        this.HasOptional(t => t.CameraCD_FK)
            .WithMany(t => t.MHospital_CameraCDList)
            .HasForeignKey(d => d.CameraCD);
        this.HasOptional(t => t.SalesmanID_FK)
            .WithMany(t => t.MHospital_SalesmanIDList)
            .HasForeignKey(d => d.SalesmanID);
        this.HasOptional(t => t.BindRuleCD_FK)
            .WithMany(t => t.MHospital_BindRuleCDList)
            .HasForeignKey(d => d.BindRuleCD);
        this.HasOptional(t => t.AddressCD_FK)
            .WithMany(t => t.MHospital_AddressCDList)
            .HasForeignKey(d => d.AddressCD);
        this.HasOptional(t => t.AutoReportTempletCD_FK)
            .WithMany(t => t.MHospital_AutoReportTempletCDList)
            .HasForeignKey(d => d.AutoReportTempletCD);
        this.HasOptional(t => t.CheckTypeCD_FK)
            .WithMany(t => t.MHospital_CheckTypeCDList)
            .HasForeignKey(d => d.CheckTypeCD);
        this.HasOptional(t => t.GlaReportTempletCD_FK)
            .WithMany(t => t.MHospital_GlaReportTempletCDList)
            .HasForeignKey(d => d.GlaReportTempletCD);
        this.HasOptional(t => t.ProcessTypeCD_FK)
            .WithMany(t => t.MHospital_ProcessTypeCDList)
            .HasForeignKey(d => d.ProcessTypeCD);
        this.HasOptional(t => t.SettleTypeCD_FK)
            .WithMany(t => t.MHospital_SettleTypeCDList)
            .HasForeignKey(d => d.SettleTypeCD);
        this.HasOptional(t => t.ReportTempletCD_FK)
            .WithMany(t => t.MHospital_ReportTempletCDList)
            .HasForeignKey(d => d.ReportTempletCD);
        this.HasOptional(t => t.CameraOwnerCD_FK)
            .WithMany(t => t.MHospital_CameraOwnerCDList)
            .HasForeignKey(d => d.CameraOwnerCD);
        this.HasOptional(t => t.HospitalLevelCD_FK)
            .WithMany(t => t.MHospital_HospitalLevelCDList)
            .HasForeignKey(d => d.HospitalLevelCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.MHospital_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.MHospital_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.ReadTypeCD_FK)
            .WithMany(t => t.MHospital_ReadTypeCDList)
            .HasForeignKey(d => d.ReadTypeCD);
      }
    }
}

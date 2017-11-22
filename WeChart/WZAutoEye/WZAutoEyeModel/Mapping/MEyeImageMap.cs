using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 眼底图像信息信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MEyeImageMap : EntityTypeConfiguration<MEyeImage>
    {
      public MEyeImageMap()
      {
        //主键
        this.HasKey(t => t.EyeImageID);
        
        //属性
        
        this.Property(t => t.ImageCode)
            .HasMaxLength(64);
        
        this.Property(t => t.DistinguishCD)
            .HasMaxLength(64);
        
        this.Property(t => t.IDCard)
            .HasMaxLength(100);
        
        this.Property(t => t.PatientNM)
            .HasMaxLength(100);
        
        this.Property(t => t.SexCD)
            .HasMaxLength(64);
        
        this.Property(t => t.RecordDoctorNM)
            .HasMaxLength(128);
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.Email)
            .HasMaxLength(100);
        
        this.Property(t => t.Phone)
            .HasMaxLength(100);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        this.Property(t => t.StatusCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ProcessTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CheckTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.Complain)
            .HasMaxLength(1000);
        
        this.Property(t => t.DocLevelCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MEyeImage");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.ImageCode).HasColumnName("ImageCode");
        this.Property(t => t.AutoUpload).HasColumnName("AutoUpload");
        this.Property(t => t.DistinguishCD).HasColumnName("DistinguishCD");
        this.Property(t => t.IDCard).HasColumnName("IDCard");
        this.Property(t => t.PatientNM).HasColumnName("PatientNM");
        this.Property(t => t.Age).HasColumnName("Age");
        this.Property(t => t.SexCD).HasColumnName("SexCD");
        this.Property(t => t.RecordDoctorNM).HasColumnName("RecordDoctorNM");
        this.Property(t => t.PrescriptionDoctorID).HasColumnName("PrescriptionDoctorID");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.IntraOcularTensionLeft).HasColumnName("IntraOcularTensionLeft");
        this.Property(t => t.BloodSugar).HasColumnName("BloodSugar");
        this.Property(t => t.Weight).HasColumnName("Weight");
        this.Property(t => t.Email).HasColumnName("Email");
        this.Property(t => t.Phone).HasColumnName("Phone");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.IntraOcularTensionRight).HasColumnName("IntraOcularTensionRight");
        this.Property(t => t.VisionLeft).HasColumnName("VisionLeft");
        this.Property(t => t.VisionRight).HasColumnName("VisionRight");
        this.Property(t => t.CorrectedVisionLeft).HasColumnName("CorrectedVisionLeft");
        this.Property(t => t.CorrectedVisionRight).HasColumnName("CorrectedVisionRight");
        this.Property(t => t.StatusCD).HasColumnName("StatusCD");
        this.Property(t => t.UploadTime).HasColumnName("UploadTime");
        this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
        this.Property(t => t.HosCameraID).HasColumnName("HosCameraID");
        this.Property(t => t.IsPrinted).HasColumnName("IsPrinted");
        this.Property(t => t.ReturnDoc).HasColumnName("ReturnDoc");
        this.Property(t => t.ProcessTypeCD).HasColumnName("ProcessTypeCD");
        this.Property(t => t.CheckTypeCD).HasColumnName("CheckTypeCD");
        this.Property(t => t.Complain).HasColumnName("Complain");
        this.Property(t => t.PatientID).HasColumnName("PatientID");
        this.Property(t => t.DocLevelCD).HasColumnName("DocLevelCD");
        this.Property(t => t.PPBloodSugar).HasColumnName("PPBloodSugar");
        this.Property(t => t.IsReception).HasColumnName("IsReception");
        
         //外键关系
        this.HasOptional(t => t.CheckTypeCD_FK)
            .WithMany(t => t.MEyeImage_CheckTypeCDList)
            .HasForeignKey(d => d.CheckTypeCD);
        this.HasOptional(t => t.PrescriptionDoctorID_FK)
            .WithMany(t => t.MEyeImage_PrescriptionDoctorIDList)
            .HasForeignKey(d => d.PrescriptionDoctorID);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MEyeImage_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.DistinguishCD_FK)
            .WithMany(t => t.MEyeImage_DistinguishCDList)
            .HasForeignKey(d => d.DistinguishCD);
        this.HasOptional(t => t.StatusCD_FK)
            .WithMany(t => t.MEyeImage_StatusCDList)
            .HasForeignKey(d => d.StatusCD);
        this.HasOptional(t => t.SexCD_FK)
            .WithMany(t => t.MEyeImage_SexCDList)
            .HasForeignKey(d => d.SexCD);
        this.HasOptional(t => t.PatientID_FK)
            .WithMany(t => t.MEyeImage_PatientIDList)
            .HasForeignKey(d => d.PatientID);
        this.HasOptional(t => t.UploadUserID_FK)
            .WithMany(t => t.MEyeImage_UploadUserIDList)
            .HasForeignKey(d => d.UploadUserID);
        this.HasOptional(t => t.DocLevelCD_FK)
            .WithMany(t => t.MEyeImage_DocLevelCDList)
            .HasForeignKey(d => d.DocLevelCD);
        this.HasOptional(t => t.HosCameraID_FK)
            .WithMany(t => t.MEyeImage_HosCameraIDList)
            .HasForeignKey(d => d.HosCameraID);
        this.HasOptional(t => t.ProcessTypeCD_FK)
            .WithMany(t => t.MEyeImage_ProcessTypeCDList)
            .HasForeignKey(d => d.ProcessTypeCD);
      }
    }
}

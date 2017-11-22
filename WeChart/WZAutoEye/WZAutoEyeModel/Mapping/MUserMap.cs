using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 用户表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MUserMap : EntityTypeConfiguration<MUser>
    {
      public MUserMap()
      {
        //主键
        this.HasKey(t => t.UserID);
        
        //属性
        
        this.Property(t => t.UserName)
            .HasMaxLength(100);
        
        this.Property(t => t.SexCD)
            .HasMaxLength(64);
        
        this.Property(t => t.IDCard)
            .HasMaxLength(100);
        
        this.Property(t => t.Phone)
            .HasMaxLength(100);
        
        this.Property(t => t.Email)
            .HasMaxLength(100);
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.InputHospitalNM)
            .HasMaxLength(100);
        
        this.Property(t => t.OfficeCD)
            .HasMaxLength(32);
        
        this.Property(t => t.InputOfficeNM)
            .HasMaxLength(100);
        
        this.Property(t => t.JobTitleCD)
            .HasMaxLength(64);
        
        this.Property(t => t.EducationCD)
            .HasMaxLength(64);
        
        this.Property(t => t.Speciality)
            .HasMaxLength(100);
        
        this.Property(t => t.PhotoURL)
            .HasMaxLength(255);
        
        this.Property(t => t.LoginID)
            .HasMaxLength(32);
        
        this.Property(t => t.Passwd)
            .HasMaxLength(128);
        
        this.Property(t => t.SignatureURL)
            .HasMaxLength(255);
        
        this.Property(t => t.UserTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.FirstName)
            .HasMaxLength(100);
        
        this.Property(t => t.MobilePhone)
            .HasMaxLength(100);
        
        this.Property(t => t.ReadTypeCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MUser");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.UserName).HasColumnName("UserName");
        this.Property(t => t.SexCD).HasColumnName("SexCD");
        this.Property(t => t.IDCard).HasColumnName("IDCard");
        this.Property(t => t.Birthday).HasColumnName("Birthday");
        this.Property(t => t.Phone).HasColumnName("Phone");
        this.Property(t => t.Email).HasColumnName("Email");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.InputHospitalNM).HasColumnName("InputHospitalNM");
        this.Property(t => t.OfficeCD).HasColumnName("OfficeCD");
        this.Property(t => t.InputOfficeNM).HasColumnName("InputOfficeNM");
        this.Property(t => t.WorkPeriod).HasColumnName("WorkPeriod");
        this.Property(t => t.JobTitleCD).HasColumnName("JobTitleCD");
        this.Property(t => t.EducationCD).HasColumnName("EducationCD");
        this.Property(t => t.Speciality).HasColumnName("Speciality");
        this.Property(t => t.PhotoURL).HasColumnName("PhotoURL");
        this.Property(t => t.LoginID).HasColumnName("LoginID");
        this.Property(t => t.Passwd).HasColumnName("Passwd");
        this.Property(t => t.SignatureURL).HasColumnName("SignatureURL");
        this.Property(t => t.CanLogin).HasColumnName("CanLogin");
        this.Property(t => t.UserTypeCD).HasColumnName("UserTypeCD");
        this.Property(t => t.FirstName).HasColumnName("FirstName");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.DocReturnCount).HasColumnName("DocReturnCount");
        this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
        this.Property(t => t.ReadTypeCD).HasColumnName("ReadTypeCD");
        
         //外键关系
        this.HasOptional(t => t.SexCD_FK)
            .WithMany(t => t.MUser_SexCDList)
            .HasForeignKey(d => d.SexCD);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.MUser_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.OfficeCD_FK)
            .WithMany(t => t.MUser_OfficeCDList)
            .HasForeignKey(d => d.OfficeCD);
        this.HasOptional(t => t.UserTypeCD_FK)
            .WithMany(t => t.MUser_UserTypeCDList)
            .HasForeignKey(d => d.UserTypeCD);
        this.HasOptional(t => t.JobTitleCD_FK)
            .WithMany(t => t.MUser_JobTitleCDList)
            .HasForeignKey(d => d.JobTitleCD);
        this.HasOptional(t => t.EducationCD_FK)
            .WithMany(t => t.MUser_EducationCDList)
            .HasForeignKey(d => d.EducationCD);
        this.HasOptional(t => t.ReadTypeCD_FK)
            .WithMany(t => t.MUser_ReadTypeCDList)
            .HasForeignKey(d => d.ReadTypeCD);
      }
    }
}

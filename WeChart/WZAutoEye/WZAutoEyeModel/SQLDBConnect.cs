using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WZAutoEye.WZAutoEyeMVC.Model.Mapping;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 模块名称: Oracle连接文件
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年05月05日
    /// 生成模板: CTSR.Template.OracleDAL.SQLDBConnect_01 版
    ///           MVC模式
    /// 特别说明: 本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    public class SQLDBConnect : DbContext
    {
        static SQLDBConnect()
        {
            Database.SetInitializer<SQLDBConnect>(null);
        }

        public SQLDBConnect()
            : base("Name=SQLDBConnect")
        {
        }

        public DbSet<EAbandonHis> EAbandonHiss { get; set; }
        public DbSet<EAutoReadREC> EAutoReadRECs { get; set; }
        public DbSet<EDocBaseInfo> EDocBaseInfos { get; set; }
        public DbSet<EDocDuty> EDocDutys { get; set; }
        public DbSet<EDocSettleBatch> EDocSettleBatchs { get; set; }
        public DbSet<EDocSettleDTL> EDocSettleDTLs { get; set; }
        public DbSet<EDocSettleHDR> EDocSettleHDRs { get; set; }
        public DbSet<EExamDoc> EExamDocs { get; set; }
        public DbSet<EEyeImageAttachmentHis> EEyeImageAttachmentHiss { get; set; }
        public DbSet<EEyeImageBleedingHis> EEyeImageBleedingHiss { get; set; }
        public DbSet<EGlaucomaReadREC> EGlaucomaReadRECs { get; set; }
        public DbSet<EHosCardInfo> EHosCardInfos { get; set; }
        public DbSet<EHosSettleBatch> EHosSettleBatchs { get; set; }
        public DbSet<EHosSettleDTL> EHosSettleDTLs { get; set; }
        public DbSet<EHosSettleHDR> EHosSettleHDRs { get; set; }
        public DbSet<EManualReadREC> EManualReadRECs { get; set; }
        public DbSet<ENotice> ENotices { get; set; }
        public DbSet<EReadedImgREC> EReadedImgRECs { get; set; }
        public DbSet<EReportFeedback> EReportFeedbacks { get; set; }
        public DbSet<MAddress> MAddresss { get; set; }
        public DbSet<MAdminCardInfo> MAdminCardInfos { get; set; }
        public DbSet<MAttachment> MAttachments { get; set; }
        public DbSet<MCamera> MCameras { get; set; }
        public DbSet<MCodeTable> MCodeTables { get; set; }
        public DbSet<MDocHos> MDocHoss { get; set; }
        public DbSet<MExamDocAttachment> MExamDocAttachments { get; set; }
        public DbSet<MExamDocBleeding> MExamDocBleedings { get; set; }
        public DbSet<MEyeImage> MEyeImages { get; set; }
        public DbSet<MEyeImageAttachment> MEyeImageAttachments { get; set; }
        public DbSet<MEyeImageBleeding> MEyeImageBleedings { get; set; }
        public DbSet<MHosCamera> MHosCameras { get; set; }
        public DbSet<MHosConfig> MHosConfigs { get; set; }
        public DbSet<MHospital> MHospitals { get; set; }
        public DbSet<MLoginLog> MLoginLogs { get; set; }
        public DbSet<MMenu> MMenus { get; set; }
        public DbSet<MMessageInfo> MMessageInfos { get; set; }
        public DbSet<MOffice> MOffices { get; set; }
        public DbSet<MOperationHistory> MOperationHistorys { get; set; }
        public DbSet<MPatient> MPatients { get; set; }
        public DbSet<MPort> MPorts { get; set; }
        public DbSet<MPrescriptionDoctor> MPrescriptionDoctors { get; set; }
        public DbSet<MRole> MRoles { get; set; }
        public DbSet<MRoleMenu> MRoleMenus { get; set; }
        public DbSet<MSystemConfig> MSystemConfigs { get; set; }
        public DbSet<MUser> MUsers { get; set; }
        public DbSet<MUserDocLevel> MUserDocLevels { get; set; }
        public DbSet<MUserRole> MUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EAbandonHisMap());
            modelBuilder.Configurations.Add(new EAutoReadRECMap());
            modelBuilder.Configurations.Add(new EDocBaseInfoMap());
            modelBuilder.Configurations.Add(new EDocDutyMap());
            modelBuilder.Configurations.Add(new EDocSettleBatchMap());
            modelBuilder.Configurations.Add(new EDocSettleDTLMap());
            modelBuilder.Configurations.Add(new EDocSettleHDRMap());
            modelBuilder.Configurations.Add(new EExamDocMap());
            modelBuilder.Configurations.Add(new EEyeImageAttachmentHisMap());
            modelBuilder.Configurations.Add(new EEyeImageBleedingHisMap());
            modelBuilder.Configurations.Add(new EGlaucomaReadRECMap());
            modelBuilder.Configurations.Add(new EHosCardInfoMap());
            modelBuilder.Configurations.Add(new EHosSettleBatchMap());
            modelBuilder.Configurations.Add(new EHosSettleDTLMap());
            modelBuilder.Configurations.Add(new EHosSettleHDRMap());
            modelBuilder.Configurations.Add(new EManualReadRECMap());
            modelBuilder.Configurations.Add(new ENoticeMap());
            modelBuilder.Configurations.Add(new EReadedImgRECMap());
            modelBuilder.Configurations.Add(new EReportFeedbackMap());
            modelBuilder.Configurations.Add(new MAddressMap());
            modelBuilder.Configurations.Add(new MAdminCardInfoMap());
            modelBuilder.Configurations.Add(new MAttachmentMap());
            modelBuilder.Configurations.Add(new MCameraMap());
            modelBuilder.Configurations.Add(new MCodeTableMap());
            modelBuilder.Configurations.Add(new MDocHosMap());
            modelBuilder.Configurations.Add(new MExamDocAttachmentMap());
            modelBuilder.Configurations.Add(new MExamDocBleedingMap());
            modelBuilder.Configurations.Add(new MEyeImageMap());
            modelBuilder.Configurations.Add(new MEyeImageAttachmentMap());
            modelBuilder.Configurations.Add(new MEyeImageBleedingMap());
            modelBuilder.Configurations.Add(new MHosCameraMap());
            modelBuilder.Configurations.Add(new MHosConfigMap());
            modelBuilder.Configurations.Add(new MHospitalMap());
            modelBuilder.Configurations.Add(new MLoginLogMap());
            modelBuilder.Configurations.Add(new MMenuMap());
            modelBuilder.Configurations.Add(new MMessageInfoMap());
            modelBuilder.Configurations.Add(new MOfficeMap());
            modelBuilder.Configurations.Add(new MOperationHistoryMap());
            modelBuilder.Configurations.Add(new MPatientMap());
            modelBuilder.Configurations.Add(new MPortMap());
            modelBuilder.Configurations.Add(new MPrescriptionDoctorMap());
            modelBuilder.Configurations.Add(new MRoleMap());
            modelBuilder.Configurations.Add(new MRoleMenuMap());
            modelBuilder.Configurations.Add(new MSystemConfigMap());
            modelBuilder.Configurations.Add(new MUserMap());
            modelBuilder.Configurations.Add(new MUserDocLevelMap());
            modelBuilder.Configurations.Add(new MUserRoleMap());
        }
    }
}

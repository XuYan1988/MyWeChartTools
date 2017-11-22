using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �¶ȼƻ�����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EMonthPlanMap : EntityTypeConfiguration<EMonthPlan>
    {
      public EMonthPlanMap()
      {
        //����
        this.HasKey(t => t.MonthPlanID);
        
        //����
        
        this.Property(t => t.AddressCD)
            .HasMaxLength(5);
        
        this.Property(t => t.HospitalCD)
            .HasMaxLength(32);
        
        this.Property(t => t.PlanTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.PlanYear)
            .HasMaxLength(4);
        
        this.Property(t => t.PlanMonth)
            .HasMaxLength(2);
        
        //�����еĶ�Ӧ
        this.ToTable("EMonthPlan");
        this.Property(t => t.MonthPlanID).HasColumnName("MonthPlanID");
        this.Property(t => t.AddressCD).HasColumnName("AddressCD");
        this.Property(t => t.HospitalCD).HasColumnName("HospitalCD");
        this.Property(t => t.PlanTypeCD).HasColumnName("PlanTypeCD");
        this.Property(t => t.PlanYear).HasColumnName("PlanYear");
        this.Property(t => t.PlanMonth).HasColumnName("PlanMonth");
        this.Property(t => t.PlanQuantity).HasColumnName("PlanQuantity");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.AddressCD_FK)
            .WithMany(t => t.EMonthPlan_AddressCDList)
            .HasForeignKey(d => d.AddressCD);
        this.HasOptional(t => t.HospitalCD_FK)
            .WithMany(t => t.EMonthPlan_HospitalCDList)
            .HasForeignKey(d => d.HospitalCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EMonthPlan_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EMonthPlan_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.PlanTypeCD_FK)
            .WithMany(t => t.EMonthPlan_PlanTypeCDList)
            .HasForeignKey(d => d.PlanTypeCD);
      }
    }
}

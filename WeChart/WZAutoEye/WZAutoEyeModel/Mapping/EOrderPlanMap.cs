using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: �´�ƻ���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EOrderPlanMap : EntityTypeConfiguration<EOrderPlan>
    {
      public EOrderPlanMap()
      {
        //����
        this.HasKey(t => t.OrderPlanID);
        
        //����
        
        this.Property(t => t.RegionCD)
            .HasMaxLength(64);
        
        this.Property(t => t.PlanYear)
            .HasMaxLength(4);
        
        this.Property(t => t.PlanMonth)
            .HasMaxLength(2);
        
        //�����еĶ�Ӧ
        this.ToTable("EOrderPlan");
        this.Property(t => t.OrderPlanID).HasColumnName("OrderPlanID");
        this.Property(t => t.RegionCD).HasColumnName("RegionCD");
        this.Property(t => t.PlanYear).HasColumnName("PlanYear");
        this.Property(t => t.PlanMonth).HasColumnName("PlanMonth");
        this.Property(t => t.ScreenQuantity).HasColumnName("ScreenQuantity");
        this.Property(t => t.DevelopQuantity).HasColumnName("DevelopQuantity");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.RegionCD_FK)
            .WithMany(t => t.EOrderPlan_RegionCDList)
            .HasForeignKey(d => d.RegionCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EOrderPlan_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EOrderPlan_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ��¼��־����¼��¼�ߣ���¼ʱ�䣬��¼�����˳���Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MLoginLogMap : EntityTypeConfiguration<MLoginLog>
    {
      public MLoginLogMap()
      {
        //����
        this.HasKey(t => t.LoginLogID);
        
        //����
        
        this.Property(t => t.LoginType)
            .HasMaxLength(64);
        
        this.Property(t => t.PortCD)
            .HasMaxLength(32);
        
        //�����еĶ�Ӧ
        this.ToTable("MLoginLog");
        this.Property(t => t.LoginLogID).HasColumnName("LoginLogID");
        this.Property(t => t.UserID).HasColumnName("UserID");
        this.Property(t => t.LoginType).HasColumnName("LoginType");
        this.Property(t => t.LoginTime).HasColumnName("LoginTime");
        this.Property(t => t.PortCD).HasColumnName("PortCD");
        
         //�����ϵ
        this.HasOptional(t => t.UserID_FK)
            .WithMany(t => t.MLoginLog_UserIDList)
            .HasForeignKey(d => d.UserID);
        this.HasOptional(t => t.PortCD_FK)
            .WithMany(t => t.MLoginLog_PortCDList)
            .HasForeignKey(d => d.PortCD);
        this.HasOptional(t => t.LoginType_FK)
            .WithMany(t => t.MLoginLog_LoginTypeList)
            .HasForeignKey(d => d.LoginType);
      }
    }
}

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ������Ա��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MSalesmanMap : EntityTypeConfiguration<MSalesman>
    {
      public MSalesmanMap()
      {
        //����
        this.HasKey(t => t.SalesmanID);
        
        //����
        
        this.Property(t => t.SalesmanNM)
            .HasMaxLength(64);
        
        this.Property(t => t.SalesmanLevelCD)
            .HasMaxLength(64);
        
        this.Property(t => t.SexCD)
            .HasMaxLength(64);
        
        this.Property(t => t.IDCard)
            .HasMaxLength(100);
        
        this.Property(t => t.Phone)
            .HasMaxLength(100);
        
        this.Property(t => t.Email)
            .HasMaxLength(100);
        
        this.Property(t => t.MobilePhone)
            .HasMaxLength(100);
        
        this.Property(t => t.EducationCD)
            .HasMaxLength(64);
        
        this.Property(t => t.PhotoURL)
            .HasMaxLength(255);
        
        this.Property(t => t.LoginID)
            .HasMaxLength(32);
        
        this.Property(t => t.Passwd)
            .HasMaxLength(128);
        
        this.Property(t => t.SignatureURL)
            .HasMaxLength(255);
        
        //�����еĶ�Ӧ
        this.ToTable("MSalesman");
        this.Property(t => t.SalesmanID).HasColumnName("SalesmanID");
        this.Property(t => t.SalesmanNM).HasColumnName("SalesmanNM");
        this.Property(t => t.SalesmanLevelCD).HasColumnName("SalesmanLevelCD");
        this.Property(t => t.PSalesmanID).HasColumnName("PSalesmanID");
        this.Property(t => t.SexCD).HasColumnName("SexCD");
        this.Property(t => t.IDCard).HasColumnName("IDCard");
        this.Property(t => t.Birthday).HasColumnName("Birthday");
        this.Property(t => t.Phone).HasColumnName("Phone");
        this.Property(t => t.Email).HasColumnName("Email");
        this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
        this.Property(t => t.EducationCD).HasColumnName("EducationCD");
        this.Property(t => t.PhotoURL).HasColumnName("PhotoURL");
        this.Property(t => t.LoginID).HasColumnName("LoginID");
        this.Property(t => t.Passwd).HasColumnName("Passwd");
        this.Property(t => t.SignatureURL).HasColumnName("SignatureURL");
        this.Property(t => t.CanLogin).HasColumnName("CanLogin");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.MSalesman_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.MSalesman_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

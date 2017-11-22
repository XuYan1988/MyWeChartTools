using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�㿨��Ϣ������Ա����ϵͳ����Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class MAdminCardInfoMap : EntityTypeConfiguration<MAdminCardInfo>
    {
      public MAdminCardInfoMap()
      {
        //����
        this.HasKey(t => t.AdminCardInfoID);
        
        //����
        
        this.Property(t => t.CardNo)
            .HasMaxLength(100);
        
        this.Property(t => t.CardPassword)
            .HasMaxLength(128);
        
        //�����еĶ�Ӧ
        this.ToTable("MAdminCardInfo");
        this.Property(t => t.AdminCardInfoID).HasColumnName("AdminCardInfoID");
        this.Property(t => t.CardNo).HasColumnName("CardNo");
        this.Property(t => t.CardNum).HasColumnName("CardNum");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.CardPassword).HasColumnName("CardPassword");
        
      }
    }
}

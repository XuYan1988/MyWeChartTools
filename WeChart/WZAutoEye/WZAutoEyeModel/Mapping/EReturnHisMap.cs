using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// �ļ�˵��: ҽ���˻ؼ�¼��Ϣʵ��ӳ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �޸�˵����
    /// </summary>
    public class EReturnHisMap : EntityTypeConfiguration<EReturnHis>
    {
      public EReturnHisMap()
      {
        //����
        this.HasKey(t => t.ReturnHisID);
        
        //����
        
        this.Property(t => t.DocLevelCD)
            .HasMaxLength(64);
        
        //�����еĶ�Ӧ
        this.ToTable("EReturnHis");
        this.Property(t => t.ReturnHisID).HasColumnName("ReturnHisID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.ReturnUserID).HasColumnName("ReturnUserID");
        this.Property(t => t.Readed).HasColumnName("Readed");
        this.Property(t => t.DocLevelCD).HasColumnName("DocLevelCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //�����ϵ
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EReturnHis_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.ReturnUserID_FK)
            .WithMany(t => t.EReturnHis_ReturnUserIDList)
            .HasForeignKey(d => d.ReturnUserID);
        this.HasOptional(t => t.DocLevelCD_FK)
            .WithMany(t => t.EReturnHis_DocLevelCDList)
            .HasForeignKey(d => d.DocLevelCD);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EReturnHis_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EReturnHis_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PictureDownload
{
    public partial class PictureForm : Form
    {
        string path = System.Configuration.ConfigurationManager.AppSettings["FileUrl"].ToString();
        string EyePic = System.Configuration.ConfigurationManager.AppSettings["EyePic"].ToString();
        DataSet ds = new DataSet();
        int timecount = 0;
         public PictureForm()
        {
            InitializeComponent();
        }
         Stopwatch stop;
         public static long presize = 0;
        private void PictureForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.cmb_DowUrl.Items.Add("EyePic/医院CD/时间");
            this.cmb_DowUrl.SelectedIndex = 1;
        }
        /// <summary>
        /// 选择保存的路径
        /// </summary>
        /// 2016-10-14 zzc
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();//选择目录
            path.ShowDialog();
            this.txtPath.Text = path.SelectedPath;//赋值给路径文本框
        }
        /// <summary>
        /// 开始整合图片
        /// </summary>
        /// 2016-10-14 zzc
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            stop = new Stopwatch();
            stop.Start(); //计时

            string DownloadUrl = this.txtPath.Text.ToString();//保存路径
            string start_Time = this.start_Time.Value.ToString("yyyy-MM-dd");//开始时间
            string end_Time = this.end_Time.Value.ToString("yyyy-MM-dd");//结束时间
            string rs = this.cmb_rs.SelectedItem == null ? "" : this.cmb_rs.SelectedItem.ToString();//结论
            string pt = this.cmb_ptCD.SelectedItem == null ? "" : this.cmb_ptCD.SelectedItem.ToString();//片源类型
            string su = this.cmb_Sugg.SelectedItem == null ? "" : this.cmb_Sugg.SelectedItem.ToString();//印象
            string num = this.cmb_Num.SelectedItem == null ? "" : this.cmb_Num.SelectedItem.ToString();//条数
            string DowUrl = this.cmb_DowUrl.SelectedItem == null ? "" : this.cmb_DowUrl.SelectedItem.ToString();//下载路径规则
            string strRSsql = "";
            if ("定期随访，一年复查眼底像。".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-1' ";
            }
            else if ("转眼科进一步检查，确诊。".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-2' ";
            }
            else if ("双眼屈光介质混浊，眼底看不清，建议眼科会诊明确诊断。".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-3' ";
            }else if("定期随访，三个月复查眼底像。".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-4' ";
            }
            else if ("定期随访，六个月复查眼底像。".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-5' ";
            }
            else if ("其它".Equals(rs))
            {
                strRSsql = @" join EManualReadREC 
                     on MEyeImage.EyeImageID = EManualReadREC.EyeImageID 
                     and EManualReadREC.ImpressionCD = 'Impression-6' ";
            }
            string strPTsql="";
            if("人工流程".Equals(pt))
            {
                strPTsql=@" and MEyeImage.ProcessTypeCD='ProcessType-1' ";
            }else if("自动流程".Equals(pt))
            {
                strPTsql=@" and MEyeImage.ProcessTypeCD='ProcessType-2' ";
            }
            string strSUsql = "";
            if ("可见出血或渗出，定期随访复查眼底像。".Equals(su))
            {
                strSUsql = @" Join EAutoReadREC on MEyeImage.EyeImageID=EAutoReadREC.EyeImageID and EAutoReadREC.Suggestion like '可见出血或渗出，定期随访复查眼底像。' ";
            }
            else if ("可见明显出血或渗出，建议眼科检查，确诊。".Equals(su))
            {
                strSUsql = @" Join EAutoReadREC on MEyeImage.EyeImageID=EAutoReadREC.EyeImageID and EAutoReadREC.Suggestion like '可见明显出血或渗出，建议眼科检查，确诊。' ";
            }
            else if("未见明显异常，定期随访复查眼底像。".Equals(su))
            {
                strSUsql = @" Join EAutoReadREC on MEyeImage.EyeImageID=EAutoReadREC.EyeImageID and EAutoReadREC.Suggestion like '未见明显异常，定期随访复查眼底像。' ";
            }
            else if("未见明显出血或渗出，定期随访复查眼底像。".Equals(su))
            {
                strSUsql = @" Join EAutoReadREC on MEyeImage.EyeImageID=EAutoReadREC.EyeImageID and EAutoReadREC.Suggestion like '未见明显出血或渗出，定期随访复查眼底像。' ";
            }
            string strNumSql = "";
            if("5".Equals(num))
            {
                strNumSql = @" top 5 ";
            }
            if("10".Equals(num))
            {
                strNumSql = @" top 10 ";
            }else if("30".Equals(num))
            {
                strNumSql = @" top 30 ";
            }else if("50".Equals(num))
            {
                strNumSql = @" top 50 ";
            }else if("100".Equals(num))
            {
                strNumSql = @" top 100 ";
            }else if("130".Equals(num))
            {
                strNumSql = @" top 130 ";
            }else if("150".Equals(num))
            {
                strNumSql = @" top 150 ";
            }else if("200".Equals(num))
            {
                strNumSql = @" top 200 ";
            }
            if(!string.IsNullOrEmpty(this.cum_Sugg2.Text.Trim()))
            {
                strSUsql = @" Join EAutoReadREC on MEyeImage.EyeImageID=EAutoReadREC.EyeImageID and EAutoReadREC.Suggestion like '%" + this.cum_Sugg2.Text.Trim() + "%' ";
            }
            string strHossql = "";
            if(!string.IsNullOrEmpty(this.cmb_HosName.Text.Trim()))
            {
                string[] HosCD = this.cmb_HosName.Text.Trim().Split(',');
                string HosName = "";
                for (int i = 0; i < HosCD.Length;i++ )
                {
                    HosName += "'"+HosCD[i]+"'" + ",";
                }
                strHossql = @" and MEyeImage.HospitalCD in (" + HosName.Substring(0,HosName.Length-1) + ")";
            }
            string strPatientNM = "";
            if(!string.IsNullOrEmpty(this.cum_UserName.Text.Trim()))
            {
                strPatientNM = @" and MEyeImage.PatientNM like '%" + this.cum_UserName.Text.Trim() + "%' ";
            }
            string strAge = "";
            if(!string.IsNullOrEmpty(this.cum_age.Text.Trim()))
            {
                strAge = @" and MEyeImage.Age ='" + this.cum_age.Text.Trim() + "'";
            }
            string UploadEI = "";
            if (radio_InDR.Checked==true)
            {
                UploadEI = "'ManualUpload_LeftEye','ManualUpload_RightEye','AutoUpload_LeftEye','AutoUpload_RightEye','MatlabCommon_LeftEye','MatlabCommon_RightEye'";
            }
            if(radio_NotDR.Checked==true)
            {
                UploadEI = "'ManualUpload_LeftEye','ManualUpload_RightEye','AutoUpload_LeftEye','AutoUpload_RightEye'";
            }
            string strRemark = "";
            if(!string.IsNullOrEmpty(this.text_Remark.Text.Trim()))
            {
                strRemark = " AND MEyeImage.Remark like '%" + this.text_Remark.Text.Trim() + "%'";
            }
            if (DownloadUrl == "")//判断路径是否已选择
            {
                MessageBox.Show("请选择要保存的路径！", "提示信息");
            }
            else
            {
                string sqlstr = "select " + strNumSql + " CONVERT(varchar(100), MEyeImage.UploadTime, 23) as TimeN, MHospital.HospitalCD, " +
                    "MHospital.HospitalName + '-' + PatientNM + '-' + (case WHEN  MEyeImageAttachment.EITypeCD in ('ManualUpload_LeftEye'," +
                    "'AutoUpload_LeftEye') then '左' when MEyeImageAttachment.EITypeCD in ('ManualUpload_RightEye','AutoUpload_RightEye') " +
                    "then '右' when MEyeImageAttachment.EITypeCD in ('ManualUpload_Indeterminacy','AutoUpload_Indeterminacy') then '1' end) + '-'+ MCodeTable.CodeDesc + '-'" +
                    " + CONVERT(nvarchar(3), Age) as PicName,EIAttachmentPath,MEyeImage.EyeImageID,MEyeImage.PatientNM,MEyeImageAttachment.EITypeCD " +
                    "from  MEyeImage " +
                    "join MHospital on MHospital.HospitalCD = MEyeImage.HospitalCD " +
                    "join MCodeTable on MCodeTable.CodeTableCD = MEyeImage.SexCD	" +
                    //建议=Impression-2：转眼科进一步检查，确诊。 Start
                    strRSsql +
                    //建议=Impression-2：转眼科进一步检查，确诊。 End
                    strSUsql +
                    "join MEyeImageAttachment " +
                    "on MEyeImageAttachment.EyeImageID = MEyeImage.EyeImageID where MEyeImage.UploadTime >= '" + start_Time + "' " +
                    "and MEyeImage.UploadTime <= DATEADD (day , 1, '" + end_Time + "') and MEyeImageAttachment.EITypeCD in " +
                    "(" + UploadEI + ")" + strPTsql + " and MEyeImage.HospitalCD not like '%ceshi%' and MEyeImage.HospitalCD not like '%zzc%' and MHospital.HospitalName not like '%测试%' and MEyeImage.ImageCode not like 'TAD%' and MEyeImage.ImageCode not like 'TAS%' " + strHossql + " " + strPatientNM + "" + strAge + strRemark + " order by MEyeImage.HospitalCD,TimeN ";

                if(this.radio_IsDiscard.Checked==true)
                {
                    sqlstr = @" select CONVERT(varchar(100), MEyeImage.UploadTime, 23) as TimeN,MEyeImage.HospitalCD,MEyeImage.PatientNM,MEyeImageAttachment.EIAttachmentPath,MEyeImageAttachment.EITypeCD,MEyeImage.EyeImageID from MEyeImageAttachment join MEyeImage on MEyeImageAttachment.EyeImageID=MEyeImage.EyeImageID where MEyeImageAttachment.EyeImageID in 
(select EyeImageID from MEyeImageAttachment 
where EITypeCD in('AutoUpload_RightEye','AutoUpload_LeftEye','ManualUpload_RightEye','ManualUpload_LeftEye','MatlabCommon_RightEye','MatlabCommon_LeftEye') 
and EIAttachmentPath not like '%_DR%'
group by EyeImageID,EIAttachmentPath 
having count(EIAttachmentPath) = 2)
and EITypeCD in('AutoUpload_RightEye','AutoUpload_LeftEye','ManualUpload_RightEye','ManualUpload_LeftEye','MatlabCommon_RightEye','MatlabCommon_LeftEye') 
and MEyeImage.HospitalCD not like '%ceshi%' and MEyeImage.HospitalCD not like '%zzc%' and MHospital.HospitalName not like '%测试%' and MEyeImage.ImageCode not like 'TAD%' and MEyeImage.ImageCode not like 'TAS%' '"+strRemark+"' order by MEyeImage.HospitalCD,TimeN,PatientNM";
                }

                ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlstr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                        this.start.Enabled = false;
                        
                        this.textBox1.Text = "准备阶段.." + Environment.NewLine + Environment.NewLine;
                        this.textBox1.Text = textBox1.Text + "开始整合"+ Environment.NewLine + Environment.NewLine;
                        this.textBox1.Text = this.textBox1.Text + "已经整合：" + Environment.NewLine + Environment.NewLine;
                    Thread td = new Thread(new ThreadStart(() =>
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            string FileUpload = ds.Tables[0].Rows[i][3].ToString();
                            FileUpload = FileUpload.Substring(FileUpload.LastIndexOf("~")+1);

                            if (radio_IsDiscard.Checked == true)
                            {
                                #region 下载舍弃图
                                //判断当前是否为标注图
                                if (ds.Tables[0].Rows[i][4].ToString() == "MatlabCommon_LeftEye" || ds.Tables[0].Rows[i][4].ToString() == "MatlabCommon_RightEye")
                                {

                                    DataSet dst = new DataSet();
                                    string sqlstrs = "";
                                    string EITypeCD = ds.Tables[0].Rows[i][4].ToString();
                                    if (EITypeCD.Substring(EITypeCD.LastIndexOf("_") + 1) == "LeftEye")
                                    {
                                        //根据标注图查询对应原图
                                        sqlstrs = @" select EIAttachmentPath 
from MEyeImageAttachment 
where EyeImageID='" + ds.Tables[0].Rows[i][5].ToString() + "' and EITypeCD in('ManualUpload_LeftEye','AutoUpload_LeftEye') ";
                                        dst = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlstrs);
                                        //判断标注图和原图是否相等，若相等则加_DR
                                        if (dst.Tables[0].Rows[0][0].ToString() == ds.Tables[0].Rows[i][3].ToString())
                                        {
                                            string[] Image = FileUpload.Split('.');

                                            FileUpload = Image[0] + "_DR" + "." + Image[1];
                                        }

                                    }
                                    if (EITypeCD.Substring(EITypeCD.LastIndexOf("_") + 1) == "RightEye")
                                    {
                                        //根据标注图查询对应原图
                                        sqlstrs = @" select EIAttachmentPath 
from MEyeImageAttachment 
where EyeImageID='" + ds.Tables[0].Rows[i][5].ToString() + "' and EITypeCD in('ManualUpload_RightEye','AutoUpload_RightEye') ";
                                        dst = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlstrs);
                                        //判断标注图和原图是否相等，若相等则加_DR
                                        if (dst.Tables[0].Rows[0][0].ToString() == ds.Tables[0].Rows[i][3].ToString())
                                        {
                                            string[] Image = FileUpload.Split('.');

                                            FileUpload = Image[0] + "_DR" + "." + Image[1];
                                        }
                                    }
                                }
                                #endregion
                            }
                            string url = path + FileUpload;//下载的图片URL
                            string dir = "";
                            if("EyePic/医院CD/时间".Equals(DowUrl))
                            {
                                dir = DownloadUrl + "\\" + EyePic + "\\" + ds.Tables[0].Rows[i][1].ToString() + "\\" + ds.Tables[0].Rows[i][0].ToString().Replace("-", "");//下载后图片存放的路径
                            }
                            if ("EyePic/医院CD/时间/姓名".Equals(DowUrl))
                            {
                                dir = DownloadUrl + "\\" + EyePic + "\\" + ds.Tables[0].Rows[i][1].ToString() + "\\" + ds.Tables[0].Rows[i][0].ToString().Replace("-", "") + "\\" + ds.Tables[0].Rows[i][5].ToString();//下载后图片存放的路径
                            }
                            if ("EyePic/医院CD_姓名".Equals(DowUrl))
                            {
                                dir = DownloadUrl + "\\" + EyePic + "\\" + ds.Tables[0].Rows[i][1].ToString() + "_" + ds.Tables[0].Rows[i][5].ToString();//下载后图片存放的路径
                            }
                            if ("EyePic".Equals(DowUrl))
                            {
                                dir = DownloadUrl + "\\" + EyePic ;//下载后图片存放的路径
                            }
                            //string dir = DownloadUrl + "\\" + EyePic ;//下载后图片存放的路径
                           // + "\\" + ds.Tables[0].Rows[i][0].ToString().Replace("-", "") 

                            //Task tsk = new Task(() =>
                            //{
                                
                            //});
                            //tsk.Start();

                                DownloadUrlFile(url, dir, ds.Tables[0].Rows[i][2].ToString());//执行下载方法
                          
         
                            
                    }
                        stop.Stop();
                        this.Dow_time.Text = "耗时:" + stop.ElapsedMilliseconds.ToString();
                        this.textBox1.Text = this.textBox1.Text + "结束";
                        this.start.Enabled = true;
            }));
                                td.IsBackground = true;
                                td.Start();
                }else
                {
                    this.textBox1.Text = "未查询到相关图片！" + Environment.NewLine + Environment.NewLine;
                }
                string str = System.IO.Directory.GetCurrentDirectory();

                //System.Environment.Exit(0);
                //System.Environment.Exit(System.Environment.ExitCode);
            }
        }
        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="url">原图路径</param>
        /// <param name="dir">下载图片路径</param>
        public void DownloadUrlFile(string url,string dir,string picName)
        {
            WebClient client = new WebClient();
            string fileName = Path.GetFileName(url);  //被下载的文件名
            string path = dir + "\\" + fileName;   //另存为的绝对路径＋文件名
            try
            {
                if (!System.IO.Directory.Exists(dir))
                {
                    System.IO.Directory.CreateDirectory(dir);
                }
                if (!System.IO.File.Exists(path))
                {
                    client.DownloadFile(url, path);
                    this.textBox1.Text = this.textBox1.Text + picName + "的眼底图片" + Environment.NewLine + Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("文件下载失败或未找到图片资源！", "警告");
                InsertLog(e.Source, e.Message, DateTime.Now);
            }
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="action">原因</param>
        /// <param name="strMessage">内容</param>
        /// <param name="time">时间</param>
        private void InsertLog(string action, string strMessage, DateTime time)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"Log\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string fileFullPath = path + time.ToString("yyyy-MM-dd") + ".Web.txt";
                StreamWriter sw;
                if (File.Exists(fileFullPath))
                {
                    sw = new StreamWriter(fileFullPath, true);
                }
                else
                {
                    sw = File.CreateText(fileFullPath);
                }

                StringBuilder str = new StringBuilder();
                str.Append("Time:    " + time.ToString() + "\r\n");
                str.Append("Action:  " + action + "\r\n");
                str.Append("Message: " + strMessage + "\r\n");
                str.Append("-----------------------------------------------------------\r\n\r\n");

                sw.WriteLine(str.ToString());
                sw.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}

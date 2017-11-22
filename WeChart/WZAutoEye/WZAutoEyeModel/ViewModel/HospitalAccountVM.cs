using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class HospitalAccountVM
    {
        //创建者--张立华 2016-07-06

        //医院编码
        public string HospitalCD { get; set; }

        //医院名称
        public string HospitalName{ get; set; }

        //地址名称（国家、省、市）
        public string DistrictCollection { get; set; }

        //地址名称
        public string AddressName { get; set; }

        //检查类型
        public string CheckProcessType { get; set; }

        //阅片流程类型
        public string ReadProcessType { get; set; }

        //结算模式
        public string SettleProcessType { get; set; }

        //图像质量
        public bool ImageQualityView { get; set; }

        //镜头情况
        public bool LensSituationView { get; set; }

        //自动报告
        public bool AutoReport { get; set; }

        //省墨模式
        public bool SaveInk { get; set; }

        //报告模板
        public bool ReportTempletCD { get; set; }

        //现有点卡数
        public decimal? NowCardCount { get; set; }

        //是否可以登录
        public string CanAccess { get; set; }

        //图片数量
        public int ImageCount { get; set; }

        //医院查询开始时间
        public DateTime AddDateFrom { get; set; }

        //医院查询结束时间
        public DateTime AddDateTo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class DoctorSettlementVM
    {
        //主键
        public Guid DocSettleHID { get; set; }

        //[DisplayName("用户ID（阅片医生）")]
        public Nullable<Guid> UserID { get; set; }

        //[DisplayName("本次结算点数")]
        public Nullable<decimal> DocPoint { get; set; }

        //[DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }

        //[DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }

        //[DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }

        //[DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }

        //[DisplayName("开始日期")]
        public Nullable<DateTime> StartDate { get; set; }

        //[DisplayName("结束日期")]
        public Nullable<DateTime> EndDate { get; set; }

        //[DisplayName("总点数")]
        public Nullable<decimal> SumPoint { get; set; }

        //[DisplayName("未结点数")]
        public Nullable<decimal> NotClearPoint { get; set; }

        //[DisplayName("已结点数")]
        public Nullable<decimal> ClearPoint { get; set; }

        //医生姓名
        public string UserName { get; set; }

        //登录名
        public string LoginID { get; set; }

        //医院名
        public string HospitalName { get; set; }

        //医生电话
        public string Phone { get; set; }

        //结算区间
        public string SettlementRange { get; set; }
    }
}

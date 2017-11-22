using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 个人账户View Model 张立华 2016-07-04
    /// </summary>
    [Serializable]
    public partial class PersonalAccount
    {
        //基数
        public decimal? Cardinality { get; set; }

        //系数
        public decimal? Coefficient { get; set; }

        //总点数
        public string TotalCount { get; set; }

        //未清点数
        public string UnCheckedCount { get; set; }

        //今日点数
        public string TodayCount { get; set; }
    }
}

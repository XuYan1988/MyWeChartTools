using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class EHosSettleBatchVM
    {
        public Guid HosSettleBID { get; set; }

        public string HosSettleBNO { get; set; }

        public Nullable<int> HosCount { get; set; }

        public Nullable<decimal> HosSum { get; set; }

        public Nullable<DateTime> UpdTime { get; set; }

        public Nullable<Guid> UpdUserID { get; set; }

        public Nullable<DateTime> InsTime { get; set; }

        public Nullable<Guid> InsUserID { get; set; }

        public Nullable<DateTime> StartDate { get; set; }

        public Nullable<DateTime> EndDate { get; set; }

        public string Name { get; set; }
    }
}

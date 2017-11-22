using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class HospitalSettleListVM
    {
        public Guid HosSettleHID { get; set; }

        public string HospitalName { get; set; }

        public string HospitalCD { get; set; }

        public string CheckType { get; set; }

        public Nullable<decimal> Price { get; set; }

        public Nullable<int> Quantity { get; set; }

        public Nullable<DateTime> StartDate { get; set; }

        public Nullable<DateTime> EndDate { get; set; }

        public string Remark { get; set; }

        public Nullable<int> HosQuantity { get; set; }
    }
}

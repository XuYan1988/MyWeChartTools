using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class EDocSettleBatchVM
    {
        public Guid DocSettleBID { get; set; }

        public string DocSettleBNO { get; set; }

        public string DocCount { get; set; }

        public string DocSumPoint { get; set; }

        public string UpdTime { get; set; }

        public string UpdUserID { get; set; }

        public string InsTime { get; set; }

        public string InsUserID { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string UserName { get; set; }
    }
}

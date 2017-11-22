using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 用户身份验证View Model
    /// 2016-6-28，yel
    /// </summary>
    [Serializable]
    public partial class UserTokenVM
    {
        public Guid UserID { get; set; }

        public string UserName { get; set; }

        public string HospitalCD { get; set; }

        public string ShowName_CH { get; set; }

        public string ShowName_EN { get; set; }

        public string PortCD { get; set; }

        public string LoginID { get; set; }

        public string DocLevelCD { get; set; }

        public List<MenuVM> MenuVMList { get; set; }
    }
}

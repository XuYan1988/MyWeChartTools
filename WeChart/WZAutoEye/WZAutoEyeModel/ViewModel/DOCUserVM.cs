using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{/// <summary>
    /// 用户身份验证View Model
    /// </summary>
    [Serializable]
    public partial class DOCUserVM
    {
        public Guid UserID { get; set; }

        public string UserName { get; set; }

        public string SexCD { get; set; }

        public string Phone { get; set; }

        public string LoginID { get; set; }

        public string Email { get; set; }

        public string OfficeName { get; set; }

        public DateTime InsTime { get; set; }
        public bool CanLogin { get; set; }

    }
}

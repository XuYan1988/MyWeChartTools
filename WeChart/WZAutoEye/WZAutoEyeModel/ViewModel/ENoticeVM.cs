using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class ENoticeVM
    {
        public Guid NoticeID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Nullable<Guid> UserID { get; set; }

        public string RecipientType { get; set; }

        public Nullable<bool> IsPublic { get; set; }

        public Nullable<DateTime> ReleaseTime { get; set; }

        public Nullable<DateTime> UpdTime { get; set; }

        public Nullable<Guid> UpdUserID { get; set; }

        public Nullable<DateTime> InsTime { get; set; }

        public Nullable<Guid> InsUserID { get; set; }

        public string UserName { get; set; }

        public Nullable<DateTime> ReleaseTimeStart { get; set; }

        public Nullable<DateTime> ReleaseTimeEnd { get; set; }

        public string RecipientTypeNM { get; set; }

        public string IsPublicNM { get; set; }
    }
}

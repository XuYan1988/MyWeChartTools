using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class ReadingDoctorVM
    {
        public Guid UserID { get; set; }

        public string UserName { get; set; }

        public string SexName { get; set; }

        public Nullable<DateTime> Birthday { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string InputHospitalNM { get; set; }

        public string InputOfficeNM { get; set; }

        public string LoginID { get; set; }

        public bool CanLogin { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
     [Serializable]
    public partial class MyInfoVM
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SexCD { get; set; }

        public string IDCard { get; set; }

        public Nullable<DateTime> Birthday { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string HospitalCD { get; set; }

        public string InputHospitalNM { get; set; }

        public string OfficeCD { get; set; }

        public string InputOfficeNM { get; set; }

        public Nullable<int> WorkPeriod { get; set; }

        public string JobTitleCD { get; set; }

        public string EducationCD { get; set; }

        public string Speciality { get; set; }

        public string PhotoURL { get; set; }

        public string LoginID { get; set; }

        public string Passwd { get; set; }

        public string SignatureURL { get; set; }

        public bool CanLogin { get; set; }

        public string UserTypeCD { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    public class MPrescriptionDoctorVM
    {
        public Guid PrescriptionDoctorID { get; set; }

        public string DoctorName { get; set; }

        public string HospitalCD { get; set; }

        public string HospitalName { get; set; }
    }
}

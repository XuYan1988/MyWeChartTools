using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    [Serializable]
    public partial class EChartsVM
    {
        public string UploadTime { get; set; }
        public int? Number { get; set; }
        public string name { get; set; }
        public int value { get; set; }
    }
}

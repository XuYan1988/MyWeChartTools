using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class MAddressVM
    {
        [DisplayName("地址编码")]
        public string AddressCD { get; set; }

        [DisplayName("父级地址")]
        public string ParentAddressCD { get; set; }

        [DisplayName("地址名称(英文)")]
        public string Name_EN { get; set; }

        [DisplayName("地址名称(中文)")]
        public string Name { get; set; }

        [DisplayName("排序")]
        public Nullable<byte> OrderNum { get; set; }
    }
}

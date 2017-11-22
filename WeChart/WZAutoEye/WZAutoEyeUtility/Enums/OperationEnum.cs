using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public enum OperationEnum
    {
        [AttachData(AttachDataKey.Description, "登录")]
        Login = 0000,
        [AttachData(AttachDataKey.Description, "查看")]
        View = 0001,
        [AttachData(AttachDataKey.Description, "添加")]
        Add = 0002,
        [AttachData(AttachDataKey.Description, "修改")]
        Modify = 0003,
        [AttachData(AttachDataKey.Description, "删除")]
        Delete = 0004,
        [AttachData(AttachDataKey.Description, "审批")]
        Approve = 0005,
        [AttachData(AttachDataKey.Description, "导入")]
        Import = 0006,
        [AttachData(AttachDataKey.Description, "导出")]
        Export = 0007,
        [AttachData(AttachDataKey.Description, "打印")]
        Print = 0008,
    }

}

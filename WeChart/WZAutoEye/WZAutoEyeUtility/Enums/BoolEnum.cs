using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public enum CanLoginEnum
    {
        [AttachData(AttachDataKey.Description, "是")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "否")]
        No = 0
    }

    public enum CanAccess
    {
        [AttachData(AttachDataKey.Description, "可用")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "禁用")]
        No = 0
    }

    public enum CanReturn
    {
        [AttachData(AttachDataKey.Description, "可退回")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "不可退回")]
        No = 0
    }

    public enum IsPublic
    {
        [AttachData(AttachDataKey.Description, "是")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "否")]
        No = 0
    }

    public enum LeftOrRight 
    {
        [AttachData(AttachDataKey.Description, "左菜单 ")]
        Left = 1,
        [AttachData(AttachDataKey.Description, "右菜单")]
        Right = 0
    }

    public enum IsSuccess
    {
        [AttachData(AttachDataKey.Description, "成功")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "失败")]
        No = 0
    }

    public enum ImageQualityView
    {
        [AttachData(AttachDataKey.Description, "不显示")]
        No = 0,
        [AttachData(AttachDataKey.Description, "显示")]
        Yes = 1
        
        
    }

    public enum LensSituationView
    {
        [AttachData(AttachDataKey.Description, "不显示")]
        No = 0,
        [AttachData(AttachDataKey.Description, "显示")]
        Yes = 1
        
        
    }

    public enum AutoReport
    {
        [AttachData(AttachDataKey.Description, "关闭")]
        No = 0,
        [AttachData(AttachDataKey.Description, "开启")]
        Yes = 1
    }

    public enum SaveInk
    {
        [AttachData(AttachDataKey.Description, "关闭")]
        No = 0,
        [AttachData(AttachDataKey.Description, "开启")]
        Yes = 1
    }

    public enum EyeOffice
    {
        [AttachData(AttachDataKey.Description, "是")]
        Yes = 1,
        [AttachData(AttachDataKey.Description, "否")]
        No = 0
    }

    public enum BleedingNumType
    {
        [AttachData(AttachDataKey.Description, "+-号")]
        No = 0,
        [AttachData(AttachDataKey.Description, "数字")]
        Yes = 1
    }
    public enum OnekeyPrintType
    {
        [AttachData(AttachDataKey.Description, "已打印过")]
        No = 1,
        [AttachData(AttachDataKey.Description, "未打印过")]
        Yes = 0
    }
    public enum EyeImageType
    {
        [AttachData(AttachDataKey.Description, "评估")]
        No = 1,
        [AttachData(AttachDataKey.Description, "一般")]
        Yes = 0
    }
}

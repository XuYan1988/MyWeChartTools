using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public enum RetCodeEnum
    {
        [AttachData(AttachDataKey.Description, "操作成功！")]
        Success = 1,
        [AttachData(AttachDataKey.Description, "操作失败！")]
        Failed = 100,
        [AttachData(AttachDataKey.Description, "登录超时！")]
        Logout = 200,
        [AttachData(AttachDataKey.Description, "非法操作！")]
        Invalid = 300,
        [AttachData(AttachDataKey.Description, "用户名或密码错误！")]
        LoginFailure = 400,
        [AttachData(AttachDataKey.Description, "登录成功！")]
        LoginSuccess = 401,
        [AttachData(AttachDataKey.Description, "登录账户已过期！")]
        LoginFailure3 = 403,
        [AttachData(AttachDataKey.Description, "转换语言成功！")]
        ChangeLanguageSuccess = 404,
        [AttachData(AttachDataKey.Description, "该条数据已被审批！")]
        RequestIsApproved = 405,
        [AttachData(AttachDataKey.Description, "退出成功！")]
        Exit = 406,

        [AttachData(AttachDataKey.Description, "添加成功！")]
        Success_Add = 10011,
        [AttachData(AttachDataKey.Description, "修改成功！")]
        Success_Modify = 10012,
        [AttachData(AttachDataKey.Description, "删除成功！")]
        Success_Delete = 10013,
        [AttachData(AttachDataKey.Description, "审批成功！")]
        Success_Approve = 10014,
        [AttachData(AttachDataKey.Description, "添加失败！")]
        Failure_Add = 10015,
        [AttachData(AttachDataKey.Description, "修改失败！")]
        Failure_Modify = 10016,
        [AttachData(AttachDataKey.Description, "删除失败！")]
        Failure_Delete = 10017,
        [AttachData(AttachDataKey.Description, "审批失败！")]
        Failure_Approve = 10018,
        [AttachData(AttachDataKey.Description, "验证成功！")]
        Success_Validate = 10019,
        [AttachData(AttachDataKey.Description, "验证失败！")]
        Failure_Validate = 10020,
        [AttachData(AttachDataKey.Description, "查询成功！")]
        Success_Search = 10021,
        [AttachData(AttachDataKey.Description, "查询失败！")]
        Failure_Search = 10022,
    }
}

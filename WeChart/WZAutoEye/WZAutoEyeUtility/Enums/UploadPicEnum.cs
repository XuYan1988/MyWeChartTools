using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public enum UploadPicEnum
    {
        [AttachData(AttachDataKey.Description, "手动上传图像-左")]
        ManualUpload_LeftEye = 1,
        [AttachData(AttachDataKey.Description, "手动上传图像-右")]
        ManualUpload_RightEye = 2,
        [AttachData(AttachDataKey.Description, "自动上传图像-左")]
        AutoUpload_LeftEye = 3,
        [AttachData(AttachDataKey.Description, "自动上传图像-右")]
        AutoUpload_RightEye = 4,
        [AttachData(AttachDataKey.Description, "Matlab常规筛选-左")]
        MatlabCommon_LeftEye = 5,
        [AttachData(AttachDataKey.Description, "Matlab常规筛选-右")]
        MatlabCommon_RightEye = 6,
        [AttachData(AttachDataKey.Description, "Matlab深度筛选1-左")]
        MatlabDeepOne_LeftEye = 7,
        [AttachData(AttachDataKey.Description, "Matlab深度筛选1-右")]
        MatlabDeepOne_RightEye = 8,
        [AttachData(AttachDataKey.Description, "Matlab深度筛选2-左")]
        MatlabDeepTwo_LeftEye = 9,
        [AttachData(AttachDataKey.Description, "Matlab深度筛选2-右")]
        MatlabDeepTwo_RightEye = 10,
        [AttachData(AttachDataKey.Description, "手动上传图像-不确定")]
        ManualUpload_Indeterminacy = 11,
        [AttachData(AttachDataKey.Description, "自动上传图像-未知")]
        AutoUpload_Indeterminacy = 12,
        [AttachData(AttachDataKey.Description, "Matlab常规筛选-不确定")]
        MatlabCommon_Indeterminacy = 13,
        [AttachData(AttachDataKey.Description, "Matlab白底图片-不确定")]
        MatlabWhiteBG_Indeterminacy = 14,
        [AttachData(AttachDataKey.Description, "Matlab白底图片-左")]
        MatlabWhiteBG_LeftEye = 15,
        [AttachData(AttachDataKey.Description, "Matlab白底图片-右")]
        MatlabWhiteBG_RightEye = 16,
        [AttachData(AttachDataKey.Description, "Matlab常规白底图片-不确定")]
        MatlabCommonWhite_Indeterminacy = 17,
        [AttachData(AttachDataKey.Description, "Matlab常规白底图片-左")]
        MatlabCommonWhite_LeftEye = 18,
        [AttachData(AttachDataKey.Description, "Matlab常规白底图片-右")]
        MatlabCommonWhite_RightEye = 19,
        //2016-09-08 zzc
        [AttachData(AttachDataKey.Description,"人工处理切块青光眼图片-不确定")]
        ManualCutGlaucoma_Indeterminacy = 20,
        [AttachData(AttachDataKey.Description, "人工处理切块青光眼图片-左")]
        ManualCutGlaucoma_LeftEye = 21,
        [AttachData(AttachDataKey.Description, "人工处理切块青光眼图片-右")]
        ManualCutGlaucoma_RightEye = 22,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼图片-不确定")]
        ManualTaggingGlaucoma_Indeterminacy = 23,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼图片-左")]
        ManualTaggingGlaucoma_LeftEye = 24,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼图片-右")]
        ManualTaggingGlaucoma_RightEye = 25,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼无点图片-不确定")]
        ManualTaggingGlaucomaNoPoint_LeftEye = 26,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼无点图片-左")]
        ManualTaggingGlaucomaNoPoint_RightEye = 27,
        [AttachData(AttachDataKey.Description, "人工处理切块标注青光眼无点图片-右")]
        ManualTaggingGlaucomaNoPoint_Indeterminacy = 28,
        [AttachData(AttachDataKey.Description, "Matlab处理青光眼图片-分析结果1")]
        MatlabAnalysisGlaucoma_One = 29,
        [AttachData(AttachDataKey.Description, "Matlab处理青光眼图片-分析结果2")]
        MatlabAnalysisGlaucoma_Two = 30,
    }
}

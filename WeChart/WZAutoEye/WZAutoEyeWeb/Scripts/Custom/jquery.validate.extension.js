function jqueryValidateExtension() {
    //输入的时候至少包含一个英文和一个数字
    jQuery.validator.addMethod("isHaveNumAndWord", function (value, element) {
        var patrn_shuzi = /^[0-9]$/;
        var patrn_zimu = /^[a-z]|[A-Z]$/;
        var flag = 0;
        var s = value.split('');

        for (var i = 0; i < s.length; i++) {
            if (patrn_shuzi.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        for (var i = 0; i < s.length; i++) {
            if (patrn_zimu.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag != 2) {
            return false;
        }
        else {
            return true;
        }
    }, "密码中至少包含一个数字和一个字母");

    //邮件
    jQuery.validator.addMethod("isZipCode", function (value, element) {
        var tel = /^[0-9]{6}$/;
        return this.optional(element) || (tel.test(value));
    }, "请正确填写邮编");

    //电话或手机验证规则  
    jQuery.validator.addMethod("tm", function (value, element) {
        var tm = /(^1[3|4|5|7|8]\d{9}$)|(^\d{3,4}-\d{7,8}$)|(^\d{7,8}$)|(^\d{3,4}-\d{7,8}-\d{1,4}$)|(^\d{7,8}-\d{1,4}$)/;
        return this.optional(element) || (tm.test(value));
    }, "格式不正确");

    // 身份证号码验证 
    jQuery.validator.addMethod("isIdCardNo", function (value, element) {
        return this.optional(element) || idCardNoUtil.checkIdCardNo(value);
    }, "请正确输入您的身份证号码");

    //全是中文
    jQuery.validator.addMethod("allChinese", function (value, element) {
//        var re = /^[\u4E00-\u9FA5]+$/;
        //        return this.optional(element) || (re.test(value));
        var re = /^[A-Za-z]+$/;
        var flag = 0;
        var s = value.split('');
        for (var i = 0; i < s.length; i++) {
            if (re.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag > 0) {
            return false;
        }
        else {
            return true;
        }
    }, "输入的不能包含英文");

    //不能是中文
    jQuery.validator.addMethod("englishAndNum", function (value, element) {
        var re = /^[\u4E00-\u9FA5]+$/;
        var flag = 0;
        var s = value.split('');
        for (var i = 0; i < s.length; i++) {
            if (re.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag > 0) {
            return false;
        }
        else {
            return true;
        }
    }, "输入的不能包含中文")

    //全是英文
    jQuery.validator.addMethod("allEnglish", function (value, element) {
        //        var re = /^[A-Za-z]+$/;
        //        return this.optional(element) || (re.test(value));
        var re = /^[\u4E00-\u9FA5]+$/;
        var flag = 0;
        var s = value.split('');
        for (var i = 0; i < s.length; i++) {
            if (re.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag > 0) {
            return false;
        }
        else {
            return true;
        }
    }, "输入的不能包含中文");

    //中文+数字
    jQuery.validator.addMethod("chineseAndNum", function (value, element) {
//        var re = /^[\u4E00-\u9FA5]+$/;
//        var re2 = /^[0-9]$/;
//        var flag = 0;
//        var numResult = false;
//        var s = value.split('');
//        for (var i = 0; i < s.length; i++) {
//            if (re2.exec(s[i])) {
//                flag = flag + 1;
//                break;
//            }
//        }
//        if (flag > 0) {
//            numResult = true;
//        }
//        else {
//            numResult = false;
//        }
        //        return this.optional(element) || (re.test(value)) || numResult;
        var re = /^[A-Za-z]+$/;
        var flag = 0;
        var s = value.split('');
        for (var i = 0; i < s.length; i++) {
            if (re.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag > 0) {
            return false;
        }
        else {
            return true;
        }
    }, "输入的不能包含英文");

    //英文+数字
//    jQuery.validator.addMethod("englishAndNum", function (value, element) {
//        var re = /^[a-zA-Z0-9]+$/g;
//        return this.optional(element) || (re.test(value));
//    }, "输入的必须为英文+数字");

    //不能包含数字
    jQuery.validator.addMethod("notNum", function (value, element) {
        var re = /^[0-9]$/;
        var flag = 0;
        var s = value.split('');
        for (var i = 0; i < s.length; i++) {
            if (re.exec(s[i])) {
                flag = flag + 1;
                break;
            }
        }
        if (flag > 0) {
            return false;
        }
        else {
            return true;
        }
    }, "输入内容不能包含数字");

    //下拉列表验证
    jQuery.validator.addMethod("guidEmpty", function (value, element) {
        if ("00000000-0000-0000-0000-000000000000" == value) {
            return false;
        } else { return true; }

    }, "请输入数据");

    //不能为零验证
    jQuery.validator.addMethod("NoZero", function (value, element) {
        if (0 == Number(value) && value !="") {
            return false;
        } else { return true; }

    }, "输入值不能为0");
    //不能输入大于10的数字
    jQuery.validator.addMethod("NoTen", function (value, element) {
        if (Number(value) > 9 && value != "") {
            return false;
        } else { return true; }

    }, "输入值不大于9");
    //不能大于99
    jQuery.validator.addMethod("NoTwoNumber", function (value, element) {
        if (Number(value) > 99 && value != "") {
            return false;
        } else { return true; }

    }, "输入值不大于二位数");
    //不能输入大于999
    jQuery.validator.addMethod("NoThreeNumber", function (value, element) {
        if (Number(value) > 999 && value != "") {
            return false;
        } else { return true; }

    }, "输入值不大于三位数");
}
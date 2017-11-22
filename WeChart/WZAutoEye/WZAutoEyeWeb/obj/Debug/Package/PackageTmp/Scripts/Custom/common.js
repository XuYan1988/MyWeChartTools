
$(document).ready(function () {
	   if( $("input[type='text']:first")[0] != undefined){
	    	 $("input[type='text']:first")[0].focus();
	    }
    $('.u-file-c').addClass('u-file-btn') ;
    $('.u-file-c').each(function(i, el){
        $(this).html($(this).html());
    });
    if(browser.versions.gecko){ //firefox innerText define
		   HTMLElement.prototype.__defineGetter__("innerText", 
		    function(){
		     var anyString = "";
		     var childS = this.childNodes;
		     for(var i=0; i<childS.length; i++) {
		      if(childS[i].nodeType==1)
		       anyString += childS[i].tagName=="BR" ? '\n' : childS[i].innerText;
		      else if(childS[i].nodeType==3)
		       anyString += childS[i].nodeValue;
		     }
		     return anyString;
		    } 
		   ); 
		   HTMLElement.prototype.__defineSetter__("innerText", 
		    function(sText){ 
		     this.textContent=sText; 
		    } 
		   ); 
		}
    if($.hotkeys){
    	
    	$.hotkeys.add('return',function (){enterPress();});
    	
    	$.hotkeys.add('pageup',function (){if($("#pageup")){$("#pageup").click();}});
    	
    	$.hotkeys.add('pagedown',function (){if($("#pagedown")){$("#pagedown").click();}});
    }
    

});
function cpuInfo(flg,info) {//CPU 信息  
	var cpu="";
	if(!flg) return "";
	if(browser.versions.trident){
		//cpu=cpuInfo(cpu);
		try{		
			var locator = new ActiveXObject ("WbemScripting.SWbemLocator"); 	
			var service = locator.ConnectServer("."); 	
			if(service!==undefined){
			    var properties = service.ExecQuery("SELECT * FROM Win32_Processor");   
			    var e = new Enumerator (properties);   
			   
			    for (;!e.atEnd();e.moveNext ()) {   
			    	var p = e.item ();   
			    	cpu=p.SystemName+'-'+p.ProcessorID;    
			    }  
			    properties = service.ExecQuery("SELECT * FROM Win32_BaseBoard");   
				e = new Enumerator (properties);   		
				for (;!e.atEnd();e.moveNext ()) {   
				  var p = e.item ();    
				  cpu += '-'+p.SerialNumber;  		  
				}   
			}
					   
	    }catch(e){
	    	cpu = "";
	    }
		if(cpu==""){
			//jAlert("请点击下载并执行，以用来开启ActiveX并将我们加入信任站点,如有任何疑问,请参考<a href='../htm.htm?fn=computer_binding_set#yinan' target='_blank'><font style='color:#269abc'>疑难解答</font></a>", "提示信息", null);			
			jMyAlert(info, lang("download_activex"), lang('notice'), function(flag){
				if(flag === 1){
					go("../download.htm?fn=ActiveX_Install.reg");
				}else if(flag === 2){
					
				}
			});
		}
	}else{
		jAlert(lang('eli4'), lang('notice'), null);		
	}
	return cpu;
}


var isSubmit = false;
function showPatInfo(id) {
	showMyDialog('ho_show_patient.htm?ID=' + id, id,
			'width=1000px,dialogHeight=600px, resizable=no,');

}
function showRecInfo(id) {
	showMyDialog('ho_show_record.htm?ID=' + id, id,
			'width=1000px,dialogHeight=700px, resizable=no,');

}

function showPatRecords(id) {
	showMyDialog('ho_show_patient_records.htm?ID=' + id, id,
			'width=1000px,dialogHeight=700px, resizable=no,');
}
/*function see(item1,item2,f) {
	showMyDialog('img_look.htm?f='+f+'&&item1=' + item1+'&&item2=' + item2, '',
			'dialogWidth=1000px,dialogHeight=700px,center=yes,resizable=yes,');
}*/

function showMyDialog(page,title,style,fn){
	/*if(window.showModalDialog){
		var re= window.showModalDialog(page,title,style);
		if(fn){
			fn(re);
		}
	}else{*/
		
		window.open(page,title,style+",resizable=yes,AutoSize=true,scrollbars=2,alwaysRaised=yes,toolbar=no,menubar=no,location=no, status=no,");
		
	//}
}
function showMyModal(page,title,style){	
	if(window.showModalDialog){
		var re= window.showModalDialog(page,title,style);
		if(fn){
			fn(re);
		}
	}else{
		window.open(page,title,style+",resizable=yes,AutoSize=true,scrollbars=2,alwaysRaised=yes,toolbar=no,menubar=no,location=no, status=no,");
	}
}
Date.prototype.pattern = function(fmt) {

	var o = {

		"M+" : this.getMonth() + 1, // 月份

		"d+" : this.getDate(), // 日

		"h+" : this.getHours() % 12 == 0 ? 12 : this.getHours() % 12, // 小时

		"H+" : this.getHours(), // 小时

		"m+" : this.getMinutes(), // 分

		"s+" : this.getSeconds(), // 秒

		"q+" : Math.floor((this.getMonth() + 3) / 3), // 季度

		"S" : this.getMilliseconds()
	// 毫秒

	};

	var week = {

		"0" : "\u65e5",

		"1" : "\u4e00",

		"2" : "\u4e8c",

		"3" : "\u4e09",

		"4" : "\u56db",

		"5" : "\u4e94",

		"6" : "\u516d"

	};

	if (/(y+)/.test(fmt)) {

		fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "")
				.substr(4 - RegExp.$1.length));

	}

	if (/(E+)/.test(fmt)) {

		fmt = fmt
				.replace(
						RegExp.$1,
						((RegExp.$1.length > 1) ? (RegExp.$1.length > 2 ? "\u661f\u671f"
								: "\u5468")
								: "")
								+ week[this.getDay() + ""]);

	}

	for ( var k in o) {

		if (new RegExp("(" + k + ")").test(fmt)) {

			fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k])
					: (("00" + o[k]).substr(("" + o[k]).length)));

		}

	}

	return fmt;

}

function timestampformat(timestamp,fmt) {
    return (new Date(timestamp)).pattern(fmt);
} 
String.prototype.startWith = function(str) {
	var reg = new RegExp("^" + str);
	return reg.test(this);
}

String.prototype.endWith = function(str) {
	var reg = new RegExp(str + "$");
	return reg.test(this);
}
function doPrompt(msg, func, p1, p2, p3, p4, p5, p6, p7, p8, p9) {
	jPrompt(msg, '', lang("ConfimMsg"), function(val) {
		if (val) {
			func(val, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
	});
}
function doConfirm(msg, func, p1, p2, p3, p4, p5, p6, p7, p8, p9) {
	jConfirm(msg, lang("ConfimMsg"), function(typedValue) {
		if (typedValue) {
			func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
	});
}
function doConfirmForUrl(msg, url) {
	jConfirm(msg, lang("ConfimMsg"), function(typedValue) {
		if (typedValue) {
			window.location.href = url;
		}
	});

}

function catch_keydown(sel) {
	switch (event.keyCode) {
	case 13:
		// Enter;
		sel.options[sel.length] = new Option("", "", false, true);
		event.returnValue = false;
		break;
	case 27:
		// Esc;
		alert("text:" + sel.options[sel.selectedIndex].text + ", value:"
				+ sel.options[sel.selectedIndex].value + ";");
		event.returnValue = false;
		break;
	case 46:
		// Delete;
		var title = "";
		if (navigator.browerLanguage != "zh-cn") {
			title = "删除当前选项!?";
		} else {
			title = 'Delete it?';
		}
		if (confirm(title)) {
			sel.options[sel.selectedIndex] = null;
			if (sel.length > 0) {
				sel.options[0].selected = true;
			}
		}
		event.returnValue = false;
		break;
	case 8:
		// Back Space;
		var s = sel.options[sel.selectedIndex].text;
		sel.options[sel.selectedIndex].text = s.substr(0, s.length - 1);
		event.returnValue = false;
		break;
	}
}
function catch_press(sel) {
	sel.options[sel.selectedIndex].text = sel.options[sel.selectedIndex].text
			+ String.fromCharCode(event.keyCode);
	event.returnValue = false;
}

function changeDisabledById1(id1, id2, defaultValue) {
	var value = document.getElementById(id1).value;
	document.getElementById(id2).value = defaultValue;
	if (value == 1) {
		document.getElementById(id2).setAttribute("disabled", "disabled");
	} else if (value == 2) {
		document.getElementById(id2).removeAttribute("disabled");
	}
}
function disabledItem(item) {
	document.getElementById(item).setAttribute("disabled", "disabled");
}
function enabledItem(item) {
	document.getElementById(item).removeAttribute("disabled");
}
function myStip(id, text, weizhi) {
	Stip(id).show({
		content : text,
		kind : "error",
		p : weizhi,
		closeP : 'ljClose',
		closeBtn : true
	});
}

function myTimeStip(id, text, weizhi) {
	Stip(id).show({
		content : text,
		kind : "error",
		p : weizhi,
		closeP : 'ljClose',
		closeBtn : true,
		time : 5000
	});
}
function cs() {
	if (isSubmit)
		return;
	isSubmit = true;
	var url = "search.htm?ajaxSession="+$("#sessionId").val();
	var param = {
		"flg" : "99"
	};
	jQuery.ajax({
		url : url,
		data : param,
		type : "POST",
		dataType : "json",
		success : function(rs) {
			isSubmit = false;
			if ("false" === rs[0].result && "ns" === rs[0].resultMsg) {
				window.open("login.htm", '_self');
			}
		},
		error : function(rs) {
			isSubmit = false;
		}
	});
}

function getRootWin() {
	var win = window;
	while (win != win.parent) {
		win = win.parent;
	}
	return win;
}

function ci(item) {
	$("#" + item).innerHTML = lang("tishi");

}

function initialize() {
	addcloud(); // 为页面添加遮罩
	document.onreadystatechange = subSomething; // 监听加载状态改变
}
function addcloud() {
	var bodyWidth = window.document.body.scrollWidth;
	var bodyHeight = window.document.body.scrollHeight;
	var bgObj = document.createElement("div");
	bgObj.setAttribute('id', 'bgDiv');
	bgObj.style.position = "absolute";
	bgObj.style.top = "0";
	bgObj.style.background = "#FFFFFF";
	bgObj.style.filter = "progid:DXImageTransform.Microsoft.Alpha(style=3,opacity=25,finishOpacity=75";
	bgObj.style.opacity = "0.5";
	bgObj.style.left = "0";
	bgObj.style.width = bodyWidth + "px";
	bgObj.style.height = bodyHeight + "px";
	bgObj.style.zIndex = "10000"; // 设置它的zindex属性，让这个div在z轴最大，用户点击页面任何东西都不会有反应|
	document.body.appendChild(bgObj); // 添加遮罩

	//引入load动画的css
	jQuery("head").append("<link>");
	a =jQuery("head").children(":last");
	a.attr({
	rel: "stylesheet",
	type: "text/css",
	href: "../Content/Custom/loading.css"
	});
	
	var loadingObj = document.createElement("div");
	loadingObj.setAttribute('id', 'loadingDiv');
	
	loadingObj.style.position = "absolute";
	loadingObj.style.top = bodyHeight / 2 - 100 + "px";
	loadingObj.style.left = bodyWidth / 2 + "px";
	//loadingObj.style.background = "url(./img/loading.gif)";
	loadingObj.style.width = "100px";
	loadingObj.style.height = "100px";
	loadingObj.style.zIndex = "10000";
	var hh = document.createElement("div");
	hh.setAttribute('class', 'loader');
	loadingObj.appendChild(hh);
	document.body.appendChild(loadingObj); // 添加loading动画-
}
function removecloud() {
	$("#loadingDiv").remove();
	$("#bgDiv").remove();
}
function subSomething() {
	if (document.readyState == "complete") // 当页面加载完毕移除页面遮罩，移除loading动画-
	{
		removecloud();
	}
}

function addBreycloud() {
	var bodyWidth = window.document.body.scrollWidth;
	var bodyHeight = window.document.body.scrollHeight;
	var bgObj = document.createElement("div");
	bgObj.setAttribute('id', 'bgDiv');
	bgObj.style.position = "fixed";
	bgObj.style.top = "0";
	bgObj.style.background = "#000000";
	bgObj.style.filter = "progid:DXImageTransform.Microsoft.Alpha(style=3,opacity=25,finishOpacity=75";
	bgObj.style.opacity = "0.5";
	bgObj.style.left = "0";
	bgObj.style.width = bodyWidth + "px";
	bgObj.style.height = bodyHeight + "px";
	bgObj.style.zIndex = "1001"; // 设置它的zindex属性，让这个div在z轴最大，用户点击页面任何东西都不会有反应|
	document.body.appendChild(bgObj); // 添加遮罩
	
}
function removeBreycloud() {	
	$("#bgDiv").remove();
}
/*
 * 智能机浏览器版本信息:
 * 
 */
var browser = {
	versions : function() {

		var u = navigator.userAgent, app = navigator.appVersion;

		return {// 移动终端浏览器版本信息

			trident : u.indexOf('Trident') > -1, // IE内核

			presto : u.indexOf('Presto') > -1, // opera内核

			webKit : u.indexOf('AppleWebKit') > -1, // 苹果、谷歌内核

			gecko : u.indexOf('Gecko') > -1 && u.indexOf('KHTML') == -1, // 火狐内核

			mobile : !!u.match(/AppleWebKit.*Mobile.*/)
					|| !!u.match(/AppleWebKit/), // 是否为移动终端

			ios : !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/), // ios终端

			android : u.indexOf('Android') > -1 || u.indexOf('Linux') > -1, // android终端或者uc浏览器

			iPhone : u.indexOf('iPhone') > -1 || u.indexOf('Mac') > -1, // 是否为iPhone或者QQHD浏览器

			iPad : u.indexOf('iPad') > -1, // 是否iPad

			Safari : u.indexOf('Safari') > -1
		// 是否web应该程序，没有头部与底部

		};

	}(),

	language : (navigator.browserLanguage || navigator.language).toLowerCase()

}



// document.writeln("语言版本: "+browser.language);

// document.writeln(" 是否为移动终端: "+browser.versions.mobile);

// document.writeln(" ios终端: "+browser.versions.ios);

// document.writeln(" android终端: "+browser.versions.android);

// document.writeln(" 是否为iPhone: "+browser.versions.iPhone);

// document.writeln(" 是否iPad: "+browser.versions.iPad);

// document.writeln(navigator.userAgent);

function validataOS() {

	if (navigator.userAgent.indexOf("Window") > 0) {
		return "Windows";
	} else if (navigator.userAgent.indexOf("Mac OS X") > 0) {
		return "Mac ";
	} else if (navigator.userAgent.indexOf("Linux") > 0) {
		return "Linux";
	} else {
		return "NUll";
	}

}

function checkhHtml5() {
	if (typeof (Worker) !== "undefined") {
		// alert("支持HTML5");
		return true;
	} else {
		// alert("不支持HTML5");
		return false;
	}
}

function doPrint(callback, str1, str2) {
	bdhtml = window.document.body.innerHTML;
	old = window.document.body.innerHTML;
	sprnstr = "<!--startprint-->";
	eprnstr = "<!--endprint-->";
	dis = "DISPLAY: none";
	prnhtml = bdhtml.substr(bdhtml.indexOf(sprnstr) + 17);
	prnhtml = prnhtml.substring(0, prnhtml.indexOf(eprnstr));
	prnhtml = prnhtml.replaceAll(dis, "", true);
	prnhtml = prnhtml.replaceAll(str1, str2, true);
	// prnhtml=prnhtml+"<link rel='stylesheet'
	// href='bootstrap3/css/bootstrap.css'><script type='text/javascript'
	// src='./js/express/fe_medical_records_base.js'></script>";

	window.document.body.innerHTML = prnhtml;
	window.print();
	// w=window.open("","_blank","k");
	// w.document.write(prnhtml);
	// if (navigator.appName == 'Microsoft Internet Explorer')
	// window.print();else w.print();
	// w.close();

	// window.document.body.appendChild("<script type='text/javascript'
	// src='./js/lung/lung-data-center.js'></script>");
	if (typeof (callback) == "function") {
		window.document.body.innerHTML = old;
		callback();
		return false;
	}
	window.document.body.innerHTML = old;
}
// reallyDo：被搜索的子字符串。
// replaceWith：用于替换的子字符串。
// ignoreCase /g (全文查找出现的所有匹配字符) /gi(全文查找、忽略大小写)

String.prototype.replaceAll = function(reallyDo, replaceWith, ignoreCase) {
	if (!RegExp.prototype.isPrototypeOf(reallyDo)) {
		return this.replace(new RegExp(reallyDo, (ignoreCase ? "gi" : "g")),
				replaceWith);
	} else {
		return this.replace(reallyDo, replaceWith);
	}
}

function reinitIframe() {
	var iframe = document.getElementById("iframe");
	if (iframe) {
		try {
			var bHeight = iframe.contentWindow.document.body.scrollHeight;
			var dHeight = iframe.contentWindow.document.documentElement.scrollHeight;
			var height = Math.max(bHeight, dHeight);
			iframe.height = height;
		} catch (ex) {
		}
	}
}
window.setInterval("reinitIframe()", 500);

// 说明：javascript的乘法结果会有误差，在两个浮点数相乘的时候会比较明显。这个函数返回较为精确的乘法结果。
function accMul(arg1, arg2) {
	var m = 0, s1 = arg1.toString(), s2 = arg2.toString();
	try {
		m += s1.split(".")[1].length
	} catch (e) {
	}
	try {
		m += s2.split(".")[1].length
	} catch (e) {
	}
	return Number(s1.replace(".", "")) * Number(s2.replace(".", ""))
			/ Math.pow(10, m);
}
// 除法函数，用来得到精确的除法结果
// 说明：javascript的除法结果会有误差，在两个浮点数相除的时候会比较明显。这个函数返回较为精确的除法结果。
// 调用：accDiv(arg1,arg2)
// 返回值：arg1除以arg2的精确结果
function accDiv(arg1, arg2) {
	var t1 = 0, t2 = 0, r1, r2;
	try {
		t1 = arg1.toString().split(".")[1].length
	} catch (e) {
	}
	try {
		t2 = arg2.toString().split(".")[1].length
	} catch (e) {
	}
	with (Math) {
		r1 = Number(arg1.toString().replace(".", ""));
		r2 = Number(arg2.toString().replace(".", ""));
		return (r1 / r2) * pow(10, t2 - t1);
	}
}

function piliskys(test1) {
	if (isNaN(test1)) {
		alert("不是一个有效的数字，请重新输入！");
	} else
		return "人民币" + creat(test1);
}
function creat(test1) {
	var money1 = new Number(test1);
	if (money1 > 1000000000000000000) {
		alert("您输入的数字太大，重新输入！");
		return;
	}
	var monee = Math.round(money1 * 100).toString(10)
	var i, j;
	j = 0;
	var leng = monee.length;
	var monval = "";
	for (i = 0; i < leng; i++) {
		monval = monval + to_upper(monee.charAt(i)) + to_mon(leng - i - 1);
	}
	return repace_acc(monval);
}
function to_upper(a) {
	switch (a) {
	case '0':
		return '零';
		break;
	case '1':
		return '壹';
		break;
	case '2':
		return '贰';
		break;
	case '3':
		return '叁';
		break;
	case '4':
		return '肆';
		break;
	case '5':
		return '伍';
		break;
	case '6':
		return '陆';
		break;
	case '7':
		return '柒';
		break;
	case '8':
		return '捌';
		break;
	case '9':
		return '玖';
		break;
	default:
		return '';
	}
}
function to_mon(a) {
	if (a > 10) {
		a = a - 8;
		return (to_mon(a));
	}
	switch (a) {
	case 0:
		return '分';
		break;
	case 1:
		return '角';
		break;
	case 2:
		return '元';
		break;
	case 3:
		return '拾';
		break;
	case 4:
		return '佰';
		break;
	case 5:
		return '仟';
		break;
	case 6:
		return '万';
		break;
	case 7:
		return '拾';
		break;
	case 8:
		return '佰';
		break;
	case 9:
		return '仟';
		break;
	case 10:
		return '亿';
		break;
	}
}
function repace_acc(Money) {
	Money = Money.replace("零分", "");
	Money = Money.replace("零角", "零");
	var yy;
	var outmoney;
	outmoney = Money;
	yy = 0;
	while (true) {
		var lett = outmoney.length;
		outmoney = outmoney.replace("零元", "元");
		outmoney = outmoney.replace("零万", "万");
		outmoney = outmoney.replace("零亿", "亿");
		outmoney = outmoney.replace("零仟", "零");
		outmoney = outmoney.replace("零佰", "零");
		outmoney = outmoney.replace("零零", "零");
		outmoney = outmoney.replace("零拾", "零");
		outmoney = outmoney.replace("亿万", "亿零");
		outmoney = outmoney.replace("万仟", "万零");
		outmoney = outmoney.replace("仟佰", "仟零");
		yy = outmoney.length;
		if (yy == lett)
			break;
	}
	yy = outmoney.length;
	if (outmoney.charAt(yy - 1) == '零') {
		outmoney = outmoney.substring(0, yy - 1);
	}
	yy = outmoney.length;
	if (outmoney.charAt(yy - 1) == '元') {
		outmoney = outmoney + '整';
	}
	return outmoney;
}

function ToDBC(txtstring) {
	var charList = "`~!@#$%^&*()_+-={}|[]\"\\:;'<>?,./";
	var tmp = "";
	for ( var i = 0; i < txtstring.length; i++) {
		var charcode = txtstring.charCodeAt(i);
		if (charcode < 127
				&& charList.indexOf(String.fromCharCode(charcode)) != -1) {
			tmp = tmp + String.fromCharCode(charcode + 65248);
		} else {
			tmp = tmp + String.fromCharCode(charcode);
		}
		;
	}
	return tmp;
}

function mdb(id) {
	$('#' + id).css({
		'position' : 'fixed' 
	});
	$('#' + id).mousedown(
			function(event) {
				if (event.target.tagName != "INPUT"
						&& event.target.tagName != "SELECT"
						&& event.target.tagName != "TEXTAREA"
						&& event.target.tagName != "OPTION"
						&& event.target.tagName != "BUTTON") {
					var isMove = true;
					var abs_x = event.pageX - $('#' + id).offset().left;
					var abs_y = event.pageY - $('#' + id).offset().top;
					$(document).mousemove(function(event) {
						if (isMove) {
							var obj = $('#' + id);
							obj.css({
								'left' : event.pageX - abs_x,
								'top' : event.pageY - abs_y
							});
						}
					}).mouseup(function() {
						isMove = false;
					});
				}
			});
}

function showMyDialog(page,title,style){
	/*if(window.showModalDialog){
		return window.showModalDialog(page,title,style);
	}else{*/
		return window.open(page,title,style+",alwaysRaised=yes,toolbar=no,menubar=no,AutoSize=true,scrollbars=2,location=no, status=no,");
	//}
}
//Email格式check
function emailFmtCheck(email){
	
	if(email.length < 6 || email.indexOf('@')<0){
		return true;
	}
	var emailreg1 = /^([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]/;
	var emailreg2=/([a-zA-Z0-9]+[_|\-|\.]?)*[a-zA-Z0-9]+\.(?:com|cn|net)$/;
	var strs=email.split("@");
    if(!emailreg1.test(strs[0])||!emailreg2.test(strs[1])){
	
		return true;
		
		
}
	return false;
}

function setImagePreview(id1, id2, id3, w, h) {
	var docObj = document.getElementById(id1);

	var imgObjPreview = document.getElementById(id2);
	
	if(!checkImgType(docObj.value)) 
	{ 
		jAlert(lang('picerr'),lang('notice'), null);
		return; 
	} 
	
	if (docObj.files && docObj.files[0]) {
		// 火狐下，直接设img属性
		//imgObjPreview.style.display = 'block'; 2015-6-18 liub 注释
		imgObjPreview.style.width = w + 'px';
		imgObjPreview.style.height = h + 'px';
		// imgObjPreview.src = docObj.files[0].getAsDataURL();

		// 火狐7以上版本不能用上面的getAsDataURL()方式获取，需要一下方式
		imgObjPreview.src = window.URL.createObjectURL(docObj.files[0]);

	} else {
		// IE下，使用滤镜
		docObj.select();
		var imgSrc = document.selection.createRange().text;
		var localImagId = document.getElementById(id3);
		// 必须设置初始大小
		localImagId.style.width = w + "px";
		localImagId.style.height = h + "px";
		// 图片异常的捕捉，防止用户修改后缀来伪造图片
		try {
			localImagId.style.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(sizingMethod=scale)";
			localImagId.filters
					.item("DXImageTransform.Microsoft.AlphaImageLoader").src = imgSrc;
		} catch (e) {
			jAlert(lang('picerr'),lang('notice'), null);
			return false;
		}
		imgObjPreview.style.display = 'none';
		document.selection.empty();
	}
	return true;
}

function checkImgType(fileURL) 
{ 

	var right_type=new Array(".gif",".jpg",".jpeg",".png",".bmp"); 
	var right_typeLen=right_type.length; 
	var imgUrl=fileURL.toLowerCase(); 
	var postfixLen=imgUrl.length; 
	var len4=imgUrl.substring(postfixLen-4,postfixLen); 
	var len5=imgUrl.substring(postfixLen-5,postfixLen); 
	for (var i=0;i<right_typeLen;i++) 
	{ 
		if((len4==right_type[i])||(len5==right_type[i])) 
		{ 
			return true; 
		} 
	} 
} 
//删除所有cookie
function clearCookie(){ 
	var keys=document.cookie.match(/[^ =;]+(?=\=)/g); 
	if (keys) { 
	for (var i = keys.length; i--;) 
	document.cookie=keys[i]+'=0;expires=' + new Date( 0).toUTCString() 
	} 
} 


function checkSuccess(obj, m) {
	removeRegistClass(obj);
	obj.parent().addClass("has-success");
	obj.parent().find(".state-icon > span:first").addClass("glyphicon-ok-circle");
	obj.parent().find(".state-icon").addClass("state-color-ok").show();
	if(m===''){
		obj.parent().find(".state-icon > span:last").html(m).hide();
	}else{
		obj.parent().find(".state-icon > span:last").html(m).show();
	}
}
function checkError(obj, m) {
	removeRegistClass(obj);
	obj.parent().addClass("has-error");
	obj.parent().find(".state-icon > span:first").addClass("glyphicon-remove-circle");
	obj.parent().find(".state-icon").addClass("state-color-remove").show();
	obj.parent().find(".state-icon > span:last").addClass("alert-danger");
	obj.parent().find(".state-icon > span:last").html(m).show();
	errorFlg = true;
}
function removeRegistClass(obj) {
	obj.parent().removeClass("has-error  has-success");
	obj.parent().find(".state-icon > span:first").removeClass("glyphicon-ok-circle glyphicon-remove-circle");
	obj.parent().find(".state-icon").removeClass("state-color-ok state-color-remove").hide();
	obj.parent().find(".state-icon > span:last").removeClass("alert-danger");
	obj.parent().find(".state-icon > span:last").html("").hide();	
}
function isEmpty(item){
	if(item.val() == null || item.val() == "" ){
		return true;
	}
	return false;
}
function check(str) {
	var temp = "";
	for ( var i = 0; i < str.length; i++)
		if (str.charCodeAt(i) > 0 && str.charCodeAt(i) < 255)
			temp += str.charAt(i);
	return temp;
}
function toReadOnly(itemIds){
	if(itemIds.indexOf(",") != -1){
		var items = itemIds.split(",");
		for(var i=0;i<items.length;i++){
			var item = $("#"+items[i]);
			item.attr("readonly", "true");
			item.val("");		
			removeRegistClass(item);
		}
	}else{
		var item = $("#"+itemIds);
		item.attr("readonly", "true");
		item.val("");		
		removeRegistClass(item);
	}
	
}
function toCanInput(itemIds){
	if(itemIds.indexOf(",") != -1){
		var items = itemIds.split(",");
		for(var i=0;i<items.length;i++){
			$("#"+items[i]).removeAttr("readonly");
		}
	}else{
		$("#"+itemIds).removeAttr("readonly");
	}
}


function noNumbers(e)
{
var keynum
var keychar
var numcheck

if(window.event) // IE
  {
  keynum = e.keyCode
  }
else if(e.which) // Netscape/Firefox/Opera
  {
  keynum = e.which
  }
keychar = String.fromCharCode(keynum)
numcheck = /\d/
return !numcheck.test(keychar)
}

//变更语言处理
function changeL(l, url) {
    //设置默认值进cookie
    $.post(url,
    {
       language:l
    }, function (data) {
        //画面显示
        if (l == "zh") {
            $("#zh").addClass("active");
            $("#en").removeClass("active");
        } else {
            $("#en").addClass("active");
            $("#zh").removeClass("active");
        }
        //重新加载页面
        window.location.reload();
    });
}
	function enterPress(){
		//获取焦点ID
    	var act = document.activeElement.id;
    	//取得焦点类型
    	if(act != ""){
    	if(act.indexOf(".") >= 0){
    		act = act.replace('.', '\\.');
    	   }
    	
    	var a = $("#"+act)[0].tagName;
    	if(a == "A" || ($("#"+act).attr('class').indexOf("btn") >= 0) ){
    		$("#"+act).click();
    		return;
    	}
    	    	
    	}
    		//if($.isFunction("pressEnter")){
    	       if(typeof pressEnter == 'function'){
    		   pressEnter(); 
    		}else{
    			if($(".pressEnter")){
    				$(".pressEnter").click();
    			}
    		}
    	   
	   
	}
    //////////////////////////////////////////////////////////////////////////////////////////////
    //列表翻页共同方法
    //count:列表总数
    //currentPage:当前页数（-1方式）
    //StaticPageCount:页面显示数量
	function GetPager(count, currentPageId, pnpId, StaticPageCount) {
	    //生成翻页
	    if (count > StaticPageCount) {
	        var pageS;
	        if (count % StaticPageCount == 0) {
	            pageS = count / StaticPageCount;
	        }
	        else {
	            pageS = parseInt(count / StaticPageCount) + 1;
	        }
	        currentPage = $('#' + currentPageId).val();
	        //上一页
	        if (currentPage > 0) {
	            pageHtml = "<li><a style=\"cursor: pointer;\" onclick=\"goPage(" + (currentPage).toString() + ")\" href=\"javascript:void(0);\">‹</a></li>";
	            $('#' + pnpId).append(pageHtml);
	        }

	        //页数
	        var pageHtml = "";

	        for (var i = 0; i < pageS; i++) {
	            if ((i > Number(currentPage) - 4 && i < Number(currentPage) + 4) || i == 0 || i == pageS - 1) {
	                var numStr = '';
	                if (Number(currentPage) + 1 > 4 && i == 0 && pageS != 5) {
	                    numStr = (i + 1).toString() + "...";
	                }
	                else if (pageS - currentPage > 4 && i == pageS - 1 && pageS != 5) {
	                    numStr = "..." + (i + 1).toString();
	                }
	                else {
	                    numStr = (i + 1).toString();
	                }
	                if (i == currentPage) {
	                    pageHtml = "<li class=\"active\"><a style=\"cursor: pointer;\" onclick=\"goPage(" + numStr.replace('...', '') + ")\" href=\"javascript:void(0);\">" + numStr + "</a></li>";
	                }
	                else {
	                    pageHtml = "<li><a style=\"cursor: pointer;\" onclick=\"goPage(" + numStr.replace('...', '') + ")\" href=\"javascript:void(0);\">" + numStr + "</a></li>";
	                }
	                $('#' + pnpId).append(pageHtml);
	                pageHtml = "";
	            }
	        }

	        //下一页
	        if (currentPage < pageS - 1) {
	            pageHtml = "<li><a style=\"cursor: pointer;\" onclick=\"goPage(" + (Number(currentPage) + 2).toString() + ")\" href=\"javascript:void(0);\">›</a></li>";
	        }
	        $('#' + pnpId).append(pageHtml);
	    }
	    else {
	    }
	}


	//页面自动刷新
	var refrashflg;
	var frashFun;
	function startRefresh(callback) {
	    if (callback) {
	        frashFun = callback;
	    }
	    clearTimeout(refrashflg);
	    refrashflg = setTimeout("refresh()", 120000);
	};

	function stopRefresh() {
	    clearTimeout(refrashflg);
	}
	function refresh() {
	    if (frashFun) frashFun();
	}
	

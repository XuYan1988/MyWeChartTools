var flag = false;
//var showMeg="您的医院或组织已开通电脑绑定服务,请点击下载安装(<a href='../download.htm?fn=ActiveX_Install.reg' style='color:#269abc'>开启ActiveX.reg</a>)并重启浏览器，如有任何疑问,请参考<a href='../htm.htm?fn=computer_binding_set#yinan' target='_blank'><font style='color:#269abc'>疑难解答</font></a>。";
$(document)
		.ready(
				function() {

					$("#is").keydown(function(e) {
						var curKey = e.which;
						if (curKey == 13) {
							$("#is").click();
							return false;
						}
					});
					$("#userid").keydown(function(e) {
						var curKey = e.which;
						if (curKey == 13) {
							$("#password").focus();
							return false;
						}
					});
					$("#password").keydown(function(e) {
						var curKey = e.which;
						if (curKey == 13) {
							$("#is").click();
							return false;
						}
					});
					// $(".top-memu").on("mouseover",topMenuMouseOverFunc).on("mouseout",topMenuMouseOutFunc);
					$(".top-memu").hover(topMenuMouseOverFunc,
							topMenuMouseOutFunc);
					$("#checkAll").bind("click", checkAllFunc);

					/*
					 * $("#openPasswordModal").click(function() {
					 * $("#msgp").html(''); $("#oldpassword").val("");
					 * $("#newpassword").val(""); $("#renewpassword").val("");
					 * 
					 * $("#passwordModal").modal('show'); });passwordFormat
					 */
					
					/*$('#userid').focus(
							function() {
								$('#userid').parent().prev().hide();
								$('#userid').parent().prev().prev().hide();
								$('#userid').parent().prev().prev().prev()
										.hide();
								$('#userid').parent().prev().prev().prev()
										.prev().hide();
								$('#userid').parent().removeClass("has-error")
										.addClass("has-success");
								$('#userid').next().next().hide();
							});
					$('#password').focus(
							function() {
								$('#userid').parent().prev().hide();
								$('#userid').parent().prev().prev().hide();
								$('#userid').parent().prev().prev().prev()
										.hide();
								$('#userid').parent().prev().prev().prev()
										.prev().hide();
								$('#password').parent()
										.removeClass("has-error").addClass(
												"has-success");
								$('#password').next().next().hide();
							});*/
					/*
					 * $('#userid').blur(function() { var
					 * userid=$('#userid').val(); if (''==userid||null==userid) {
					 * $('#userid').parent().removeClass("has-success").addClass("has-error");
					 * $('#userid').next().next().show(); return flag; } else {
					 * $('#userid').parent().removeClass("has-error").addClass("has-success");
					 * $('#userid').next().next().hide(); flag=true; return
					 * flag; } }); $('#password').blur(function() { var
					 * password=$('#password').val(); if
					 * (''==password||null==password) {
					 * $('#password').parent().removeClass("has-success").addClass("has-error");
					 * $('#password').next().next().show(); return flag; } else {
					 * $('#password').parent().removeClass("has-error").addClass("has-success");
					 * $('#password').next().next().hide(); flag=true; return
					 * flag; } });
					 */
					
				});



function topMenuMouseOverFunc() {
	$(".top-memu").find("ul").stop();
	$(this).find("ul").slideDown(600);
}

function topMenuMouseOutFunc() {
	$(".top-memu").find("ul").stop();
	$(this).find("ul").hide();
}
var isSubmit = false;

function login() {
	if (isSubmit)
		return;
	isSubmit = true;

	// 取得电脑名+cpu序列号+主板序列号
	var cpu = "";
	cpu = cpuInfo($("#bind").val() == "2",lang('tw.lack.activex.info'));
	// 只有医院开通绑定服务时，才做check
	if ($("#bind").val() == "2" && cpu == "") {
		isSubmit = false;
		return;
	}
	var list ='';

	var hi = $("#hospital").val();
	var pw = $("#password").val();
	var id = $("#userid").val();
	// 打开病历页面或者登入页面。
	var jsonData = {
		"flg" : "1",
		"userid" : id,
		"userpw" : pw,
		"hospitalid" : hi,
		"cpu" : cpu
	};
	$.ajax({
		url : "ho_login.htm?ajaxSession=" + $("#sessionId").val(),
		type : "POST",
		dataType : "json",
		data : jsonData,
		async : false,
		success : function(rs) {
			if ("true" === rs[0].result) {
				flg = true;
			} else {
				flg = false;
			}
			list = rs[0].resultMsg;
		},
		error : function(XMLHttpRequest, textStatus, errorThrown) {
			flg = false;
		},
		complete : function(XHR, TS) {

			XHR = null;
		}
	});
	//var userid = $('#userid').val();
	//var password = $('#password').val();
	if (flg) {
		go(list);

	}else {/* if ('' != userid && '' == password) {
		
		$('#userid').parent().prev().hide();
		$('#userid').parent().prev().prev().hide();
		$('#userid').parent().prev().prev().prev().show();
		$('#userid').next().next().hide();
		$('#password').next().next().hide();
		$('#userid').parent().prev().prev().prev().prev().hide();
	} else if ('' == userid) {
		$('#userid').parent().prev().prev().hide();
		$('#userid').parent().prev().prev().prev().hide();
		$('#userid').parent().prev().prev().prev().prev().show();
		$('#userid').parent().prev().hide();
		$('#userid').next().next().hide();
		$('#password').next().next().hide();
	} else {
		$('#userid').parent().prev().hide();
		$('#userid').parent().prev().prev().show();
		$('#userid').parent().prev().prev().prev().hide();
		$('#userid').next().next().hide();
		$('#password').next().next().hide();
		$('#userid').parent().prev().prev().prev().prev().hide();*/
		jAlert(list, lang('notice'), null);
	}
	

	isSubmit = false;
}
function bindPC() {

	if (isSubmit)
		return;
	isSubmit = true;
	// 取得电脑名+cpu序列号+主板序列号
	var cpu = "";
	cpu = cpuInfo($("#bind").val() == "2",lang('tw.lack.activex.info'));
	// 只有医院开通绑定服务时，才做check
	if ($("#bind").val() == "2" && cpu == "") {
		isSubmit = false;
		return;
	}

	var hi = $("#hospital").val();
	var pw = $("#password").val();
	var id = $("#userid").val();
	// 打开病历页面或者登入页面。
	var jsonData = {
		"flg" : "2",
		"userid" : id,
		"userpw" : pw,
		"hospitalid" : hi,
		"cpu" : cpu
	};
	$.ajax({
		url : "ho_login.htm?ajaxSession=" + $("#sessionId").val(),
		type : "POST",
		dataType : "json",
		data : jsonData,
		async : false,
		success : function(rs) {
			if ("true" === rs[0].result) {
				flg = true;
			} else {
				flg = false;
			}
			list = rs[0].resultMsg;
		},
		error : function(XMLHttpRequest, textStatus, errorThrown) {
			flg = false;
		},
		complete : function(XHR, TS) {

			XHR = null;
		}
	});

	jAlert(list, lang('notice'), null);

	isSubmit = false;
}

function goexit(page) {
	jMyAlert(lang('confirmation.exit'), lang("singOut"), lang('notice'),
			function(flg) {
				if (flg === 1) {
					go(page);
				} else {

				}
			});
}
function go(page) {
	window.open(page, '_self');
}
/**
 * checked all
 */
function checkAllFunc() {
	if ($(this).is(":checked")) {
		var roomids = $(".checkbox");
		for ( var j = 0; j < roomids.length; j++) {
			if (roomids[j].disabled == false) {
				roomids[j].checked = true;
			}
		}
		// $(".checkbox").prop("checked", true);
	} else {
		$(".checkbox").prop("checked", false);
	}
}
function upload(obj) {
	$("#" + obj).click();
}
function doHide(item) {
	if ($("#" + item).css("display") !== "none") {
		$("#" + item).hide();
		$("#backback").hide();
	} else {
		$("#" + item).show();
	}
}
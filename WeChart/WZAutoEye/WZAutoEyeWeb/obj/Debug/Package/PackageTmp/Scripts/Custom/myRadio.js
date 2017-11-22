//切换
$(document).ready(function() {
	$(".btn-group").each(function() {
		if (2 == $(this).find("button").length) {
			$(this).bind("click", change);
		} else if (3 == $(this).find("button").length) {
			if (1 == $(this).find("input[type='hidden']").length) {
				$(this).find("button").bind("click", change3btn);
			}
		}
	});
});
/**
 * radio选中checked
 * 
 * @param radioName
 *            radio的name
 * @param valueId
 *            当前value的ID
 */
function checkMyRadio2(radioName, valueId) {
	var value = $("#" + valueId).val();

	if ("2" == value) {

		$("#" + radioName + "-group-1").addClass("unselect");
		$("#" + radioName + "-group-2").addClass("select");
	} else {
		$("#" + radioName + "-group-1").addClass("select");
		$("#" + radioName + "-group-2").addClass("unselect");
	}

}
function checkMyUrl(radioName, valueId) {
	var value = $("#" + valueId).val();

	if ("1" == value) {

		$("#" + radioName + "-group-2").addClass("unselect");
		$("#" + radioName + "-group-1").addClass("select");
	} else {
		$("#" + radioName + "-group-2").addClass("select");
		$("#" + radioName + "-group-1").addClass("unselect");
	}

}
function checkMyRadio1(radioName, valueId) {
	var value = $("#" + valueId).val();

	if ("1" == value) {

		$("#" + radioName + "-group-2").addClass("unselect");
		$("#" + radioName + "-group-1").addClass("select");
	} else {
		$("#" + radioName + "-group-2").addClass("select");
		$("#" + radioName + "-group-1").addClass("unselect");
	}

}
/**
 * 2个按钮切换
 */
function change() {
	var $obj;
	if (0 == $(this).find(".btn").length) {
		$obj = $(arguments[0]).find(".btn");
	} else {
		$obj = $(this).find(".btn");
	}
	$obj.each(function() {
		if ($(this).hasClass("select")) {
			$(this).removeClass(" select").addClass("unselect");
		} else {
			$(this).removeClass("unselect").addClass("select");
			$(this).parent().children("input[type='hidden']").val(
					$(this).attr("value"));
		}
	});
}
/**
 * 3个按钮切换
 */
function change3btn() {
	// 移除选中
	$(this).parent().find("button").removeClass("select").addClass("unselect");
	// 选中当前
	$(this).removeClass("unselect").addClass("select");
	// 赋值
	$(this).parent().find("input[type='hidden']").val($(this).val());
}
/**
 * OFF/ON按钮初始化
 */
function initchange(radioName, valueId) {
	var value = $("#" + valueId).val();
	if (value == "1") {
		$("#" + radioName).prop("checked", true);
	} else {
		$("#" + radioName).prop("checked", false);
	}
}

/**
 * OFF/ON按钮初始化
 */
function initchangeM(radioName, valueId) {
	
	/*$.each($('input[name="'+radioName+'"]'),function(i) {
		var value = $(this).parent().find('input[name="'+valueId+'"]').val();
			if (value == "1") {
				$(this).prop("checked", true);
			} else {
				$(this).prop("checked", false);
			}
	});	*/
	var obj = $('input[name="'+radioName+'"]');
	for(var i=0;i<obj.length;i++){
		var value = $(obj[i]).parent().find('#'+valueId).val();
		if (value == "1") {
			$(obj[i]).prop("checked", true);
		} else {
			$(obj[i]).prop("checked", false);
		}
	}
}
/**
 * OFF/ON按钮初始化
 */
function initchange2(radioName, valueId) {
	var value = $("#" + valueId).val();
	if (value == "2") {
		$("#" + radioName).prop("checked", true);
	} else {
		$("#" + radioName).prop("checked", false);
	}
}
/**
 * OFF/ON切换
 * @param that
 * @param id2
 */
function change(that, id2) {	
	var val = that.value;
	if (that.checked) {
		$("#" + id2).val(val.split(',')[0]);
	} else {
		$("#" + id2).val(val.split(',')[1]);
	}
}
function change2(that, id2) {
	var val = that.value;
	if (that.checked) {
		$("#" + id2).val(val.split(',')[1]);
	} else {
		$("#" + id2).val(val.split(',')[0]);
	}
}

$(function(){
	
	  $(".panel-heading").on('click',function(){
		if ($(this).next(".table").hasClass("table-hidden")){//如果是关闭状态的
		    $(this).parent(".panel").parent(".col-md-3").find(".panel .table").addClass("table-hidden");
		    $(this).next(".table").removeClass("table-hidden");
		    $(this).parent(".panel").parent(".col-md-3")
		    	.find(".panel .panel-heading")
		    	.removeClass("panel-color-green").addClass("panel-color-gray")
		    	.find(".glyphicon").removeClass("glyphicon-triangle-top").addClass("glyphicon-triangle-bottom");
		    $(this).removeClass("panel-color-gray").addClass("panel-color-green");
		    $(this).find(".glyphicon").removeClass("glyphicon-triangle-bottom").addClass("glyphicon-triangle-top");
		}else{//如果是打开状态的
			  $(this).next(".table").addClass("table-hidden");
			  $(this).parent(".panel").parent(".col-md-3")
			    	.find(".panel .panel-heading")
			    	.removeClass("panel-color-green").addClass("panel-color-gray")
			    	.find(".glyphicon").removeClass("glyphicon-triangle-top").addClass("glyphicon-triangle-bottom ");
			  $(this).removeClass("panel-color-green").addClass("panel-color-gray");
			  $(this).find(".glyphicon").removeClass("glyphicon-triangle-top").addClass("glyphicon-triangle-bottom");
		}
	  });
	
	$('#goReport').click(function(){
		var selected = "";
		//^=以什么开头
		$("input[name^='imageId']").each(function() {
			if ($(this).is(":checked")) {
				selected = $(this).val() + "," + selected;
			}
		});		
		if($("#lockStatus").val()== 1){
			jAlert(lang('fa.lcse.lock'),lang('notice'),function(){
				self.location='diabetic_retinopathy_manager.htm'; 
			});
		}else if (null == selected || "" == selected) {
			jAlert(lang("tw.deei.bxxz"),lang('notice'),null);
		}else{
			$("#submitFlg").val("0");
			document.forms["diabetesEyesImageEditForm"].submit();
		}
	});
	$(".compute-close").on('click', function() {
		$.colorbox.close();
		$(".show_screening_box").empty();
	});
	checkSelect('unit', "unitV");
	checkSelect('pic', "picV");
	checkSelect('twDeep', "twDeepV");
});


function  updUnit(id,unit){
	$("#submitFlg").val("2");
	$("#unit").val(unit);
	if($("#lockStatus").val()== 1){
		jAlert(lang('fa.lcse.lock'),lang('notice'),function(){
			self.location='diabetic_retinopathy_manager.htm'; 
		});
	}else {
		document.forms["diabetesEyesImageEditForm"].submit();
	}
}

function  ic(id,pic){
	$("#submitFlg").val("3");
	$("#pic").val(pic);
	if($("#lockStatus").val()== 1){
		jAlert(lang('fa.lcse.lock'),lang('notice'),function(){
			self.location='diabetic_retinopathy_manager.htm'; 
		});
	}else {
		document.forms["diabetesEyesImageEditForm"].submit();
	}
}

function doAction(flg) {
	$("#submitFlg").val(flg);
	document.forms["diabetesEyesImageEditForm"].submit();
}

function refreshEdit(){
	location.reload(); 
}
//修改筛查深度
function updateDeep(id,deepIfno){
	$("#submitFlg").val("6");
	$("#twDeep").val(deepIfno);
	if($("#lockStatus").val()== 1){
		jAlert(lang('fa.lcse.lock'),lang('notice'),function(){
			self.location='diabetic_retinopathy_manager.htm'; 
		});
	}else {
		document.forms["diabetesEyesImageEditForm"].submit();
	}
	
}

function intelligentReport(imgid) {
	intelligentReportHtml(imgid);
	var height =  "70%";
	var language = $("#lang").val();
	//根据语言的不同设置的高度不同
	 if(language==''){
		 language= getL();
	 }
	if(language == 'zh'){
		height =  "60%";
	}
	$("#showColor").colorbox({
		inline : true,
		width : "50%",
		height:height,	
		overlayClose : false,
		transition : "elastic",
		onClosed : function() {
		
		}

	});
	
	$("#showColor").click();
};

function intelligentReportHtml(imgid){
var jsonData = {
		"flg":"14",
		"key" : imgid,		
	};
jQuery.param(jsonData);
$.ajax({
	url:"search.htm",
	type:"POST",
	data:jsonData,
	dataType:"json",
	//timeout:8000,
	success:function(result){
		var returnJoson = result[0].list;						
		$("#intelligentReportHtml").html(returnJoson);
	},
	error:function(){
		$("#intelligentReportHtml").html(lang('tw.deei.readError'));
	}
});
}


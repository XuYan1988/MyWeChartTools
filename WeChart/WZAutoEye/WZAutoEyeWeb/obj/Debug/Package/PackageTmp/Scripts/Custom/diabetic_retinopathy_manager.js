
		$(document)
				.ready(
						function() {
							 var l =getCookie("somoveLanguage");
								if(l==null){
									l="zh";		
								};
								if(l!=$('#lang').val()){
									changeL($('#lang').val());
								};
							 $("#searchPatientName").blur();
							$("#searchBtn").bind("click", searchRecordFunc);
							$("#downLoadTableList").bind("click", downLoadTableListFunc);
							checkSelect('searchPatientAge', "searchPatientAgeV");
							checkSelect('searchPatientSex', "searchPatientSexV");
							checkSelect('searchStatus', "searchStatusV");
							checkSelect('searchDiabeteGrade',
									"searchDiabeteGradeV");
							checkSelect('searchTwUnit', "searchTwUnitV");
							checkSelect('searchDiseaseFlg', "searchDiseaseFlgV");
							checkSelect('searchImageQuality', "searchImageQualityV");
							//checkSelect('searchCataract', "searchCataractV");
							checkRadio('searchUploadDateR','searchUploadDateRH');
					         datetimepickerinit();
							
								$("#searchBloodCountT").bind('blur',panduandaxiao);
								$("#searchBloodAllAreaT").bind('blur',panduandaxiao1);
								$("#searchBloodCountF").bind('blur',panduandaxiao);
								$("#searchBloodAllAreaF").bind('blur',panduandaxiao1);
							//更多条件显示与否的初始化
								if($("#moreSearchFlg").val()==="1"){
									$("#more-search").show();	
									$("#ccccccc").toggleClass("icon-double-angle-down");								
									$("#ccccccc").toggleClass("icon-double-angle-up");	
								}
							//更多条件按钮按下的事件
								$("#more-search-btn").on("click",function(){
									var $i = $(this).children("i");
									if ($i.hasClass("icon-double-angle-up")) {
										$("#more-search").hide();
										$i.toggleClass("icon-double-angle-down");
										$i.toggleClass("icon-double-angle-up");										
										$("#moreSearchFlg").val("0");//关闭
									}else{
										$("#more-search").show();
										$i.toggleClass("icon-double-angle-down");
										$i.toggleClass("icon-double-angle-up");
										$("#moreSearchFlg").val("1");//打开
									}
									
								});	
							if($("#errorFlg").val() == 1){
								jAlert(lang('tw.ddrm.loadDown'),lang('notice'),null);
							}
			
			getDataUseCloud();
/*			var scrollFunc=function(e){ 
				  e=e || window.event; 
				  if(e.wheelDelta && event.ctrlKey){//IE/Opera/Chrome 
				   event.returnValue=false;
				  }else if(e.detail){//Firefox 
				   event.returnValue=false; 
				  } 
				 };  
				 
				 注册事件 
				 if(document.addEventListener){ 
				 document.addEventListener('DOMMouseScroll',scrollFunc,false); 
				 }//W3C 
				 window.onmousewheel=document.onmousewheel=scrollFunc;//IE/Opera/Chrome/Safari 
*/		});
		var cloud=false;
		function getDataUseCloud(){
			cloud=true;
			getData();
			
		}
		var isSubmiting = false;
		function getData(page){
			if(cloud){addcloud();}
			if (isSubmiting)
				return;
			isSubmiting = true;
			if(page==undefined || page==null ||$("#page").val()!="1"){
				page=$("#page").val();
			}
			var jsonData = {
					"flg":1,//查询					
					"page":page,
					"moreSearchFlg":$("#moreSearchFlg").val(),
					"searchHospitalId":$("#searchHospitalId").val(),
					"searchPatientName":$("#searchPatientName").val(),
					"searchPatientSex": $("#searchPatientSex").val(),
					"searchPatientAge": $("#searchPatientAge").val(),
					"dateFlg":  $("#dateFlg").val(),
					"searchUploadDateF": $("#searchUploadDateF").val(),
					"searchUploadDateT": $("#searchUploadDateT").val(),
					"searchDRno":  $("#searchDRno").val(),
					"searchDiseaseFlg": $("#searchDiseaseFlg").val(),
					"searchStatus":  $("#searchStatus").val(),
					"searchRemarks": $("#searchRemarks").val(),
					"searchDiabeteGrade": $("#searchDiabeteGrade").val(),
					"searchImageQuality":  $("#searchImageQuality").val(),
					//"searchCataract":  $("#searchCataract").val(),
					"searchBloodCountF": $("#searchBloodCountF").val(),
					"searchBloodCountT": $("#searchBloodCountT").val(),
					"searchBloodAllAreaF": $("#searchBloodAllAreaF").val(),
					"searchBloodAllAreaT": $("#searchBloodAllAreaT").val(),
					"searchTwUnit": $("#searchTwUnit").val(),
					"typeFlg":$("#typeFlg").val(),
	        	};
	        	$.ajax({
	        		type : "POST",
	        		url : "diabetic_retinopathy_manager_ajax.htm?ajaxSession=" + $("#sessionId").val(),
	        		data : jsonData,
	        		dataType : "json",
	        		async : true,
	        		success : function(result) {
	        			 if ("true" == result[0].result){//查询成功时
	        				
	        				//表格顶部提示信息修改、
	        				$("#recordCount").empty();
	        				var param = result[0].resultMsg.split(",");
	        			 	if(param[2]=="0"){
	        			 		$("#recordCount").append(lang('tw.drm.nodata'));
	        			 	}else{
	        			 		$("#recordCount").append(lang('tw.drm.totleSize')+param[2]+lang('tw.drm.totleSize1'));
	        			 	}	        				
	        				//表格数据删除清空
	        				$("#datalist").empty();
	        				//表格数据的设置
	        				$("#datalist").append(result[0].list);
	        				//翻页的删除
	        				$("#pnp").empty();
	        				//翻页的设置
	        				var pageHtml = setPreNextPageData(param[0],param[1],'page','getDataUseCloud()');
	        				$("#pnp").append(pageHtml);
	        				$("#inputDatetimePickerF").val(param[4]);
	        				$("#inputDatetimePickerT").val(param[5]);
	        			 }else{ //查询失败时
	        				
		        			//表格顶部提示信息修改
		        			$("#recordCount").empty();
		        			$("#recordCount").append(lang('tw.drm.nodata'));
		        			//表格数据删除清空
		        			$("#datalist").empty();
		        			//翻页的删除
		        			$("#pnp").empty();
		        			
	        			 }
	        			 //setTimeout(function(){},5000);
	        			 titleNotice();
	        			 if(cloud){removecloud();cloud=false;}
	        			 
	        		},
					complete : function(XHR, TS) {
						isSubmiting = false;
						XHR = null;
						//自动刷新定时			
			        	startRefresh(getData);	
					}	
	        	});
	        	
			
		}
		function searchRecordFunc() {
			$("#page").val(1);
			getDataUseCloud();
			$("#searchBtn").blur();
		}
		function downLoadTableListFunc(){				
			$("#submitFlg").val(5);
			document.forms["diabeticRetinopathyManagerForm"].submit();
			$("#downLoadTableList").blur();
		}		
		

		function showURL(url, status) {
			if (status == '14') {
				$("#emUrl").text(url);
				$("#emUrl").attr('href', url);
				$("#emUrlp").html("");
				$("#sm").html(lang('tw.drm.url'));

			} else if (status == '13') {
				$("#emUrl").text("");
				$("#emUrl").attr('href', "");
				$("#emUrlp").html(url);
				$("#sm").html(lang('tw.drm.report'));
			} else {
				$("#emUrl").text("");
				$("#emUrl").attr('href', "");
				$("#emUrlp").html(url);
				$("#sm").html(lang('tw.drm.min'));
			}

			var options = {
				render : "image",
				text : url,
				width : 200,
				height : 200
			};

			// 二维码生成
			$('#qr').empty().qrcode(options);
			//$('#myModal').modal("show");
			//mdb("myModal");
			
			$("#QRBTN").colorbox({
			    inline:true, 
			    width:"50%",
			    href:"#showQr",
			    overlayClose:false,
			    speed:350,
			    title:"",
			    onLoad : function () {
			        $('#cboxClose').remove();
			        stopRefresh();
			      }
			  });
			
			$("#close_QR").on('click',function(){
			    $("#QRBTN").colorbox.close();
			    startRefresh();
			  });
			$("#QRBTN").click();
			
		};
	function changedate(){
		$('.form_date').datetimepicker('remove');
		var flg = $("#dateFlg").val();
		var start = "";
		var end = "";
		if(flg == 0 || flg == 1){
			start =	"";
			  end = "";
			  $("#searchUploadDateF").val(start);
			  $("#searchUploadDateT").val(end);
			  //移除日期时间选择器。同时移除已经绑定的event、内部绑定的对象和HTML元素。并且重新创建一个日期时间选择器
		      datetimepickerinit();
		}else{
			getSysDate(flg);
		}

		    
	};
	function changedatef(){
		$("#dateFlg").val("0");
	};
	function checkdatetimepicker(id1,id2,id3){
		checkdate(id1,id2,id3);
		var datepick2 = {
    			language : 'zh-CN',
    			weekStart : 1,
    			autoclose : 1,
    			startView : 2,
    			minView : 2,
    			format : "yyyy-mm-dd",
    			forceParse : 0,
    			initialDate:$("#serviceDate").val(),
    			endDate : $("#serviceDate").val(),
    			
    		};
		$('#divUpdateDatetimeT').datetimepicker('remove').datetimepicker(datepick2); 
	};
      function checkInt(id){
    	  checkZero(id);
      	var num = $("#"+id).val().trim();
      	var tt=/^\d+$/g;
      	if(num.length>0){
      	 if(!tt.test(num)){
      		jAlertErr(lang('tw.ipload.mustint2'),lang('notice'),null);
      		 $("#"+id).val("");
      	  };
      	};
      };
      
       
      function checkIntF(id){
    	  checkZero(id);
        	var num = $("#"+id).val().trim();
        	var tt=/^\d+$/g;
        	if(num.length>0){
        	 if(isNaN( num )){
        		 jAlertErr(lang('tw.ipload.mustint3'),lang('notice'),null);
        		 $("#"+id).val("");
        	 }else if(num < 0){
        		 jAlertErr(lang('tw.ipload.mustint3'),lang('notice'),null);
        		 $("#"+id).val("");
        	 };
           };
        };
      function panduandaxiao(){
    	  if($("#searchBloodCountF").val().trim().length > 0 && $("#searchBloodCountT").val().trim().length > 0 ){
    		  if(Number($("#searchBloodCountF").val().trim()) >Number($("#searchBloodCountT").val().trim())){
    			  jAlertErr(lang('tw.ipload.blood'),lang('notice'),null);
    			  $("#searchBloodCountT").val("");
    		  }
    	  }
      };
      function panduandaxiao1(){
    	  if($("#searchBloodAllAreaF").val().trim().length > 0 && $("#searchBloodAllAreaT").val().trim().length > 0  ){
    		  if(Number($("#searchBloodAllAreaF").val().trim()) >Number($("#searchBloodAllAreaT").val().trim())){
    			  jAlert(lang('tw.ipload.area'),lang('notice'),null);
    			  $("#searchBloodAllAreaT").val("");
    		  }
    	  }
      };
        function datetimepickerinit(){
        	$("#inputDatetimePickerF").val($("#searchUploadDateF").val());
	        $("#inputDatetimePickerT").val($("#searchUploadDateT").val());
    			var datepick = {
    	    			language : 'zh-CN',
    	    			weekStart : 1,
    	    			autoclose : 1,
    	    			startView : 2,
    	    			minView : 2,
    	    			format : "yyyy-mm-dd",
    	    			forceParse : 0,
    	    			initialDate:$("#serviceDate").val(),
    	    			endDate : $("#serviceDate").val(),
    	    			
    	    		};
	         $('#divUpdateDatetimeF').datetimepicker('remove').datetimepicker(datepick).datetimepicker('update');  
	         $('#divUpdateDatetimeT').datetimepicker('remove').datetimepicker(datepick).datetimepicker('update');  
      }
    	
    	function clearlock(recordId){
    		doConfirm(lang('EM600152'), Unlock, recordId);
    	}
        function Unlock(recordId){
        	var jsonData = {
        		"flg":0,//查询	
        		"recordId":recordId
        	};
        	$.ajax({
        		type : "POST",
        		url : "diabetic_retinopathy_manager_ajax.htm?ajaxSession=" + $("#sessionId").val(),
        		data : jsonData,
        		dataType : "json",
        		async : false,
        		success : function(result) {
        			 if ("true" == result[0].result){
        				 location.replace(location);
        			 }
        		}		
        	});
        	
        }
        /**
         * 去掉用户输入的多余的0
         * 
         * @param id
         */
        function checkZero(id) {
        	var str = $("#"+id).val().trim();
        	if ('' != str) {
        		var str1 = Number(str);
        		$("#"+id).val(str1); 
        	}
        }
        /**
         * 取系统时间
         */
        function  getSysDate(flg){
        	if(cloud){addcloud();}
			if (isSubmiting)
				return;
			isSubmiting = true;
			var jsonData = {
					"flg":3,//查询					
					"dateFlg":  $("#dateFlg").val(),
        };
        	$.ajax({
        		type : "POST",
        		url : "diabetic_retinopathy_manager_ajax.htm?ajaxSession=" + $("#sessionId").val(),
        		data : jsonData,
        		dataType : "json",
        		async : true,
        		success : function(result) {
        			 if ("true" == result[0].result){//查询成功时
        					var param = result[0].resultMsg.split(",");
        					 $("#searchUploadDateF").val(param[0]);
        				     $("#searchUploadDateT").val(param[1]);
        				     datetimepickerinit();
	        			 }
	        			 if(cloud){removecloud();cloud=false;}   			 
	        		},
					complete : function(XHR, TS) {
						isSubmiting = false;
						XHR = null;		
					}	
	        	});
        	};

     
	
//参数说明，comb下拉框名，val保存值的项目名
function checkSelect(comb,val){	
	var obj = document.getElementById(comb);
	
	if (obj === null) return;
	var vall = document.getElementById(val);
	if(vall=== null )return
	var value = vall.value;
	for(var i=0; i<obj.length; i++){
		if(obj[i].value == value){
			obj[i].selected = true;
			break;
		}
	}
}
function checkSelectObj(obj,value){	
	if (obj === null) return;
	for(var i=0; i<obj.length; i++){
		if(obj[i].value == value){
			obj[i].selected = true;
			break;
		}
	}
}
function checkSelectByText(comb,val){	
	var obj = document.getElementById(comb);
	if (obj === null) return;
	
	for(var i=0; i<obj.length; i++){
		if(obj[i].text == val){
			obj[i].selected = true;
			break;
		}
	}
}

function clearGrandsons(comb){
	var combs=comb.split(",");
	for(var i = 1;i < combs.length;i++)	{
		getChildCombSet(combs[i], combs[i-1]);
		checkSelectByValue(combs[i],"");
	}
}
function checkSelectByValue(comb,val){	
	var obj = document.getElementById(comb);	
	if (obj === null) return;
	for(var i=0; i<obj.length; i++){
		if(obj[i].value == val){
			obj[i].selected = true;
			break;
		}
	}
}
var hash = {};
//用来保存为显示的select元素 
//参数说明，cn子下拉框名，fn父下拉框名
function getChildCombSet(cn,fn){
	var obj = document.getElementById(cn);
	var value = document.getElementById(fn).value;
	var name = obj.id;
	var arraymeth=hash[name];
	if(arraymeth==undefined)arraymeth=new Array();
    if(value!==""){
	   
		if(arraymeth.length>0){
			showAll(obj,arraymeth);			
			arraymeth=new Array();
		}
	
		for(var i = obj.length-1;i > 0;i--)	{
			arraymeth.push(obj.options[i].cloneNode(true)); //把对象放入数组 
			if(obj.options[i].id!=value){
				obj.options.remove(i);
			}
		}
		hash[name]=arraymeth;
	}else{
		if(arraymeth.length==0){
			for(var i = obj.length-1;i > 0;i--)	{
				
				arraymeth.push(obj.options[i].cloneNode(true)); //把对象放入数组 
				obj.options.remove(i);
			}
		}else{
			for(var i = obj.length-1;i > 0;i--)	{
				obj.options.remove(i);
			}
		}
			
		
		hash[name]=arraymeth;
	}
}


//参数说明，cn子下拉框名，fn父下拉框名,qf 查找数据区分
function getCombSetFromDb(cn,fn,qf){
	var obj = document.getElementById(cn);
	//父code
	var value = document.getElementById(fn).value;
	//区分，区分查找内容 
	if (isSubmit || value=='')
		return;
	isSubmit = true;
	var url = "search.htm?ajaxSession="+$("#sessionId").val();
	var param = {
		"flg" : "11",
		"key" : qf+':'+value
	};
	jQuery.ajax({
		url : url,
		data : param,
		type : "POST",
		async: false,
		dataType : "json",
		success : function(rs) {
			isSubmit = false;
			if ("true" === rs[0].result) {
				
				var list =  eval(rs[0].list);
				for(var i = obj.length-1;i > 0;i--){ 
			    	obj.options.remove(i);
				}
				for(var i=0;i<list.length;i++){
					var objOption = new Option(list[i].text,list[i].value);
					obj.options.add(objOption);
				}
			}
		},
		error : function(rs) {
			isSubmit = false;
		}
	});
	
	
}


//参数说明，cn子下拉框名，fn父下拉框名,qf 查找数据区分
function getHospitalCombSetFromDb(cn,fn,qf){
	var obj = document.getElementById(cn);
	//父code
	var value = document.getElementById(fn).value;
	var allFlg=$("#allFlg").val();
	var agentId=$("#agentId").val();
	var agenterId=$("#agenterId").val();
	
	  
	//区分，区分查找内容 
	if (isSubmit)
	isSubmit = true;
	var url = "search.htm?ajaxSession="+$("#sessionId").val();
	var param = {
		"flg" : "13",
		"key" : qf+'#'+value+'#'+allFlg+'#'+agentId+'#'+agenterId
	};
	jQuery.ajax({
		url : url,
		data : param,
		type : "POST",
		async: false,
		dataType : "json",
		success : function(rs) {
			isSubmit = false;
			if ("true" === rs[0].result) {
				
				var list =  eval(rs[0].list);
				for(var i = obj.length-1;i > 0;i--){ 
			    	obj.options.remove(i);
				}
				for(var i=0;i<list.length;i++){
					var objOption = new Option(list[i].text,list[i].value);
					obj.options.add(objOption);
				}
			}
		},
		error : function(rs) {
			isSubmit = false;
		}
	});
	
	
}

//show显示Select的元素 
function showAll(obj,array){
	
	for(var i = obj.length-1;i > 0;i--){ 
		
    	obj.options.remove(i);
		
   }
	
    for(var i = array.length-1;i >=0;i--){ 
    	obj.options.add(array.pop());
   }
}

 // radio选中checked
 //@param radioName radio的name
 // @param valueId	当前value的ID
 
function checkRadio(radioName , valueId){
	var value = jQuery("#" + valueId).val();
	jQuery("input[name='"+ radioName +"']").each(function (){
		if(value == jQuery(this).val()){
			 jQuery(this).attr("checked",true);
		}
	});
}
String.prototype.startWith=function(str){     
	  var reg=new RegExp("^"+str);     
	  return reg.test(this);        
	}  



	String.prototype.endWith=function(str){     
	  var reg=new RegExp(str+"$");     
	  return reg.test(this);        
	} 
	
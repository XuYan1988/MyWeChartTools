var DbHashNm = {};
//取得名字
$(document).ready(function() {
	var listl = document.getElementsByTagName("label");
	var lists = document.getElementsByTagName("span");
	if(listl.length+lists.length>0){
					
		for(var i=0;i<listl.length;i++){
			if(listl[i].id==='getname'){
				getName(listl[i]);
			}else if(listl[i].id==='getnamedb'){
				getNameFromDb(listl[i]);
			}
		}
		
		for(var i=0;i<lists.length;i++){
			if(lists[i].id==='getname'){
				getName(lists[i]);
			}else if(lists[i].id==='getnamedb'){
				getNameFromDb(lists[i]);
			}
		}
	}
	} );
String.prototype.replaceAll = function(s1,s2) { 
return this.replace(new RegExp(s1,"gm"),s2); 
};

function getName(obj,nameList){
	var nameList=document.getElementById("name").value.replaceAll("{","").replaceAll("}","").split(",");	
	var title = obj.title;
	var nn =undefined;
	 for (var p = 0; p < nameList.length; p++) {
	   if(nameList[p].split("=")[0].replaceAll(" ","")===title){
		   nn = nameList[p].split("=")[1];
	   }
	 }
	 if(nn==undefined){
		 //var p = title.split("_");
		 //obj.innerText=p[p.length-1];
	 }else{
		 obj.innerText=nn;
	 }
	 obj.title='';
	
}
function getNameFromDb(obj,nameList){
	
	if (isSubmit || obj.title==null || obj.title=="")
		return;
	isSubmit = true;
	var up = document.getElementById("up");	
	if(up !== undefined && up !== null){
		up = up.value;
	}else{
		up="";
	}
	var h = DbHashNm[obj.title];
	if(h !== undefined && h !== null)
	{
		obj.innerText=h;
		obj.title='';	
		isSubmit = false;
	}else{
	var url = up+"search.htm?ajaxSession="+$("#sessionId").val();
	var param = {
		"flg" : "12",
		"key":obj.title
	};
	jQuery.ajax({
		url : url,
		data : param,
		type : "POST",
		dataType : "json",
		async: false,
		success : function(rs) {
			isSubmit = false;
			if ("true" === rs[0].result) {
				obj.innerText= rs[0].list;
			}else{				
				var p = obj.title.split("_");
				obj.innerText=p[p.length-1];
			}
			DbHashNm[obj.title]=obj.innerText;
		},
		error : function(rs) {
			isSubmit = false;
		}
	});
	 obj.title='';
	}
}
String.prototype.startWith=function(str){     
	  var reg=new RegExp("^"+str);     
	  return reg.test(this);        
	}  



	String.prototype.endWith=function(str){     
	  var reg=new RegExp(str+"$");     
	  return reg.test(this);        
	} 
	
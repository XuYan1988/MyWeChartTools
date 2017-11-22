var now = new Date($("#serviceDate").val()); // 今天
var nowDayOfWeek = now.getDay(); // 今天是周几
var nowDay = now.getDate(); // 今天是几号
var nowMonth = now.getMonth(); // 今天的月份
var nowYear = now.getYear(); // 今年的年份
nowYear += (nowYear < 2000) ? 1900 : 0; // 
var lastMonthDate = new Date(); // 上个月日期
lastMonthDate.setDate(1);
lastMonthDate.setMonth(lastMonthDate.getMonth() - 1);
var lastYear = lastMonthDate.getYear();// 上个月的年
var lastMonth = lastMonthDate.getMonth();// 上个月的月

// 格式化日期：yyyy-MM-dd
function formatDate(date) {
	var myyear = date.getFullYear();
	var mymonth = date.getMonth() + 1;
	var myweekday = date.getDate();

	if (mymonth < 10) {
		mymonth = "0" + mymonth;
	}
	if (myweekday < 10) {
		myweekday = "0" + myweekday;
	}
	return (myyear + "-" + mymonth + "-" + myweekday);
}
// 获得某月一共多少天(int)
function getMonthDays(myMonth) {
	var monthStartDate = new Date(nowYear, myMonth, 1);
	var monthEndDate = new Date(nowYear, myMonth + 1, 1);
	var days = (monthEndDate - monthStartDate) / (1000 * 60 * 60 * 24);
	return days;
}

//获得今天的日期(yyyy-MM-dd)
function getToday(){
var today = new Date(nowYear, nowMonth, nowDay); 
return formatDate(today); 
}
//获得昨天的日期(yyyy-MM-dd)
function getYesterday(){
var yesterday = new Date(nowYear, nowMonth, nowDay-1); 
return formatDate(yesterday); 
}
//获得本周周一的日期(yyyy-MM-dd)
function getWeekStartDate() { 
if(nowDayOfWeek == 0){
	nowDayOfWeek = 7;
}
var weekStartDate = new Date(nowYear, nowMonth, nowDay - nowDayOfWeek+1); 
return formatDate(weekStartDate); 
} 


//获得上周周一的日期(yyyy-MM-dd)
function getLastWeekStartDate() { 
	if(nowDayOfWeek == 0){
		nowDayOfWeek = 7;
	}
var lastweekStartDate = new Date(nowYear, nowMonth, nowDay - nowDayOfWeek-6); 
return formatDate(lastweekStartDate); 
} 

//获得上周周日的日期(yyyy-MM-dd)
function getLastWeekEndDate() { 
	if(nowDayOfWeek == 0){
		nowDayOfWeek = 7;
	}
var lastweekEndDate = new Date(nowYear, nowMonth, nowDay + (6 - nowDayOfWeek)-6); 
return formatDate(lastweekEndDate); 
} 

//获得本月一号的日期(yyyy-MM-dd)
function getMonthStartDate(){ 
var monthStartDate = new Date(nowYear, nowMonth, 1); 
return formatDate(monthStartDate); 
} 
//获得上月一号的日期(yyyy-MM-dd)
function getLastMonthStartDate(){ 
  var lastMonthStartDate;
  //如果本月处于1月 则年份也减1
  if(nowMonth == 0){
	      lastMonthStartDate = new Date(nowYear-1, lastMonth, 1); 
       }else{
	      lastMonthStartDate = new Date(nowYear, lastMonth, 1); 
     }
    return formatDate(lastMonthStartDate); 
} 
//获得上月月末的日期(yyyy-MM-dd)
function getLastMonthEndDate(){ 
	var lastMonthEndDate;
	//如果本月处于1月 则年份也减1
	if(nowMonth == 0){
		    lastMonthEndDate = new Date(nowYear-1, lastMonth, getMonthDays(lastMonth)); 
	    }else{
		    lastMonthEndDate = new Date(nowYear, lastMonth, getMonthDays(lastMonth)); 
	    }
   return formatDate(lastMonthEndDate); 
}

//获得去年一月一号 (yyyy-MM-dd)
function getLastYearStartDate(){
var lastYearStartDate = new Date(nowYear-1, 0, 1); 
return formatDate(lastYearStartDate); 
}
//获得去年十二月三十一日 (yyyy-MM-dd)
function getLastYearEndDate(){
var lastYearEndDate = new Date(nowYear-1, 11, 31); 
return formatDate(lastYearEndDate); 
}
//获得今年一月一号 (yyyy-MM-dd)
function getToYearStartDate(){
var toYearStartDate = new Date(nowYear, 0, 1); 
return formatDate(toYearStartDate); 
}
//时间大小判断
//ID1：起始显示日期 ID2：截止显示日期 ID3：截止日期里的隐藏日期
function checkdate(id1,id2,id3){
  	var data1 =$("#"+id1).val();
  	var data2 =$("#"+id2).val();
  	if(data2 != '' && data1 !=''){
  		if((Date.parse(data2)  <  Date.parse(data1)) === true ){
  			jAlert(lang('tw.date.greater'),lang('notice'),null);
  			$("#"+id2).val("");
  			$("#"+id3).val("");
  		}
  		
  	}
  }
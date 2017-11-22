var htmlVar = {
	'image' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(1);\" title='"+('see.image')+"'><img style='width:80px;height:80px;' src='./img/btn/image.png' /></a>",
	'video' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(2);\" title='"+('see.video')+"'><img style='width:80px;height:80px;' src='./img/btn/video.png' /></a>",
	'audio' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(3);\" title='"+('see.audio')+"'><img style='width:80px;height:80px;' src='./img/btn/audio.png' /></a>",
	'dicom' : "<a id='dicom-show' href='javascript:goView(4);' title='"+('see.dicom')+"'><img style='width:80px;height:80px;' src='./img/btn/dicom.png'/></a>",
	'noimage' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(1);\" title='"+('add.image')+"'><img style='width:80px;height:80px;' src='./img/btn/noimage.png' /></a>",
	'novideo' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(2);\" title='"+('add.video')+"'><img style='width:80px;height:80px;' src='./img/btn/novideo.png' /></a>",
	'noaudio' : "<a href= \"javascript:void(0);\" onclick=\"javascript:goView(3);\" title='"+('add.audio')+"'><img style='width:80px;height:80px;' src='./img/btn/noaudio.png' /></a>",
	'nodicom' : "<a id='dicom-show' href='javascript:void(0);' title='"+('see.undicom')+"'><img style='width:80px;height:80px;' src='./img/btn/nodicom.png' /></a>",
	'upload' : "<a id='dicom-upload' href='javascript:void(0);'title='"+('upload.diocm')+"'><img style='width:80px;height:80px;' src='./img/btn/upload.png' /></a><input type='file' style='display:none;' class='selectbtn2' name='file_input[]' id='file_input' multiple webkitdirectory />",
	'unopenImage' : "<a href= \"javascript:void(0);\" onclick=\"javascript:unopenView(1);\" title='"+('see.image')+"'><img style='width:80px;height:80px;' src='./img/btn/noimage.png' /></a>",
	'unopenVideo' : "<a href= \"javascript:void(0);\" onclick=\"javascript:unopenView(2);\" title='"+('see.video')+"'><img style='width:80px;height:80px;' src='./img/btn/novideo.png' /></a>",
	'unopenAudio' : "<a href= \"javascript:void(0);\" onclick=\"javascript:unopenView(3);\" title='"+('see.audio')+"'><img style='width:80px;height:80px;' src='./img/btn/noaudio.png' /></a>",
	'unopenDicom' : "<a href= \"javascript:void(0);\" onclick=\"javascript:unopenView(4);\" title='"+('see.dicom')+"'><img style='width:80px;height:80px;' src='./img/btn/nodicom.png' /></a>",
	'sr_has_audio_1' : "<audio controls src='{videoPath}'></audio><br/>",
	'sr_has_comment_1' : "<a href='javascript:void(0);' style='margin-left:10px;line-height: 10px;' class='btn btn-danger' onclick='comment(\"{srId}\",this)'>"
			+ ('wpj') + "</a>",
	'sr_has_comment_2' : "<a href='javascript:void(0);' style='margin-left:10px;line-height: 10px;' class='btn btn-success'>"
			+ ('ypj') + "</a>",
	'sr_has_pay_1' : "<a style='margin-left:10px;cursor: pointer;line-height: 10px;' class='btn btn-danger' onclick='pay(\"{billId}\",\"{srId}\",this)'>"
			+ ('qrfk') + "</a>",
	'sr_has_pay_2' : "<a style='margin-left:10px;cursor: pointer;line-height: 10px;' class='btn btn-success' >"
			+ ('sqrfk') + "</a>",
	'sr_has_pay_3' : "<a style='margin-left:10px;cursor: pointer;line-height: 10px;' class='btn btn-success' >"
			+ ('yfk') + "</a>",
	'recordSr' : "<fieldset><legend class='sr_legend'>{updateTime}{hasComment}{hasPay}</legend><div class='panel'>"
		+ "<div class='treat-for-each'  style=' background-image:url(\"./img/report.jpg\");background-repeat:no-repeat; background-size:cover;'><div class='doc-info'>"
		+ "<div class='doc-info' height='100px'><div class='divleft'><h3 class='f-yahei'><img src='./img/logo_s.png' style='width:200px;'></h3></div>" +
				"<div class='divright'><h3 class='f-yahei'><img src='./img/logo_d.png'></h3></div> </div>"
		+ "<br><br><br><div><h3 class='f-yahei text-center' width='30%'><b>"+('fe_medical_records_history.second')+"</b></h3></div>"
		+ "<hr class='line'/>"
		+ "<div><table class='mm'><tr><td width='30%'><label>"+('fe_medical_records_history.jcrq')+"</label>{visitTime}</td>" +
				"<td width='30%'><label>"+('fe_medical_records_history.bgrq')+"</label>{updateTime}</td>" +
						"<td width='40%'><label>"+( 'fe_medical_records_history.bh')+"</label>{reportId}</td></tr></table></div>"
		+ "<hr class='line'/>"
		+ "<div><table class='mm'><tr><td width='10px'></td><td width='30%'><label>"+('fe_medical_records_history.name')+"</label>{myName}</td>" +
				"<td width='30%'><label>"+('fe_medical_records_history.sex')+"</label>{myGender}</td>" +
						"<td width='40%'><label>"+('fe_medical_records_history.age')+"</label>{myAge}</td></tr></table></div>"
		+ "<hr class='line'/>"	
		+ "<div class='row doc-info'><div class='col-lg-10'><label>"
		+ ('sqnr')
		+ "</label><div style='margin-left:5px;word-wrap: break-word;word-break: break-all;'>{applyInfo}</div><span>{pAudioHtml}</span></div>"
		+ "</div><br><div class='row doc-info'><div class='col-lg-12'><label>"
		+ ('zdjg')
		+ "</label><div style='margin-left:5px;'>{recordMedicalDiagnosis}</div><span>{dAudioHtml}</span></div></div>"
		
		+ "<hr class='line'/>"
		+ "<div><table class='mm'><tr><td width='30%'><label>"
		+ ('fe_medical_records_history.diagnostician')
		+ "</label><a href='javascript:void(0);' title='"
		+ ('ysgrxx')
		+ "' onclick=\"javascript:showDoctorInfo('{doctorId}')\"><span class='doctorname' >{doctorName}</span></a></td><td width='30%'></td><td width='40%'> "+('fe_medical_records_history.zd')+"</td></tr></table></div>"		
		+ "<hr class='line' />"
		+ "</div></div></fieldset>",
	'recordSrForDoc' : "<fieldset><legend class='sr_legend'>{updateTime}{hasComment}{hasPay}</legend><div class='panel'>"
			+ "<div class='treat-for-each'  style=' background-image:url(\"./img/report.jpg\");background-repeat:no-repeat; background-size:cover;'><div class='doc-info'>"
			+ "<div class='doc-info' height='100px'><div class='divleft'><h3 class='f-yahei'><img src='./img/logo_s.png' style='width:200px;'></h3></div>" +
					"<div class='divright'><h3 class='f-yahei'><img src='./img/logo_d.png'></h3></div> </div>"
			+ "<br><br><br><div><h3 class='f-yahei text-center' width='30%'><b>"+('fe_medical_records_history.second')+"</b></h3></div>"
			+ "<hr class='line'/>"
			+ "<div><table class='mm'><tr><td width='30%'><label>"+('fe_medical_records_history.jcrq')+"</label>{visitTime}</td>" +
					"<td width='30%'><label>"+('fe_medical_records_history.bgrq')+"</label>{updateTime}</td>" +
							"<td width='40%'><label>"+( 'fe_medical_records_history.bh')+"</label>{reportId}</td></tr></table></div>"
			+ "<hr class='line'/>"
			+ "<div><table class='mm'><tr><td width='10px'></td><td width='30%'><label>"+('fe_medical_records_history.name')+"</label>{myName}</td>" +
					"<td width='30%'><label>"+('fe_medical_records_history.sex')+"</label>{myGender}</td>" +
							"<td width='40%'><label>"+('fe_medical_records_history.age')+"</label>{myAge}</td></tr></table></div>"
			+ "<hr class='line'/>"	
			+ "<div class='row doc-info'><div class='col-lg-10'><label>"
			+ ('sqnr')
			+ "</label><div style='margin-left:5px;word-wrap: break-word;word-break: break-all;'>{applyInfo}</div><span>{pAudioHtml}</span></div>"
			+ "</div><br><div class='row doc-info'><div class='col-lg-12'><label>"
			+ ('zdjg')
			+ "</label><div style='margin-left:5px;'>{recordMedicalDiagnosis}</div><span>{dAudioHtml}</span></div></div>"
			
			+ "<hr class='line'/>"
			+ "<div><table class='mm'><tr><td width='40%'><label>"
			+ ('fe_medical_records_history.diagnostician')
			+ "</label><span class='doctorname' >{doctorName}</span></td><td width='60%'><label>"
			+ ('fe_medical_records_history.hospital')
			+ "</label><span>{doctorOfHosiptal}</span></td></tr></table></div>"
			+"<hr class='line' />"
			+"<div><table class='mm'><tr><td><div style='margin-left:5px;word-wrap: break-word;word-break: break-all;'>"
			+('fe_medical_records_history.zd')
			+"</div></td></tr></table></div>"
			+ "<hr class='line' />"
			+ "</div></div></fieldset>",
	'search' : "<img style='widtd:24px; height:24px'  src='./img/search_btn/search1.jpg'>",
	'microphone' : "<font color='#c85305'>{param}</font>",
	'saved' : "<font color='#c85305'>"
			+ ('fe_recording.upload') + "</font>",
	'recording_nofind' : "<span style='color:#c85305;text-align:left;'>"
			+ ('fe_recording.nofind') + "</span>",
	'info' : "<span style='font-weight:lighter;color:#c85305;' id='resut'>"
			+ ('yzm1') + "</span>",
	'fe_doctor_find_delete' : "<a class='btn btn-primary' onclick='javascript:del('{id}','{name}');'>{name}&nbsp;&nbsp;X</a>",
	'edithtml' : "<div id='{id}'><audio controls='controls' src='{path}'></audio><span class='delclass' onclick=\"doConfirm("
			+ ('fe_records_report.sure')
			+ ",'deleteRecordingById','{id}')\">&nbsp;&nbsp;&nbsp;&nbsp;</span></div>",
	'binghanluyin' : "<audio src='{videoPath}' controls=''></audio>",
	'audioStr' : "<audio src='{videoPath}' controls></audio>",
	'patientunmodifyrecord' : "<div class='pd_photo'><a href='{imagePath}'  rel='gallery' class='pirobox_gall' ><img src='{imagePath}' alt=''/></a><p style='text-align:center;'>{newtime}</p><span class='delete' id='{imageId}'></span></div>",
	'doctornomodifyrecord' : "<div class='pd_photo'><a href='{imagePath}' rel='gallery' class='pirobox_gall' ><img src='{imagePath}' alt=''/></a><p style='text-align:center;'>{newtime}</p></div>",
	'patientnoapply' : "<div class='pd_photo' onclick='javascript:showDialog(1)'><img src='./img/btn/adda.jpg' alt='"
			+ ('fe_show_ivac.image') + "'/></div>",
	'patientundelete' : "<div class='pd_photo'><img src='./img/play.jpg' alt='"
			+ ('fe_show_ivac.image')
			+ "'/><p style='text-align:center;'>{newDate}</p><span class='delete' id='{videoId}'></span></div>",
	'doctornodelete' : "<div class='pd_photo'><img src='./img/play.jpg' alt='"
			+ ('fe_show_ivac.image')
			+ "'/><p style='text-align:center;'>{newDate}</p></div>",
	'patientunapply' : "<div class='pd_photo' onclick='javascript:showDialog(2)'><img src='./img/btn/adda.jpg' alt='"
			+ ('fe_show_ivac.image') + "'/></div>",
	'audioDiv' : "<div><img src='./img/btn/adda.jpg' alt='"
			+ ('fe_show_ivac.image')
			+ "' style='border: 7px solid #f9f9f9;border-bottom: 28px solid #f9f9f9;"
			+ "width: 170px;height: 170px;left:50px;top:50px;-moz-box-shadow: 1px 1px 5px #555;-webkit-box-shadow: 1px 1px 5px #555;box-shadow: 1px 1px 5px #555;"
			+ "-moz-border-radius: 4px;-webkit-border-radius: 4px;border-radius: 4px;width: 170px;height: 170px; cursor: pointer;' onclick='javascript:showDialog(3)'/></div>",
	'modify' : "<span id='loginForm.errors' class='error'>{resultMsg}</span>",
	'edit_art' : "<option value={value}>{CLASS}</option>",
	'htmlrecord' : "<tr><td>{text}</td><td>{siblings}</td><td>{accept} ~ {last}"
			+ ('day')
			+ "</td><td>"
			+ ('zfds')
			+ "</td><td>{somemore}</td><td>{mr-name}</td></tr>",
	'imageList':'<div class="image-content-list"><div class="image-btn-delete" title="删除">X<input type="hidden" value="{imageId}"/></div><a><img src="{imagePath}" style="height: 100px;width: 90px;" onerror="this.src=\'./img/not-find-img.jpg\'"/></a></div>',
	'videoDeleteBtn':"<div class='deleteBtn' style='float:right;padding-right:3px;background-color: rgb(33, 142, 216);'  title='删除'>X<input type='hidden' value='{value}' /></div>",
	'videoPlayer':"<div id='osmplayer'></div>",
	'audioDeleteBtn':"<b class='audio-delete-btn' title='删除'>X</b>",
	'audioList':"<li class='audio-list-li'><input type='hidden' value='{audioId}'/><a href='{audioPath}'>{audioName}&nbsp;&nbsp;&nbsp;&nbsp;{audioDate}</a></li>",
	'iframeStr':'<iframe id="iframe" src="" scrolling="auto"   style="width: 99%;min-height: 880px;border: 0px;"></iframe>',
	'BillList':"<iframe id='iframe' src='' style='width: 99%;  border: 0px; overflow: hidden;'></iframe>"
}

function htmlS(key) {
	return htmlVar[key];
}
/**
 * 模板格式化（正则替换）
 * 
 * @str html-templates html字符串模版 需替换的参数用{param}表示
 * @model 需替换的key value
 */
var FormatModel = function(str, model) {
	for ( var k in model) {
		var re = new RegExp("{" + k + "}", "g");
		str = str.replace(re, model[k]);
	}
	return str;
};
/**
 * 模板格式化（正则替换）
 * 
 * @str html-templates html字符串模版 需替换的参数用{param}表示
 * @model 需替换的key value
 */
var FormatModelByKey = function(key, model) {
	var str = htmlVar[key];
	for ( var k in model) {
		var re = new RegExp("{" + k + "}", "g");
		str = str.replace(re, model[k]);
	}
	return str;
};

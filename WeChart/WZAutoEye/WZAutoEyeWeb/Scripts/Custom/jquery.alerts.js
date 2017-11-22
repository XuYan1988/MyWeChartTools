// jQuery Alert Dialogs Plugin
//
// Version 1.1
//
// Cory S.N. LaViska
// A Beautiful Site (http://abeautifulsite.net/)
// 14 May 2009
//
// Visit http://abeautifulsite.net/notebook/87 for more information
//
// Usage:
//		jAlert( message, [title, callback] )
//		jConfirm( message, [title, callback] )
//		jPrompt( message, [value, title, callback] )
// 
// History:
//
//		1.00 - Released (29 December 2008)
//
//		1.01 - Fixed bug where unbinding would destroy all resize events
//
// License:
// 
// This plugin is dual-licensed under the GNU General Public License and the MIT License and
// is copyright 2008 A Beautiful Site, LLC. 
//
(function($) {
    var count = 0;
	$.alerts = {
		
		// These properties can be read/written by accessing $.alerts.propertyName from your scripts at any time
		
		verticalOffset: -75,                // vertical offset of the dialog from center screen, in pixels
		horizontalOffset: 0,                // horizontal offset of the dialog from center screen, in pixels/
		repositionOnResize: true,           // re-centers the dialog on window resize
		overlayOpacity: .01,                // transparency level of overlay
		overlayColor: 'rgb(51, 122, 183);',               // base color of overlay
		draggable: true,                    // make the dialogs draggable (requires UI Draggables plugin)
		//okButton: '&nbsp;确定&nbsp;',         // text for the OK button
		//cancelButton: '&nbsp;取消&nbsp;', // text for the Cancel button
		okButton: 'OK',         // text for the OK button
		cancelButton: 'Cancel', // text for the Cancel button
		dialogClass: null,                  // if specified, this class will be applied to all dialogs
		
		// Public methods
		
		alert: function(message, title, callback) {
			if( title == null ) title = 'Alert';
			$.alerts._show(title, message, null, 'alert', function(result) {
				if( callback ) callback(result);
			});
		},
		
		confirm: function(message, title, callback) {
			if( title == null ) title = 'Confirm';
			$.alerts._show(title, message, null, 'confirm', function(result) {
				if( callback ) callback(result);
			});
		},
			
		prompt: function(message, value, title, callback) {
			if( title == null ) title = 'Prompt';
			$.alerts._show(title, message, value, 'prompt', function(result) {
				if( callback ) callback(result);
			});
		},
		promptTA: function(message, value, title, callback) {
			if( title == null ) title = 'Prompt';
			$.alerts._show(title, message, value, 'promptTA', function(result) {
				if( callback ) callback(result);
			});
		},
		promptTAE: function(message, value, title, flg, callback) {
			if( title == null ) title = 'Prompt';
			$.alerts._show(title, message, value, 'promptTAE', function(result) {
				if( callback ) callback(result);
			});
		},
		myalert: function(message, value, title, callback) {
			if( title == null ) title = 'Prompt';
			$.alerts._show(title, message, value, 'myalert', function(result) {
				if( callback ) callback(result);
			});
		},		
		// Private methods
		
		_show: function(title, msg, value, type, callback) {
			
			$.alerts._hide();
			$.alerts._overlay('show');

		    if (count == 1) {
		        $("BODY").append(
			  '<div id="popup_container"  class="alert alert-info " >' +
			    '<h3 id="popup_title" class="btn btn-danger text-center" style="width:100%;border-radius:0px;margin-top:-1px;"/></h3>' +
			    '<div id="popup_content" class="text-center">' +
			      '<div id="popup_message" style="text-align:left;border-radius:0px;margin-bottom:20px;"></div>' +
				'</div>' +
			  '</div>');
		    } else {
		        $("BODY").append(
			  '<div id="popup_container"  class="alert alert-info " >' +
			    '<h3 id="popup_title" class="btn btn-danger text-center" style="width:100%;border-radius:0px;margin-top:-1px;"/></h3>' +
			    '<div id="popup_content" class="text-center">' +
			      '<div id="popup_message" style="text-align:center;border-radius:0px;margin-bottom:20px;"></div>' +
				'</div>' +
			  '</div>');
		    }


		    if( $.alerts.dialogClass ) $("#popup_container").addClass($.alerts.dialogClass);
			
			// IE6 Fix
			var pos = ($.browser && $.browser.msie && parseInt($.browser.version) <= 6 ) ? 'absolute' : 'fixed'; 
			
			$("#popup_container").css({
				position: pos,
				zIndex: 99999,
				padding: 0,
				margin: 0,
			});
			
			$("#popup_title").text(""+title);
			$("#popup_content").addClass(type);
			//$("#popup_message").text("<img src='./img/state/status_04.png'/>"+msg);
			$("#popup_message").text(msg);
			$("#popup_message").html( $("#popup_message").text().replace(/\n/g, '<br />') );
			
			/*$("#popup_container").css({
				minWidth: $("#popup_container").outerWidth(),
				maxWidth: $("#popup_container").outerWidth()
			});*/
			
			$.alerts._reposition();
			$.alerts._maintainPosition(true);
			
			switch( type ) {
				case 'alert'://2016-10-10 yel 修改，为了解决登录点击回车无法显示提示信息问题
					$("#popup_message").after('<div id="popup_panel"><input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.okButton + '" id="popup_ok1" /></div>');
					$("#popup_ok1").click( function() {
						if( callback ) callback(true);
						$.alerts._hide();
					});
					//$("#popup_ok").focus().keypress( function(e) {
					//	//if( e.keyCode == 13 || e.keyCode == 27 ) $("#popup_ok").trigger('click');
					//});
				break;
				case 'confirm':
					$("#popup_message").after('<div id="popup_panel"><input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.okButton + '" id="popup_ok" /> <input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.cancelButton + '" id="popup_cancel" /></div>');
					$("#popup_ok").click( function() {
						if( callback ) callback(true);
						$.alerts._hide();
					});
					$("#popup_cancel").click( function() {
						if( callback ) callback(false);
						$.alerts._hide();
					});
					$("#popup_ok").focus();
					$("#popup_ok, #popup_cancel").keypress( function(e) {
						//if( e.keyCode == 13 ) $("#popup_ok").trigger('click');
						if( e.keyCode == 27 ) $("#popup_cancel").trigger('click');
					});
				break;
				case 'prompt':
					$("#popup_message").append('<br /><input type="text" size="30" id="popup_prompt" />').after('<div id="popup_panel"><input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.okButton + '" id="popup_ok" /> <input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.cancelButton + '" id="popup_cancel" /></div>');
					$("#popup_prompt").width( $("#popup_message").width() );
					$("#popup_ok").click( function() {
						var val = $("#popup_prompt").val();
						if( callback ) callback( val );
						$.alerts._hide();
					});
					$("#popup_cancel").click( function() {
						if( callback ) callback( null );
						$.alerts._hide();
					});
					$("#popup_prompt, #popup_ok, #popup_cancel").keypress( function(e) {
						//if( e.keyCode == 13 ) $("#popup_ok").trigger('click');
						if( e.keyCode == 27 ) $("#popup_cancel").trigger('click');
					});
					if( value ) $("#popup_prompt").val(value);
					$("#popup_prompt").focus().select();
				break;
				case 'promptTA':
					$("#popup_message").append('<br /><textarea rows="3" cols="20" id="popup_prompt" style="background-color:#3F3F3F;"></textarea>').after('<div id="popup_panel"><input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.okButton + '" id="popup_ok" /> <input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.cancelButton + '" id="popup_cancel" /></div>');
					$("#popup_prompt").width( $("#popup_message").width() );
					$("#popup_ok").click( function() {
						var val = $("#popup_prompt").val();	
						if( callback ) callback( val );
	    				$.alerts._hide();		
					});
					$("#popup_cancel").click( function() {
						//if( callback ) callback( null );
						$.alerts._hide();
					});
					$("#popup_prompt, #popup_ok, #popup_cancel").keypress( function(e) {
						//if( e.keyCode == 13 ) $("#popup_ok").trigger('click');
						if( e.keyCode == 27 ) $("#popup_cancel").trigger('click');
					});
					if( value ) $("#popup_prompt").val(value);
					$("#popup_prompt").focus().select();
				break;
				case 'promptTAE':
					$("#popup_message").append('<br /><textarea rows="3" cols="20" id="popup_prompt" style="background-color:#3F3F3F;"></textarea>').after('<div id="popup_panel"><input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.okButton + '" id="popup_ok" /> <input type="button" class="btn btn-gray btn-sm lineHeight" value="' + $.alerts.cancelButton + '" id="popup_cancel" /></div>');
					$("#popup_prompt").width( $("#popup_message").width() );
					$("#popup_ok").click( function() {
						var val = $("#popup_prompt").val();	
						if(val == ''){
							$("#inputError").remove();
							$("#popup_message").append('<div style="color:red;" id="inputError">'+'Error'+'</div>');
						}else{
								if( callback ) callback( val );
								$.alerts._hide();
						}
					});
					$("#popup_cancel").click( function() {
						//if( callback ) callback( null );
						$.alerts._hide();
					});
					$("#popup_prompt, #popup_ok, #popup_cancel").keypress( function(e) {
						//if( e.keyCode == 13 ) $("#popup_ok").trigger('click');
						if( e.keyCode == 27 ) $("#popup_cancel").trigger('click');
					});
					if( value ) $("#popup_prompt").val(value);
					$("#popup_prompt").focus().select();
				break;
				case 'myalert':
					var btt = value.split(",");
					$("#popup_message").css({"padding":"0px","text-align":"center"});
					var buuut = '<div id="popup_panel">';
					for(var i=0;i<btt.length;i++){
						var idd="popbut"+i;
						if(i==0){
							idd='popup_ok';
						}else if(i==btt.length-1){
							idd='popup_cancel';
						}
						buuut+='<input type="button" class="btn btn-gray btn-sm lineHeight" value="' +btt[i] + '" id="'+idd+'" />&nbsp;&nbsp;';						
					}
					buuut+='</div>';
					$("#popup_message").after(buuut);

					$("#popup_cancel").click( function() {
						if( callback ) callback(btt.length);
						$.alerts._hide();
					});
					$("#popup_ok").click( function() {
						if( callback ) callback(1);
						$.alerts._hide();
					});
				    
					for(var i=1;i<btt.length-1;i++){
						var idd="popbut"+i;
						$("#"+idd).click( function() {
							if( callback ) callback(i);
							$.alerts._hide();
						});										
					}
					$("#popup_ok").focus();
					$("#popup_ok,#popup_cancel").keypress( function(e) {
						//if( e.keyCode == 13 ) $("#popup_ok").trigger('click');
						if( e.keyCode == 27 ) $("#popup_cancel").trigger('click');
					});
				break;

			}
			
			// Make draggable
			if( $.alerts.draggable ) {
				try {
					$("#popup_container").draggable({ handle: $("#popup_title") });
					$("#popup_title").css({ cursor: 'move' });
				} catch(e) { /* requires jQuery UI draggables */ }
			}
		},
		
		_hide: function() {
			$("#popup_container").remove();
			$.alerts._overlay('hide');
			$.alerts._maintainPosition(false);
		},
		
		_overlay: function(status) {
			switch( status ) {
				case 'show':
					$.alerts._overlay('hide');
					$("BODY").append('<div id="popup_overlay"></div>');
					$("#popup_overlay").css({
						position: 'absolute',
						zIndex: 99999,
						top: '0px',
						left: '0px',
						width: '100%',
						height: $(document).height(),
						background: $.alerts.overlayColor,
						opacity: $.alerts.overlayOpacity
					});
				break;
				case 'hide':
					$("#popup_overlay").remove();
				break;
			}
		},
		
		_reposition: function() {
			var top = (($(window).height() / 2) - ($("#popup_container").outerHeight() / 2)) + $.alerts.verticalOffset;
			var left = (($(window).width()  / 2) - ($("#popup_container").outerWidth() / 2)) + $.alerts.horizontalOffset;
			if( top < 0 ) top = 0;
			if( left < 0 ) left = 0;
			
			// IE6 fix
			if( $.browser && $.browser.msie && parseInt($.browser.version) <= 6 ) top = top + $(window).scrollTop();
			
			$("#popup_container").css({
				top: top + 'px',
				left: left + 'px'
			});
			$("#popup_overlay").height( $(document).height() );
		},
		
		
		_maintainPosition: function(status) {
			if( $.alerts.repositionOnResize ) {
				switch(status) {
					case true:
						$(window).bind('resize', $.alerts._reposition);
					break;
					case false:
						$(window).unbind('resize', $.alerts._reposition);
					break;
				}
			}
		}
		
	}
	
	// Shortuct functions
	jAlert = function(message, title, callback) {
		$.alerts.alert(message, title, callback);
	}
	
	
	jConfirm = function(message, title, callback) {
		$.alerts.confirm(message, title, callback);
	};
		
	jPrompt = function(message, value, title, callback) {
		$.alerts.prompt(message, value, title, callback);
	};
	jPromptTAE = function(message, value, title, flg, callback) {
		$.alerts.promptTAE(message, value, title, flg, callback);
	};
	jPromptTA = function(message, value, title, callback) {
		$.alerts.promptTA(message, value, title, callback);
	};
	jMyAlert = function(message, value, title, callback) {
		$.alerts.myalert(message, value, title, callback);
	};
	jAlertErr = function(message, title) {
		if(title==null)title='Error Msg';
		message="<font color=\'#c85305\'>"+message+"</font>";
		$.alerts.alert(message, title, null);
	};
	jAlertWarning = function (message, title) {
	    count = 1;
	    $.alerts.alert(message, title, null);
	};
})(jQuery);
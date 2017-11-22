var isDrag = false;
//一个手指拖动，两个手指放大
var mypic = null;
//当前的图片编号
var n = 0;
var x = 2;
//所有图片
//原始图片
var imgs_o = new Array();
//dicom图片
var imgs_d = new Array();
//备份的dicom图片
var imgs_dh = new Array();
//深度图片
var imgs_dc = new Array();

//误标
var imgs_ERR = new Array();

//漏标
var imgs_MIS = new Array();




//显示图片的区分
var flg_p = 0;

var flg_p_o = 0;

var flg_sdsc = 1;

var rfsdsc = ["", "", "2", "3"];

var rf = ["", "", "fundus.", "vessel.", "disc."];

var zoom = 1;
var ZS = 1;
var ZM = 10;

var img_l = 0;
var img_t = 0;

//触摸事件开始触发
function dragStart() {
    document.ontouchstart = function (e_move) {
        var eventStart = e_move || window.event;
        var element = e_move.srcElement || e_move.target;
        if (eventStart.targetTouches.length <=2) {
            mypic = new Array(4);
            mypic[0] = eventStart.targetTouches[0].clientX;
            mypic[1] = eventStart.targetTouches[0].clientY;
            mypic[2] = parseInt(element.style.left);
            mypic[3] = parseInt(element.style.top);
        }
    }
}
function drag(e) {
    var e = e || window.event;
    var element = e.srcElement || e.target;
    if (e.preventDefault)
        e.preventDefault();
    else
        e.returnvalue = false;
    isDrag = true;

    //判断是移动端还是PC端
    var browserType = false;
    var userAgentInfo = navigator.userAgent;
    var Agents = ["Android", "iPhone", "iPad", "iPod"];
    var flag = true;
    for (var v = 0; v < Agents.length; v++) {
        if (userAgentInfo.indexOf(Agents[v]) > 0) {
            browserType = true;
        }
    }

    if (browserType) {
        isDrag = true;
        element.ontouchend = function () {
            isDrag = false;
        }
        document.ontouchmove = function (e_move) {
            // 如果这个元素的位置内只有一个手指的话
            if (e_move.targetTouches.length<=2) {
                var touch = e_move.targetTouches[0];  // 把元素放在手指所在的位置
                if (isDrag) {
                    //图片左上角的x坐标
                    var x = touch.clientX - mypic[0] + mypic[2];
                    element.style.left = x + "px";
                    img_l = x;
                    //图片左上角的y坐标
                    var y = touch.clientY - mypic[1] + mypic[3];
                    element.style.top = y + "px";
                    img_t = y;
                    return false;
                }
            }
        }
    } else {
        var relLeft = e.clientX - parseInt(element.style.left);
        var relTop = e.clientY - parseInt(element.style.top);
        element.onmouseup = function () {
            isDrag = false;
        }
        document.onmousemove = function (e_move) {
            var e_move = e_move || window.event;
            if (isDrag) {
                //图片左上角的x坐标
                var x = e_move.clientX - relLeft;

                /*if(x<0){
                    x=0;
                }else if(x+40>($(window).width()-parseInt(element.width))){
                    x=$(window).width()-parseInt(element.width)-40;
                }*/
                element.style.left = x + "px";
                img_l = x;
                //图片左上角的y坐标

                var y = e_move.clientY - relTop;
                /*if(y<0){
                    y=0;
                }else if(y+70>($(window).height()-parseInt(element.height))){
                 y=$(window).height()-parseInt(element.height)-70;
                }*/
                element.style.top = y + "px";
                img_t = y;

                return false;
            }
        }
    }
}

function see(that, flg, flgpo) {
    img_l = 0;
    img_t = 0;
    zoom = 0;
    flg_p = flg;
    flg_p_o = flgpo;
    flg_sdsc = $("#twDeepV").val();
    setSdsc(flg_sdsc);
    getallimg(that);
    bind();

    //加载图片
    view();

    //隐藏母版页中的 container-top
    $('#container-top').css('display', 'none');

    //判断是否是手机端
    var browserType = false;
    var userAgentInfo = navigator.userAgent;
    var Agents = ["Android", "iPhone"];
    for (var v = 0; v < Agents.length; v++) {
        if (userAgentInfo.indexOf(Agents[v]) > 0) {
            browserType = true;
        }
    }
    if (browserType) {
        $(".header .left").remove();
    }
}

function getallimg(that) {

    imgs_o = new Array();
    //取得所有图片的url
    var l = $("[name=img_o]");
    for (var i = 0; i < l.length; i++) {
        imgs_o.push(l[i].src);
        if (flg_p <= 1 && that.src == l[i].src) {
            n = i;
        }
    }
    if (flg_p > 0) {
        imgs_d = new Array();
        //取得所有图片的url
        var l = $("[name=img_d]");

        for (var i = 0; i < l.length; i++) {
            imgs_d.push(l[i].src);
            if (flg_p > 1 && that.src == l[i].src) {
                n = i;
            }
        }
        imgs_dh = new Array();
        //取得所有图片的url
        var lh = $("[name=img_dh]");

        for (var i = 0; i < lh.length; i++) {
            imgs_dh.push(lh[i].src);
            if ((flg_p == 3 || flg_p == 4) && that.src == lh[i].src) {
                n = i;
            }
        }

        imgs_dc = new Array();
        //取得所有图片的url
        var lc = $("[name=img_dc]");

        for (var i = 0; i < lc.length; i++) {
            imgs_dc.push(lc[i].src);
            if (flg_p == 4 && that.src == lc[i].src) {
                n = i;
            }
        }



        //误标
        imgs_ERR = new Array();
        //取得所有图片的url
        var err = $("[name=img_ERR]");
        for (var i = 0; i < err.length; i++) {
            imgs_ERR.push(err[i].src);
            //n = i;
        }
        //漏标
        imgs_MIS = new Array();
        //取得所有图片的url
        var mis = $("[name=img_MIS]");
        for (var i = 0; i < mis.length; i++) {
            imgs_MIS.push(mis[i].src);
            //n = i;
        }

    }
}

function view(){
    //显示图片查看div
    $("#fig-viewer").show();
    var pic = "";
    //取得要显示图片的路径
    if (flg_p == 1) {
        pic = imgs_o[n];
    } else if (flg_p == 2) {
        pic = imgs_d[n];
    } else if (flg_p == 3) {
        if (x == 2) {
            pic = imgs_dh[0];
            n = 0;
        } else {
            pic = imgs_dh[n];
            x = 2;
        }

    } else if (flg_p ==5) {
        //误标
        pic = imgs_ERR[n];
    }else if (flg_p ==6) {
        //漏标
        pic = imgs_MIS[n];
    }else{
        if (x == 2) {
            pic = imgs_dh[1];
            n = 1;
        } else {
            pic = imgs_dh[n];
            x = 2;
        }

    }

if (pic == null || pic == '' || pic == 'undefined') {
    pic = "../Images/Custom/NoImage.jpg";
}

//显示
//$("#iv").attr("src", pic);
SImage(pic);


//显示组别
$("#bianhao").html("No." + (n + 1) + "");
//按钮激活
resetActive();

}

var Browser = new Object();
Browser.userAgent = window.navigator.userAgent.toLowerCase();
Browser.ie = /msie/.test(Browser.userAgent);
Browser.Moz = /gecko/.test(Browser.userAgent);
function SImage(url) {
    var img = new Image();
    //下载完毕之后的动作
    if (Browser.ie) {
        img.onreadystatechange = function () {
            if (img.readyState == "complete" || img.readyState == "loaded") {
                $("#iv").attr("src", url);
                //callback();
                //显示图片在div的中间
                setDivCenter("iv");
                //setImg2C(img);
                $("#lo").hide();
            }
        }
    } else if (Browser.Moz) {
        img.onload = function () {
            if (img.complete == true) {
                $("#iv").attr("src", url);
                //callback();
                //显示图片在div的中间
                setDivCenter("iv");
                //setImg2C(img);
                $("#lo").hide();
            }
        };
    }
    img.src = url;
    $("#lo").attr("src", "./app/imgview/loading.gif");
    $("#lo").show();
    $("#iv").hide();
}


function resetActive() {
    $("li").removeClass("active");
    if (flg_p == 1) {
        $(".yszp").addClass(" active");
    } else if (flg_p == 2) {
        $(".cxsc").addClass(" active");
    } else if (flg_p == 3) {
        $(".xgzp").addClass(" active");
    } else if (flg_p == 4) {
        $(".spzp").addClass(" active");
    }
    else if (flg_p == 5) {
        //误标
        $(".ERRTitle").addClass(" active");
    }
    else if (flg_p == 6) {
        //漏标
        $(".MISTitle").addClass(" active");
    }
     





}

function bind() {
    //判断是移动端还是PC端
    var browserType = false;
    var userAgentInfo = navigator.userAgent;
    var Agents = ["Android", "iPhone", "iPad", "iPod"];
    var flag = true;
    for (var v = 0; v < Agents.length; v++) {
        if (userAgentInfo.indexOf(Agents[v]) > 0) {
            browserType = true;
        }
    }

    //如果是移动端就把（眼底图像查看字，和编号）隐藏掉
    if (browserType) {
        $("#leftTile").hide();

    }

    if (browserType) {
        //安卓版拖动
        $("#iv").unbind("click").on("touchmove", drag);
        $("#iv").unbind("click").on("touchstart", dragStart);
    } else {
        //拖动
        $("#iv").unbind("click").on("mousedown", drag);
    }

    //关闭
    $(".close").unbind('click').on('click', function () {
        //隐藏图片查看div
        $("#fig-viewer").hide();
    });
    if (imgs_o.length > 1) {
        //切换组别
        $(".pre").unbind('click').on('click', function () {
            if (n - 1 < 0) {
                n = imgs_o.length;
            }
            n = n - 1;
            if (n == 0 && (flg_p == 3 || flg_p == 4)) {
                x = 0;
                flg_p = 3;
            } else if (n == 1 && (flg_p == 3 || flg_p == 4)) {
                x = 1;
                flg_p = 4;
            }
            view();
        });
        $(".pre").show();
        $(".next").unbind('click').on('click', function () {
            if (n + 1 > imgs_o.length - 1) {
                n = -1;
            }
            n = n + 1;
            if (n == 0 && (flg_p == 3 || flg_p == 4)) {
                x = 0;
                flg_p = 3;
            } else if (n == 1 && (flg_p == 3 || flg_p == 4)) {
                x = 1;
                flg_p = 4;
            }
            view();
        });
        $(".next").show();
    } else {
        $(".pre").hide();
        $(".next").hide();
    }






    $("#fv-zoom-min").unbind('click').on('click', function () {
        //if(zoom<=0)return;
        zoom = zoom - 1;
        if (zoom * ZS <= 0) {
            zoom = 0;
        }
        zoomImgByZoom();
    });
    $("#fv-zoom-max").unbind('click').on('click', function () {
        zoom = zoom + 1;
        if (zoom * ZS >= ZM ) {
            zoom = ZM / ZS;
        }
        zoomImgByZoom();
    });
    //照片切换
    if (imgs_o.length == 2 && (flg_p == 1 || flg_p == 2)) {
        if (flg_p_o == undefined || flg_p_o == "") {
            $(".yszp").unbind('click').on('click', function () {
                change(1);
            });
            $(".yszp").show();
            $(".cxsc").unbind('click').on('click', function () {
                change(2);
            });
            $(".cxsc").show();
            $(".ydtx").show();

            $(".xgzp").hide();
            $(".spzp").hide();
            $(".bztx").hide();
        } else {
            $(".yszp").unbind('click').on('click', function () {
                change(1);
            });
            $(".yszp").show();
            $(".ydtx").show();

            $(".xgzp").hide();
            $(".spzp").hide();
            $(".bztx").hide();
            $(".cxsc").hide();
        }
    } else if (imgs_o.length == 1 && (flg_p == 1 || flg_p == 2)) {
        if (flg_p_o == undefined || flg_p_o == "") {
            $(".yszp").unbind('click').on('click', function () {
                change(1);
            });
            $(".yszp").show();
            $(".cxsc").unbind('click').on('click', function () {
                change(2);
            });
            $(".cxsc").show();
            $(".ydtx").show();

            $(".xgzp").hide();
            $(".spzp").hide();
            $(".bztx").hide();
        } else {
            $(".yszp").unbind('click').on('click', function () {
                change(1);
            });
            $(".yszp").show();
            $(".ydtx").show();

            $(".xgzp").hide();
            $(".spzp").hide();
            $(".bztx").hide();
            $(".cxsc").hide();
        }
    }
    else if (imgs_o.length == 2 && (flg_p == 3 || flg_p == 4)) {
        $(".xgzp").unbind('click').on('click', function () {
            change(3);
        });
        $(".xgzp").show();
        $(".spzp").unbind('click').on('click', function () {
            change(4);
        });
        $(".spzp").show();
        $(".bztx").show();

        $(".yszp").hide();
        $(".cxsc").hide();
        $(".ydtx").hide();
        /*$(".xgzp").hide();
        $(".spzp").hide();*/
    } else {
        $(".xgzp").unbind('click').on('click', function () {
            change(3);
        });
        $(".xgzp").show();
        $(".bztx").show();
        //隐藏
        $(".spzp").hide();
        $(".yszp").hide();
        $(".cxsc").hide();
        $(".ydtx").hide();
    }

    //放大缩小体条
    $("#fv-zoom-sldr").unbind('click').bind("mousedown", zoomImg);

    if (imgs_ERR.length>0) {
        $(".ERRTitle").unbind('click').on('click', function () {
           
           
            //误标
            if (imgs_ERR.length > 1) {
                //切换组别
                $(".pre").unbind('click').on('click', function () {
                    if (n - 1 < 0) {
                        n = imgs_o.length;
                    }
                    n = n - 1;
                   // flg_p = 5;
                    view();
                });
                $(".pre").show();
                $(".next").unbind('click').on('click', function () {
                    if (n + 1 > imgs_o.length - 1) {
                        n = -1;
                    }
                    n = n + 1;
                    //flg_p = 5;
                    view();
                });
                $(".next").show();
            } else {
                n = 0;
                $(".pre").hide();
                $(".next").hide();
            }
            //误标
            change(5);
        });
        $(".ERRTitle").show();
    }
    else {
        $(".ERRTitle").hide();
    }

    if (imgs_MIS.length > 0) {
        $(".MISTitle").unbind('click').on('click', function () {
            //漏标
            if (imgs_MIS.length > 1) {
                //切换组别
                $(".pre").unbind('click').on('click', function () {
                    if (n - 1 < 0) {
                        n = imgs_MIS.length;
                    }
                    n = n - 1;
                    flg_p = 6;
                    view();
                });
                $(".pre").show();
                $(".next").unbind('click').on('click', function () {
                    if (n + 1 > imgs_MIS.length - 1) {
                        n = -1;
                    }
                    n = n + 1;
                    flg_p = 6;
                    view();
                });
                $(".next").show();
            } else {
                n = 0;
                $(".pre").hide();
                $(".next").hide();
            }
            //漏标
            change(6);

        });
        $(".MISTitle").show();

    } else {
        $(".MISTitle").hide();
    }
    



}

function change(i) {
    if (i!=5&&i!=6) {
        if (imgs_o.length > 1) {
            //切换组别
            $(".pre").unbind('click').on('click', function () {
                if (n - 1 < 0) {
                    n = imgs_o.length;
                }
                n = n - 1;
                if (n == 0 && (flg_p == 3 || flg_p == 4)) {
                    x = 0;
                    flg_p = 3;
                } else if (n == 1 && (flg_p == 3 || flg_p == 4)) {
                    x = 1;
                    flg_p = 4;
                }
                view();
            });
            $(".pre").show();
            $(".next").unbind('click').on('click', function () {
                if (n + 1 > imgs_o.length - 1) {
                    n = -1;
                }
                n = n + 1;
                if (n == 0 && (flg_p == 3 || flg_p == 4)) {
                    x = 0;
                    flg_p = 3;
                } else if (n == 1 && (flg_p == 3 || flg_p == 4)) {
                    x = 1;
                    flg_p = 4;
                }
                view();
            });
            $(".next").show();
        } else {
            $(".pre").hide();
            $(".next").hide();
        }
    }
    if (i == 3 || i == 4) {
        flg_p = i;
    }
    else {
        flg_p = (flg_p == i) ? 1 : i;
    }

    view();
}
//缩放
/**function zoomImg(o) {
    var zoom = parseInt(o.style.zoom, 10) || 100;
    zoom += event.wheelDelta / 50; //可适合修改
    if (zoom > 0)
        o.style.zoom = zoom + '%';
}*/
function zoomImgByZoom() {
    $("#fig-viewer-figs").css({ "transform": "scale(" + (zoom * 70 + 100) / 100 + "," + (zoom * 70 + 100) / 100 + ")", "-moz-transform": "scale(" + (zoom * 70 + 100) / 100 + "," + (zoom * 70 + 100) / 100 + ")", "-webkit-transform": "scale(" + (zoom * 70 + 100) / 100 + "," + (zoom * 70 + 100) / 100 + ")", "-o-transform": "scale(" + (zoom * 70 + 100) / 100 + "," + (zoom * 70 + 100) / 100 + ")", "-ms-transform": "scale(" + (zoom * 70 + 100) / 100 + "," + (zoom * 70 + 100) / 100 + ")" });
}

var isZoom = false;
function zoomImg(e) {
    var e = e || window.event;
    var element = e.srcElement || e.target;
    if (e.preventDefault)
        e.preventDefault();
    else
        e.returnvalue = false;
    isZoom = true;
    var left = parseInt(element.style.left);

    element.onmouseup = function () {
        isZoom = false;
    }
    document.onmousemove = function (e_move) {
        var e_move = e_move || window.event;
        if (isZoom) {
            //图片左上角的x坐标
            var x = parseInt(element.style.left);
            if (x < 0) {
                x = 0;
            } else if (x > parseInt(element.parentNode.offsetWidth)) {
                x = parseInt(element.parentNode.offsetWidth);
            }
            element.style.left = x + "px";


            return false;
        }
    }
}
function setDivCenter(id) {
    //$("#" + id).aeImageResize({ height: 700, width: 700 });
    var BL = $("#" + id).width() / $("#" + id).height();
    if (img_l == 0 && img_t == 0) {
        //while ($("#" + id).height() > $(window).height()||$("#" + id).width() > $(window).width()) {
        //    $("#" + id).height($("#" + id).height() - (10 + BL * $("#" + id).height() - $("#" + id).width())/BL);
        //    $("#" + id).width($("#" + id).width()-10);
        //}


        //根据浏览器的大小来设置图片的高和宽、
        if ($("#" + id).height() > $(window).height() || $("#" + id).width() > $(window).width()) {
            if ($(window).width() > $(window).height()) {
                //当屏幕的宽度大于高度
                var oneHeight = $("#" + id).height() - ($("#" + id).height() - $(window).height() + 10);
                var oneWith = oneHeight * BL;
                $("#" + id).height(oneHeight);
                $("#" + id).width(oneWith);

            } else {
                //当屏幕的宽度小于高度
                BL = $("#" + id).height()/$("#" + id).width();
                var oneWith = $("#" + id).width() - ($("#" + id).width() - $(window).width() + 10);
                var oneHeight = oneWith.BL;
                $("#" + id).height(oneHeight);
                $("#" + id).width(oneWith);
            }

        }

        var left = ($(window).width() - $("#" + id).width()) / 2;
        var scrollTop = $(document).scrollTop();
        var scrollLeft = $(document).scrollLeft();
        $("#" + id).css({
            position: 'absolute',
            'top': 50,
            left: left + scrollLeft
        }).show();
        img_l = left + scrollLeft;
        img_t = 50;
    } else {
        $("#" + id).css({
            position: 'absolute',
            'top': img_t,
            left: img_l
        }).show();
    }
}
function setImg2C(img) {
    var canvas = document.getElementById("ic");

    canvas.height = $(window).get(0).innerHeight - 300;

    var ctx = canvas.getContext("2d");
    var w = 0;
    if (img.width > $(window).width()) {
        w = img.width;
    }
    var left = ($(window).width() - w) / 2;
    var scrollLeft = $(document).scrollLeft();
    ctx.drawImage(img, 0, left + scrollLeft);
}

function sdsc(that, lv) {
    flg_sdsc = lv;
    $($("#sdsca")[0]).html($(that).text() + "<span class='caret'></span>");
    flg_p = 2;
    view();
}
function setSdsc(lv) {
    if (lv == null) {
        lv = 1;
    }
    flg_sdsc = lv;
    $($("#sdsca")[0]).html($($($("#sdsc")[0]).children()[lv - 1]).text() + "<span class='caret'></span>");
    //flg_p=2;

}

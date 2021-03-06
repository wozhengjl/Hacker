﻿//Common js/jquery function for Double color ball 
var preUrl = "http://localhost:61872";

function VerifyCode_Load(options) {
    var url = preUrl + '/DCBService.svc/GetVerifyCode?' + options.filter;

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: {},
        success: function (result) {
            result = result.d;
            options.callback(result);
        }
    });
}

function VerifyUserName(options) {
    var url = preUrl + '/DCBService.svc/CheckIfUserNameExist';

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: { userName:options.UserName, },
        success: function (result) {
            result = result.d;
            options.callback(result);
        }
    });
}

function GetRecords(options) {
    var url = preUrl + '/DCBService.svc/GetRecords';
    var params = {
        startDate: options.startDate, 
        endDate: options.endDate,
        state: options.state,
    };

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: $.toJSON(params),
        success: function (result) {
            result = result.d;
            if (result.Error != null) {
                options.failCallback();
            }
            else {
                options.succeedCallBack(result.Result);
            }
        }
    });
}

function AuthenticateUser(options) {
    var url = preUrl + '/DCBService.svc/AuthenticateUser';
    var params = {
        userName: options.userName,
        passWord: options.passWord,
    };

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        url: url,
        data: $.toJSON(params),
        success: function (result) {
            result = result.d;
            if (result.Result.IsAuthenticate) {
                options.succeedCallBack(result);
            }
            else {
                options.failCallback(result);
            }
        }
    });
}

function PostOrder(options) {
    var url = preUrl + '/Portal/Order.aspx';

    var params = {
        ordertype:options.type,
        orderdata: $.toJSON(options.data),
    };

    $.ajax({
        type: "POST",
        url: url,
        data: params,
        success: function (result) {
            options.succeedCallback();
        }
    });
}

(function ($) {
    $.DCB_Tip = function () {
        var xOffset = -10; // x distance from mouse
        var yOffset = 10; // y distance from mouse       

        $(".dcbtip").hover(
            function (e) {
                this.titletemp = this.title;
                this.title = '';
                var top = e.pageY + yOffset;
                var left = e.pageX + xOffset;

                $('body').append('<p id="dcbtip"><img id="dcbtipArrow" />' + this.titletemp + '</p>');

                $('p#dcbtip #dcbtipArrow').attr("src", './img/dcbtip_arrow.png');
                $('p#dcbtip').css("top", top + "px").css("left", left + "px").fadeIn("slow");

            },
            function () {
                this.title = this.titletemp;
                $("p#dcbtip").fadeOut("slow").remove();
            }
        ).mousemove(
            function (e) {
                var top = e.pageY + yOffset;
                var left = e.pageX + xOffset;

                $("p#dcbtip").css("top", top + "px").css("left", left + "px");
            }
        );
    };
})(jQuery);
<%@ Page Language="C#" MasterPageFile="./master/NavigationBar.master" Title="双色球选号" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="DoubleColor.Redballs.Portal.Order" %>

<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="./css/zebra_dialog.css" rel="stylesheet" type="text/css" />

    <link class="bootstrap library" rel="stylesheet" type="text/css" href="./bootstrap/css/bootstrap.min.css" />
    <script src="./js/jquery.json-2.4.min.js"></script>
    <script src="./js/DCBall.js"></script>
    <script src="./js/zebra_dialog.js"></script>

    <style type="text/css">
        .loginBox{width:420px;height:230px;padding:0 20px;border:1px solid #fff; color:#000; margin-top:40px; border-radius:8px;background: white;box-shadow:0 0 15px #222; background: -moz-linear-gradient(top, #fff, #efefef 8%);background: -webkit-gradient(linear, 0 0, 0 100%, from(#f6f6f6), to(#f4f4f4));font:11px/1.5em 'Microsoft YaHei' ;position: absolute;left:50%;top:50%;margin-left:-210px;margin-top:-115px;}
        .loginBox h2{height:45px;font-size:20px;font-weight:normal;}
        .loginBox .left{border-right:1px solid #ccc;height:100%;padding-right: 20px; }
        .loginBox input {
            height:30px;
        }
        .mydialogclass .ZebraDialog_Body { 
            height:220px;
        }

        .li {
            width: 33px;
            margin-right: 6px;
            float: left;
            text-align: center;
            height: 50px;
            line-height: 14px;
        }
        .redBallBox li a, .redBallBox li a:visited, .blueBallBox li a, .blueBallBox li a:visited {
            background: url(./img/newballs.png) 0 0 no-repeat;
            width: 33px;
            height: 33px;
            display: block;
            text-align: center;
            line-height: 34px;
            font-size: 16px;
            font-weight: bold;
            overflow: hidden;
            outline: 0;
            text-decoration: none;
        }

        a {
            color: black;
            text-decoration: none;
        }

        .redBallBox {
            width: 430px;
            padding-right: 34px;
            float: left;
        }
        ul {
            margin-top: 5px;
            margin-bottom: 5px;
         }
        .blueBallBox {
            width:234px;
            float:right;
        }

        .redBallBox li a:hover {
            background-position: -35px 0;
            color: #333;
            cursor: pointer;
        }
        .blueBallBox li a:hover {
            background-position: -105px 0;
            color: #333;
            cursor: pointer;
        }
        .redBallBox li a.active, .redBallBox li a.active:visited {
            background-position: -70px 0;
            color: #fff;
            cursor: pointer;
        }

        .blueBallBox li a.active, .blueBallBox li a.active:visited {
            background-position: -140px 0;
            color: #fff;
            cursor: pointer;
        }

        .selectInfo {
            height: 20px;
            clear: both;
            float: none;
            text-align: center;
        }

        .selectInfo span {
            background: #fff;
            padding: 0 10px;
            display: inline-block;
            position: relative;
            z-index: 10;
        }

        .selectInfo i {
            display: block;
            margin: -8px 15px 0 37px;
            height: 1px;
            border-top: 1px dotted #aeaeae;
            position: relative;
            z-index: 9;
        }

        #ballsSelectorDiv {
            width:700px; 
            height:600px; 
            margin-left:auto; 
            margin-right:auto; 
            margin-top:50px;
            border: 1px solid #d3d3d3; 
            padding:0px 0px 10px 0px;
        }

        .ballsContainer {
            width:100%; 
            height:250px; 
            clear: both; 
            float: none;
            overflow: hidden;
        }

        #buttonContainer {
            width:100%; 
            text-align: center;
        }

        #buttonContainer .okButton{
            width:138px; 
            height:35px; 
            background: url(./img/order-btn.png) no-repeat; 
            cursor: pointer;
        }

        #buttonContainer .disableButton {
            background-position: 0 -145px;
        }

        #buttonContainer .enableButton {
            background-position: 0 -111px;
        }

        #buttonContainer .confirmButton {
            background-position: 0 -525px;
        }

        #orderTableContainer {
            padding-left: 135px; 
            margin-top: 10px; 
            clear:both
        }

        #orderTableContainer .selectedlist {
            float: left; 
            border: 1px solid #b6b6b6;
            padding:0
        }

        .selectedlist dl.selectedarea {
            border-top: 1px solid #f1f1f1; 
            border-left: 1px solid #fafafa; 
            width: 430px; 
            height: 135px; 
            overflow-x: hidden; 
            overflow-y: scroll; 
            margin:0; 
            padding:0; 
            display:block
        }

        .selectedlist dl dt.ballsrow {
            display:block; 
            height: 26px; 
            line-height: 26px; 
            border-bottom: 1px dotted #aeaeae; 
            padding:0 5px; 
            clear: both; 
            width: 404px;
        }

        .selectedlist dl dt.ballsrowEditer {
            background-color: #ffeebf;
        }

        .selectedlist dl dt .ballstext {
            font-weight: bold; 
            float: left; 
            text-overflow: ellipsis; 
            overflow: hidden; 
            width: 195px; 
            white-space: nowrap; 
            color: #c4c4c4; 
            display:block;
        }

        .selectedlist dl dt .text {
            padding: 0 5px; 
            font-family: Simsun; 
        }

        .selectedlist dl dt .redballColor {
            color: rgb(186, 38, 54);
        }

        .selectedlist dl dt .blueballColor {
            color: rgb(30, 80, 162);
        }

        .selectedlist dl dt .buttonarea {
            float: right; display:block;
        }

        .selectedlist dl dt .button {
            margin: 0 3px;color: #717171;
        }

        .selectedlist dl dt .itemcost {
            float: right; 
            padding-right: 10px; 
            text-align: right; 
            display:block;
        }

        .selectedlist dl dt .countediter {
            height: 20px; 
            width: 73px; 
            display: inline-block; 
            border: 1px solid #abadb3; 
            position: relative; 
            top: 2px; 
            z-index: 50;
        }

        .selectedlist dl dt .counterbutton {
            width: 22px; 
            background: url(./img/order_icon.png) no-repeat; 
            display: inline-block; 
            height: 20px;
            font-family: Simsun; 
            font-size: 14px; 
            outline: 0; 
            float: left; 
            border-right: 1px solid #abadb3; 
            color: #333;
        }

        .selectedlist dl dt .addbutton {
            background-position: -119px 0; 
        }

        .selectedlist dl dt .minusbutton {
            background-position: -72px 0; 
        }

        .selectedlist dl dt .counterText {
            float: left;
            height: 20px; 
            line-height: 20px; 
            border: 0; 
            padding: 0; 
            width: 27px; 
            _width: 26px; 
            text-align: center;
        }

        .orderConfirmDiv {
            clear: both; 
            padding: 20px 0 15px;
        }

        .orderConfirmText {
            text-align: center; 
            height: 43px; 
            line-height: 43px;
        }

        .orderConfirmBtn {
            display: inline-block; 
            width: 146px; 
            height: 43px; 
            background: url(./img/order-btn.png) no-repeat; 
            cursor: pointer; 
            background-position: 0 -180px; 
            color: #333;
        }
    </style>
</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div id="ballsSelectorDiv">
        <div id="ballsdiv" class="ballsContainer" >
            <div id="redballsdiv" class="redBallBox"></div>
            <div id="blueballsdiv" class="blueBallBox"></div>
            <p class="selectInfo">
                <span>选号</span>
                <i></i>
            </p>
        </div>
        <div id="buttonContainer"></div>
        <form id="form1" action="Order.aspx" method="post">
            <div id="orderTableContainer">
                <div id="orderTable" class="selectedlist"></div>
                <input id="postorderdata" name="orderdata" type="hidden" />
                <button type="submit" id="submitorderbutton" style="display: none" />
            </div>
            <div id="orderConfirmDiv" class="orderConfirmDiv">
                <p class="orderConfirmText">
	                <span id="normalBtnBox"></span>
                </p>
            </div>
        </form>
    </div>

     <script>
         DoubleColorBall = new Object();
         DoubleColorBall.RenderPage = function () {
             InitialPage();

             function InitialPage() {
                 var redballsdiv = $("#redballsdiv");
                 var blueballsdiv = $("#blueballsdiv");
                 var ulred = $('<ul style="list-style:none">');
                 var ulblue = $('<ul style="list-style:none">');
                 var buttonContainer = $("#buttonContainer");
                 var orderCrmButtonDiv = $("orderConfirmDiv");
                 var redBalls = [];
                 var blueBalls = [];
                 var isConfirm = false;

                 var ordertable = $("#orderTable").DCB_Tables(
                     {
                         editCallback: function (inputRedballs, inputBlueBalls) {
                             redBalls = [];
                             blueBalls = [];
                             isConfirm = true;
                             selectBalls(inputRedballs, true, redBalls);
                             selectBalls(inputBlueBalls, false, blueBalls);

                             checkEnableOkButton(redBalls, blueBalls);
                         },
                     });

                 $('<button type="button" class="okButton disableButton"></button>')
                     .click(function () {
                         var $this = $(this);
                         if ($this.hasClass('enableButton') || $this.hasClass('confirmButton')) {
                             redballsdiv.find("a").removeClass("active");
                             blueballsdiv.find("a").removeClass("active");
                             ordertable.addRow(redBalls, blueBalls);
                             redBalls = [];
                             blueBalls = [];
                             isConfirm = false;

                             buttonContainer.find("button").removeClass('enableButton');
                             buttonContainer.find("button").removeClass('confirmButton');
                             buttonContainer.find("button").addClass('disableButton');
                         }
                     })
                     .appendTo(buttonContainer);

                 function checkEnableOkButton(redballs, blueballs) {
                     if (redballs.length == 6 && blueballs.length == 1) {
                         buttonContainer.find("button").removeClass('disableButton');
                         buttonContainer.find("button").removeClass('enableButton');
                         buttonContainer.find("button").removeClass('confirmButton');
                         if (isConfirm) {
                             buttonContainer.find("button").addClass('confirmButton');
                         }
                         else {
                             buttonContainer.find("button").addClass('enableButton');
                         }
                     }
                     else {
                         buttonContainer.find("button").removeClass('enableButton');
                         buttonContainer.find("button").removeClass('confirmButton');
                         buttonContainer.find("button").addClass('disableButton');
                     }
                 }

                 function selectBalls(inputBalls, isRedBall, ouputBalls) {
                     $(inputBalls).each(function (index) {
                         var ballNo = inputBalls[index];
                         var ballIdPrefix = "#redball";
                         var maxCount = 6;
                         if (!isRedBall) {
                             ballIdPrefix = "#blueball";
                             maxCount = 1;
                         }

                         if ($(ballIdPrefix + ballNo).hasClass("active")) {
                             $(ballIdPrefix + ballNo).removeClass("active");
                             ouputBalls.splice($.inArray($(ballIdPrefix + ballNo).text(), ouputBalls), 1);
                         }
                         else {
                             if (ouputBalls.length == maxCount) {
                                 alert("最多选" + maxCount + "个");
                                 return;
                             }
                             $(ballIdPrefix + ballNo).addClass("active");
                             ouputBalls.push($(ballIdPrefix + ballNo).text());
                         }
                     });
                 }

                 for (var i = 1; i <= 33; i++) {
                     var li = $('<li class="li"> </li>');
                     var ballNo = i < 10 ? "0" + i : i;

                     $('<a id="redball' + ballNo + '">' + ballNo + '</a>', { id: "redball" + ballNo }).click(function () {
                         var $this = $(this);
                         var inputBalls = [];
                         inputBalls.push($this[0].id.substr(7));

                         selectBalls(inputBalls, true, redBalls);
                         checkEnableOkButton(redBalls, blueBalls);

                     }).appendTo(li);

                     li.appendTo(ulred);
                 }

                 for (var i = 1; i <= 16; i++) {
                     var li = $('<li class="li"> </li>');
                     var ballNo = (i < 10 ? "0" + i : i);

                     $('<a id="blueball' + ballNo + '">' + ballNo + '</a>', { id: "blueball" + ballNo }).click(function () {
                         var $this = $(this);
                         var inputBalls = [];
                         inputBalls.push($this[0].id.substr(8));

                         selectBalls(inputBalls, false, blueBalls);

                         checkEnableOkButton(redBalls, blueBalls);
                     }).appendTo(li);

                     li.appendTo(ulblue);
                 }

                 ulred.appendTo(redballsdiv);
                 ulblue.appendTo(blueballsdiv);

                 $('#normalBtnBox').append(
                     $('<a class="orderConfirmBtn" title="立即投注"></a>').click(function () {
                         if (!Master.IsLogin()) {
                             var html = '<div class="container"> \
                                        <section class="loginBox row-fluid"> \
                                          <section class="span7 left"> \
                                            <h2>用户登录</h2> \
                                            <p><input type="text" id="username" /></p> \
                                            <p><input type="text" id="password" /></p> \
                                            <section class="row-fluid"> \
                                              <section class="span8 lh30"><label><input type="checkbox" name="rememberme" />下次自动登录</label></section> \
                                              <section class="span1"><input type="button" id="logonbutton" value=" 登录 " class="btn btn-primary"></section> \
                                            </section> \
                                          </section> \
                                          <section class="span5 right"> \
                                            <h2>没有帐户？</h2> \
                                            <section> \
                                              <p>如果当前没有账号，请注册新的账户...</p> \
                                              <p><input type="button" id="register" value=" 注册 " class="btn"></p> \
                                            </section> \
                                          </section> \
                                        </section> \
                                    </div>';

                             var dialog = $.Zebra_Dialog(html, {
                                 'custom_class': 'mydialogclass',
                                 'buttons': ['取消'],
                                 'width': '420',
                             });

                             $('#logonbutton').click(function () {
                                 var userName = $('#username').val();
                                 var passWord = $('#password').val();
                                 AuthenticateUser(
                                     {
                                         userName: userName,
                                         passWord: passWord,
                                         succeedCallBack: function ()
                                         {
                                             dialog.close();
                                             Master.UpdateUserName(userName);
                                             Master.UpdateUI();

                                             var orderData = ordertable.getOrderData();
                                             if (orderData.length > 0) {
                                                 var params = {
                                                     type: 1,
                                                     data: orderData
                                                 }
                                                 var data = $.toJSON(params);
                                                 $('#postorderdata').val(data);
                                                 $('#submitorderbutton').click();
                                             }
                                         },
                                         failCallBack: function ()
                                         {

                                         },
                                     });
                             });
                         }
                         else {
                             var orderData = ordertable.getOrderData();
                             if (orderData.length > 0) {
                                 var params = {
                                     type: 1,
                                     data: orderData
                                 }
                                 var data = $.toJSON(params);
                                 $('#postorderdata').val(data);
                                 $('#submitorderbutton').click();
                             }
                         }
                     })
                 );
             }
         }

         $(document).ready(function () {
             DoubleColorBall.RenderPage();
         });

         (function ($) {
             $.fn.DCB_Tables = function (options) {
                 var editRowNo = -1;

                 this.getOrderData = function () {
                     var orderData = [];

                     table.find('dt').each(function () {
                         var redballs = $(this).find("#redballs").eq(0).text();
                         var blueballs = $(this).find("#blueballs").eq(0).text();
                         var count = $(this).find(".counterText").eq(0).val();
                         var orderitem = {
                             OrderData: [redballs, blueballs].join(";"),
                             Count: count,
                         }

                         orderData.push(orderitem);
                     });

                     return orderData;
                 }

                 this.addRow = function (redballs, blueballs) {
                     if (editRowNo != -1) {
                         table.find('dt').eq(editRowNo).find("#redballs").eq(0).text(redballs.join(" "));
                         table.find('dt').eq(editRowNo).find("#blueballs").eq(0).text(blueballs.join(" "));
                         table.find('dt').eq(editRowNo).removeClass("ballsrowEditer");
                         editRowNo = -1;

                         return;
                     }

                     var row = $('<dt class="ballsrow"></dt>');
                     var ballstextSpan = $('<span class="ballstext"></span>').text("|");
                     $('<strong id="redballs" class="text redballColor"></strong>').text(redballs.join(" ")).prependTo(ballstextSpan);
                     $('<strong id="blueballs" class="text blueballColor"></strong>').text(blueballs.join(" ")).appendTo(ballstextSpan);
                     ballstextSpan.appendTo(row);

                     var ballediterSpan = $('<span class="buttonarea"></span>');
                     $('<a href="#" class="button">修改</a>').click(function () {
                         var redballs = row.find("#redballs").eq(0).text().split(" ");
                         var blueballs = row.find("#blueballs").eq(0).text().split(" ");

                         row.addClass("ballsrowEditer");

                         editRowNo = row.prevAll().length;

                         options.editCallback(redballs, blueballs);
                     }).appendTo(ballediterSpan);

                     $('<a href="#" class="button">删除</a>').click(function () {
                         if (editRowNo == row.prevAll().length) {
                             editRowNo = -1;
                         }
                         row.remove();
                     }).appendTo(ballediterSpan);
                     ballediterSpan.appendTo(row);

                     var counterSpan = $('<span class="countediter"></span>');
                     $('<a href="#" rel="nofollow" class="counterbutton minusbutton"></a>').click(function () {
                         var count = $(this).parent().find("input").val();
                         var countUI = count > 1 ? parseInt(count) - 1 : 1;
                         $(this).parent().find("input").val(countUI);
                         $('#itemcost').html(2 * countUI + "元");
                     }).appendTo(counterSpan);
                     $('<input type="text" class="counterText"></input>').val(1).appendTo(counterSpan);
                     $('<a href="#" rel="nofollow" class="counterbutton addbutton"></a>').click(function () {
                         var count = $(this).parent().find("input").val();
                         var countUI = parseInt(count) + 1;
                         $(this).parent().find("input").val(countUI);
                         $('#itemcost').html(2 * countUI + "元");
                     }).appendTo(counterSpan);
                     counterSpan.appendTo(row);

                     $('<span id="itemcost" class="itemcost"></span>').html("2元").appendTo(row);

                     row.appendTo(table);
                 };

                 var table = $('<dl class="selectedarea"></dl>').appendTo(this);
                 return this;
             };
         })(jQuery)
    </script>
</asp:Content>
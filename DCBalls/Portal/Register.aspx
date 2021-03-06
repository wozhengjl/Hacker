﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="./master/NavigationBar.master" Title="注册-个人用户" CodeFile="Register.aspx.cs" Inherits="DoubleColor.Redballs.Portal.Register" %>

<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="./css/DCBall.css" rel="stylesheet" type="text/css" />

    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script src="./js/DCBall.js"></script>

    <style type="text/css">
        body {
            background-color:#f2f2f2;
        }
        
        .header-fix {
            background: #4d545d;
            border-top: 0 solid #4d5765;
            position: fixed;
            width: 100%;
            top: 0;
            left: 0;
            height: 33px;
            box-shadow: 0 3px 3px rgba(67,76,89,0.4);
        }

        .logo {
            position:fixed;
            top:2px;
        }
        .header {
            margin-right: auto;
            margin-left: auto;
            clear: both;
            width: 960px;
            height: 46px;
            margin: 0 auto;
            zoom: 1;
        }
        .custom-header {
            height: 30px;
            line-height: 30px;
            float: right;
        }
        .form {
            width:700px;
            margin-top:100px;
            margin-bottom:auto;
            margin-right: auto; 
            margin-left: auto;
            height:380px;
            background:#FFF;
        }
        .item {
            padding-top:9px;
            height:60px;
            width:650px;
            line-height:34px;
        }

        .inputdiv {
            display:inline-block;
            width:490px;
        }
        .text {
            width: 270px;
            height: 35px;
            border: 1px solid #cccccc;
            font-size: 14px;
            font-family: arial,"宋体";
            color: #999;
        }

        .errortext {
            margin-left:10px;
            width: 200px;
            height: 34px;
            border: 1px solid #ffbdbe;
            font-size: 14px;
            font-family: arial,"宋体";
            color:red;
            display:inline-block;
            background-color:#ffbdbe;
        }

        .text-1{
            width:120px;
        }

        .label {
            width:150px;
            text-align:right;
            font-size:14px;
            color:#999;
            padding-right:10px;
            display:inline-block;
        }

        .label b{
            font-family:arial,"宋体";
            margin-right:5px;
            font-weight:normal;
        }
        .textcolor{
            color:#F00;
        }
        
        .btn-regist{
            width:270px;
            height:40px;
            color:#FFF;
            font-family:"微软雅黑";
            font-size:16px;
            text-indent:-9999px;
            font-weight:800;
            overflow:hidden;
            background:url(img/regist-btn.jpg) no-repeat;
        }
    </style>
</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" class="form" action="Register.aspx" method="post" >
        <div id="formdiv" style="padding:20px 20px 20px 20px">
            <div id="account-name" class="item"></div>

            <div id="account-password" class="item"></div>

            <div id="password-confirmed" class="item"></div>

            <div id="verification-code" class="item"></div>

            <div id="div-registerbutton" class="item"></div>
        </div>
    </form>
    <script>
        Register = new Object();

        Register.RenderPage = function () {
            InitialPage();

            function InitialPage() {
                var verifyCode;
                var isNameValidated = true;

                function UpdateVerifyCode(code) {
                    verifyCode = code;
                }

                function ValidateUserName(userName) {
                    if (userName == "邮箱/用户名/手机号") {
                        isNameValidated = false;
                        $("#accountIndicator").text("用户名为空");
                        $("#accountIndicator").show();
                    }
                    else {
                        VerifyUserName(
                        {
                            UserName: userName,
                            callback: function (isExist) {
                                if (isExist) {
                                    isNameValidated = false;
                                    $("#accountIndicator").text("用户名已被占用");
                                    $("#accountIndicator").show();
                                }
                                else {
                                    isNameValidated = true;
                                    $("#accountIndicator").hide();
                                }
                            },
                        });

                        $("#accountIndicator").hide();
                    }

                    return isNameValidated;
                }

                var accountName = $("#account-name");
                $('<span class="label">').append($('<b class="textcolor">*</b>')).append('账户名：').appendTo(accountName);
                $('<div class="inputdiv">').append(
                    $('<input type="text" id="accountName" name="accountName" class="text" value="邮箱/用户名/手机号">')
                    .attr('title', "请输入邮箱/用户名/手机号")
                    .addClass('dcbtip')
                    .focus(function () {
                        if (this.value == '邮箱/用户名/手机号') {
                            this.value = '';
                            this.style.color = '#333'
                        }
                    })
                    .blur(function () {
                        if (this.value == '') {
                            this.value = '邮箱/用户名/手机号';
                            this.style.color = '#999999'
                        }

                        ValidateUserName(this.value);
                    })
                )
                .append($('<label id="accountIndicator" class="errortext" style="display:none" >用户名已被占用或用户名为空</label>'))
                .appendTo(accountName);

                function ValidatePassword(password) {
                    if (password.length < 6 || password.length > 20) {
                        $("#pwdIndicator").show();
                        return false
                    }

                    $("#pwdIndicator").hide();
                    return true;
                }

                var accountPwd = $("#account-password");
                $('<span class="label"></span>').append('<b class="textcolor">*</b>').append('请设置密码：').appendTo(accountPwd);
                $('<div class="inputdiv"></div>')
                    .append(
                        $('<input type="password" id="passWord" name="passWord" class="text" />')
                        .attr('title', "6-20位字符，可使用字母、数字或符号的组合，不建议使用纯数字，纯字母，纯符号")
                        .addClass('dcbtip')
                        .blur(function () {
                            ValidatePassword(this.value);
                        }))
                    .append($('<label id="pwdIndicator" class="errortext" style="display:none" >密码长度只能在6-20位之间</label>'))
                    .appendTo(accountPwd);

                function ValidatePasswordConfirmed(password) {
                    if (password != accountPwd.find('input').eq(0).val()) {
                        $("#pwdConfirmIndicator").show();
                        return false;
                    }

                    $("#pwdConfirmIndicator").hide();
                    return true;
                }

                var accountPwdConfrm = $("#password-confirmed");
                $('<span class="label"></span>').append('<b class="textcolor">*</b>').append('确认密码：').appendTo(accountPwdConfrm);
                $('<div class="inputdiv"></div>').append(
                    $('<input type="password" id="passWordConfirm" class="text" />')
                         .attr('title', "请再次输入密码")
                        .addClass('dcbtip')
                        .blur(function () {
                            ValidatePasswordConfirmed(this.value);
                        }))
                 .append($('<label id="pwdConfirmIndicator" class="errortext" style="display:none" >两次输入密码不一致</label>'))
                 .appendTo(accountPwdConfrm);

                function ValidateVerifyCode() {
                    if (verifyCode && $("#vercode").val()
                                   && verifyCode == $("#vercode").val()) {
                        return true;
                    }

                    alert("验证码不匹配");
                    return false;
                }

                var vryficationCode = $("#verification-code");
                $('<span class="label"></span>').append('<b class="textcolor">*</b>').append('验证码：').appendTo(vryficationCode);
                $('<div class="inputdiv"></div>').append('<input type="text" id="vercode" name="vercode" class="text text-1" />')
                    .append($('<label style="margin-left:20px"></label>').append(
                        $('<img id="vercodeimage" src="#" />').click(function () {
                            getVryCodeImg(UpdateVerifyCode);
                        })
                    ))
                    .append($('<div id="vrfycoderefreshdiv" style="margin-left:40px; display:inline-block"></div>')
                        .append($('<label style="color:#999;font-size:15px"></label>').append('看不清？')
                        .append($('<a href="#" style="color:#005aa0"></a>')
                            .click(function () {
                                getVryCodeImg(UpdateVerifyCode);
                            })
                            .text("换一张")
                        )))
                .appendTo(vryficationCode);

                var registerBtn = $("#div-registerbutton");
                $('<span class="label"> </span>').appendTo(registerBtn);
                $('<div class="inputdiv"></div>')
                    .append($('<input type="submit" id="registerbutton" value="立即注册" class="btn-regist" />')
                            .click(function () {
                                var validated = ValidateUserName($("#accountName").val())
                                                && ValidatePassword($("#passWord").val())
                                                && ValidatePasswordConfirmed($("#passWordConfirm").val())
                                                && ValidateVerifyCode()
                                                && isNameValidated;

                                return validated;
                            }))
                .appendTo(registerBtn);

                getVryCodeImg(UpdateVerifyCode);

                $.DCB_Tip();
            }

            function getVryCodeImg(callback) {
                var numkey = Math.random();
                numkey = Math.round(numkey * 10000);
                VerifyCode_Load({
                    filter: "height=35&width=70&k=" + numkey,
                    callback: function (VerifyCodeSource) {
                        $("#vercodeimage").attr('src', VerifyCodeSource.Base64Image);
                        callback(VerifyCodeSource.VerifyCode);
                    }
                });
            }
        };

        $(document).ready(function () {
            Register.RenderPage();
        });
    </script>
</asp:Content>
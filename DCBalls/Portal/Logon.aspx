<%@ Page Language="C#" MasterPageFile="./master/NavigationBar.master" Title="登陆" AutoEventWireup="true" CodeFile="Logon.aspx.cs" Inherits="DoubleColor.Redballs.Portal.Logon" %>

<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="./css/DCBall.css" rel="stylesheet" type="text/css" />
    <script src="./js/DCBall.js"></script>

        <style type="text/css">
        body{
            background:#f2f2f2;
        }
        .logonform {
            width:700px;
            margin-top:100px;
            margin-bottom:auto;
            margin-right: auto; 
            margin-left: auto;
            height:240px;
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
        
        .btn-logon{
            width:270px;
            height:40px;
            color:#FFF;
            font-family:"微软雅黑";
            font-size:16px;
            text-indent:-9999px;
            font-weight:800;
            overflow:hidden;
            background:url(img/login-all-bg.png) no-repeat -20px -61px;
        }
    </style>
</asp:Content>

<asp:Content id="ContentPlaceHolder2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" class="logonform" action="Logon.aspx" method="post" >
        <div id="formdiv" style="padding:20px 20px 20px 20px">
            <div id="account-name" class="item"></div>

            <div id="account-password" class="item"></div>

            <div id="div-registerbutton" class="item"></div>
        </div>
    </form>

    <script>
        Register = new Object();

        Register.RenderPage = function () {
            InitialPage();

            function InitialPage() {
                function ValidateUserName(userName) {
                    if (userName == "邮箱/用户名/手机号") {
                        isNameValidated = false;
                        $("#accountIndicator").text("用户名为空");
                        $("#accountIndicator").show();
                        return false;
                    }
                    else {
                        $("#accountIndicator").hide();
                        return true;
                    }
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
                $('<span class="label"></span>').append('<b class="textcolor">*</b>').append('密码：').appendTo(accountPwd);
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

                var logonBtn = $("#div-registerbutton");
                $('<span class="label"> </span>').appendTo(logonBtn);
                $('<div class="inputdiv"></div>')
                    .append($('<input type="submit" id="registerbutton" value="登陆" class="btn-logon" />')
                            .click(function () {
                                var validated = ValidateUserName($("#accountName").val())
                                                && ValidatePassword($("#passWord").val());

                                return validated;
                            }))
                .appendTo(logonBtn);
            };
        }

        $(document).ready(function () {
            Register.RenderPage();
        });
    </script>
</asp:Content>
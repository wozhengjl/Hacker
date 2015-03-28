<%@ Page Title="账户资料" Language="C#" MasterPageFile="~/Portal/master/NavigationBar.master" AutoEventWireup="true" CodeFile="SecurityInfo.aspx.cs" Inherits="DoubleColor.Redballs.Portal.SecurityInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .input-item {
            margin:10px 5px 15px 20px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div id="recordDiv" style="position:relative; margin:50px auto 0px auto; border:solid; width:80%; height:600px;">
        <div class="input-group input-item">
          <span class="input-group-addon" id="basic-addon1">用户名：</span>
          <input type="text" class="form-control" placeholder="用户名" aria-describedby="basic-addon1"/>
        </div>
        <div class="input-group input-item">
          <span class="input-group-addon" id="Span1">姓名：</span>
          <input type="text" class="form-control" placeholder="姓名" aria-describedby="basic-addon1"/>
        </div>
        <div class="input-group input-item">
          <span class="input-group-addon" id="Span2">身份证：</span>
          <input type="text" class="form-control" placeholder="身份证" aria-describedby="basic-addon1"/>
        </div>
        <div class="input-group input-item">
          <span class="input-group-addon" id="Span3">手机号：</span>
          <input type="text" class="form-control" placeholder="手机号" aria-describedby="basic-addon1"/>
        </div>
    </div>
</asp:Content>


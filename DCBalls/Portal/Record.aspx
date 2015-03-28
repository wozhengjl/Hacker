<%@ Page Language="C#" MasterPageFile="./master/NavigationBar.master" Title="投注记录" AutoEventWireup="true" CodeFile="Record.aspx.cs" Inherits="DoubleColor.Redballs.Portal.Record" %>

<asp:Content id="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="/Portal/bootstrap/css/bootstrap-table.css" rel="stylesheet" />
    <script src="/Portal/bootstrap/js/bootstrap-table.js"></script>
    <script src="/Portal/bootstrap/js/bootstrap-table-zh-CN.js"></script>
    <script src="./js/DCBall.js"></script>
</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div id="recordDiv" style="position:relative; margin:50px auto 0px auto; border:solid; width:80%; height:600px;">
    <div>
        <ul id="billtab" class="nav nav-tabs" role="tablist">
            <li role="presentation" class="active"><a href="#">全部记录</a></li>
            <li role="presentation"><a href="#">中奖纪录</a></li>
            <li role="presentation"><a href="#">未开奖</a></li>
            <li role="presentation"><a href="#">未成功订单</a></li>
        </ul>
    </div>
    <div class="btn-group">
      <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown">
        最近7天 <span class="caret"></span>
      </button>
      <ul class="dropdown-menu" role="menu">
        <li><a href="#">最近7天</a></li>
        <li><a href="#">最近15天</a></li>
        <li><a href="#">最近30天</a></li>
        <li><a href="#">最近90天</a></li>
        <li><a href="#">90天以前</a></li>
      </ul>
    </div>
    <div class="panel panel-default">
        <div class="panel-heading">投注记录</div>
        <table id="recordTable">
            <thead>
                <tr>
                    <th data-field="Type">彩种</th>
                    <th data-field="DateTime">投注时间</th>
                    <th data-field="Cost">投注金额</th>
                    <th data-field="State">当前状态</th>
                </tr>
            </thead>
        </table>
    </div>
    <script>
        $('#billtab a').click(function (e) {
            e.preventDefault();
            $(this).tab('show');
        })

        GetRecords({
            startDate: 90,
            endDate: 0,
            state: -1,
            succeedCallBack: function(result)
            {
                $("#recordTable").bootstrapTable({
                    data: result,
                });
            }
        }); 
    </script>
</div>
</asp:Content>

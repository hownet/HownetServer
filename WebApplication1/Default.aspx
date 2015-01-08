<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html> 
<form id="form1" runat="server">
　<head>
　<%--<title>电子工票</title>
　　 <meta name="viewport" content="width=device-width, initial-scale=1"> 
     <link href="jquery.mobile-1.1.0.css" rel="stylesheet" type="text/css" />
     <script src="jquery.mobile-1.1.0.js" type="text/javascript"></script>--%>
     <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>顺易电子工票</title>
	<link rel="stylesheet"  href="css/themes/default/jquery.mobile-1.1.0.css" />
	<link rel="stylesheet" href="docs/_assets/css/jqm-docs.css" />
	<script src="js/jquery.js"></script>
	 
	 
    <script  type="text/javascript">

        $(document).ready(function() {
            $("#TextBox1").focus();

        });
       
        
    </script>
</head> 
<body>
<div data-role="page">
<div data-role="header">
<asp:TextBox ID="TextBox1" runat="server" Width="80%" 
                ontextchanged="TextBox1_TextChanged" Height="34px" 
        EnableTheming="False"></asp:TextBox>
　<%--<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />--%>
    </div><!-- /header -->
     <asp:Label ID="Label1" runat="server" Text="请刷卡" ForeColor="Red"></asp:Label>
　<asp:Button ID="Button1" runat="server" Height="35px" onclick="Button1_Click" 
        Text="当天" Visible="True" Width="117px" />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <div data-role="content"> 
     <asp:GridView ID="GridView2" runat="server" Width="100%">
     </asp:GridView>
     <br />
     <asp:GridView ID="GridView1" runat="server" Width="100%" onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                            CommandArgument='<%# Eval("ID") %>' CommandName="Select" Text="选择"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
     &nbsp;　</div><!-- /content -->
　</div><!-- /page -->
　</body>
</form>
</html>

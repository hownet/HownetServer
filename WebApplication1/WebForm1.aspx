<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html> 
<form id="form1" runat="server">
　<head> 
　 <title>My Page</title> 
　 <meta name="viewport" content="width=device-width, initial-scale=1"> 
　 <%--<link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.css" />--%>
     <link href="jquery.mobile-1.1.0.css" rel="stylesheet" type="text/css" />
　 <%--<script src="http://code.jquery.com/jquery-1.7.1.min.js"></script>--%>

     <script src="jquery.mobile-1.1.0.js" type="text/javascript"></script>
　 <%--<script src="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.js"></script>--%>

</head> 
<body>
　<div data-role="page">
　<div data-role="header">
　　<h1>My Title</h1>
            <asp:TextBox ID="TextBox1" runat="server" Width="100%" 
                ontextchanged="TextBox1_TextChanged"></asp:TextBox>
　</div><!-- /header -->
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
　<div data-role="content"> 
　　<p>Hello world</p> 
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
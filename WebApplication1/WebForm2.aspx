<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>无标题页</title>  
</head>  
<body>  
    <fieldset>  
        <legend>GET提交数据</legend>  
        <form id="form1" action="WebForm2.aspx" method="get">  
        <input type="text" name="FROMCITY" value="CAN" /><br />  
        <input type="text" name="TOCITY" value="SYD" /><br />  
        <input type="text" name="FROMDATE" value="20110301" /><br />  
        <input type="text" name="FLYTYPE" value="1" /><br />  
        <br />  
        <input type="submit" id="submit1" value="GET提交数据" />  
        </form>  
    </fieldset>  
    <br />  
    <fieldset>  
        <legend>POST提交数据</legend>  
        <form id="form2" action="WebForm2.aspx" method="post">  
        <input type="text" name="FROMCITY" value="CAN" /><br />  
        <input type="text" name="TOCITY" value="SYD" /><br />  
        <input type="text" name="FROMDATE" value="20110301" /><br />  
        <input type="text" name="FLYTYPE" value="1" /><br />  
        <br />  
        <input type="submit" id="submit2" value="POST提交数据" />  
        </form>  
    </fieldset>  
</body>  
</html> 
<%@ Page Language="C#" autoeventwireup="false" Inherits="RQLCodeGenUI.Default" validaterequest="false" EnableSessionState="false" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmls="http://www.w3.org/1999/xhtml">
<head>
    <title>RQL Code Generator</title> 
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="CACHE-CONTROL" content="NO-CACHE" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <link href="RQLCodeGenUI.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <p>
            <strong>Class Name:</strong> 
        </p>
        <p>
            <asp:TextBox id="TxtClassName" runat="server"></asp:TextBox>
        </p>
        <p>
            <strong>RQL Request:</strong> 
        </p>
        <p>
            <asp:TextBox id="TxtRqlRequest" runat="server" TextMode="MultiLine" Columns="70" Rows="15"></asp:TextBox>
        </p>
        <p>
            <asp:Button id="BtnSubmit" runat="server" Text="Submit"></asp:Button>
        </p>
        <p>
            <strong>RQL Error:</strong> 
            <asp:Literal id="LitRqlError" runat="server"></asp:Literal>
        </p>
        <p>
            <strong>RQL Info:</strong> 
            <asp:Literal id="LitRqlInfo" runat="server"></asp:Literal>
        </p>
        <p>
            <strong>RQL Response:</strong> 
        </p>
        <p>
            <asp:TextBox id="TxtRqlResponse" runat="server" TextMode="MultiLine" Columns="70" Rows="30"></asp:TextBox>
        </p>
    </form>
</body>
</html>

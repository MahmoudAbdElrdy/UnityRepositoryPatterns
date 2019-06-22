<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportBook.aspx.cs" Inherits="WebApplication1.ReportBook" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            From:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp; To:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="84px" />
            <br />
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="612px" >
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>

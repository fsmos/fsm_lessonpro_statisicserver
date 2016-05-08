<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StatisticServer.Default" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 163px;
        }
        .auto-style3
        {
            width: 730px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">Cтатистика<br />
                    Учителя<br />
                    <asp:Table ID="TeacherList" runat="server" BorderStyle="Solid" CaptionAlign="Bottom" ClientIDMode="AutoID" GridLines="Both">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Имя</asp:TableCell>
                            <asp:TableCell runat="server">Баллы</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <br />
                    Группы<br />
                    <asp:Table ID="GroupList" runat="server" BorderStyle="Solid" CaptionAlign="Bottom" ClientIDMode="AutoID" GridLines="Both">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Имя</asp:TableCell>
                            <asp:TableCell runat="server">Баллы</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <br />
                    Студенты<br />
                    <asp:Table ID="StudentList" runat="server" BorderStyle="Solid" CaptionAlign="Bottom" ClientIDMode="AutoID" GridLines="Both">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Имя</asp:TableCell>
                            <asp:TableCell runat="server">Баллы</asp:TableCell>
                            <asp:TableCell runat="server">Прогулы</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

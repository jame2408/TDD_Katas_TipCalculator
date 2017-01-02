<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cashier.aspx.cs" Inherits="Cashier_webform.Cashier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>小費計算機</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>消費金額：</label><asp:TextBox ID="billAmount" runat="server"></asp:TextBox>
        <br/>
        <label>小費費率：</label><asp:TextBox ID="tipRate" runat="server"></asp:TextBox>
        <p/>
            
        <label>小費：</label><asp:Label ID="tip" runat="server" Text=""></asp:Label>
        <br/>
        <label>總計：</label><asp:Label ID="totalAmount" runat="server" Text=""></asp:Label>
        <p/>

        <asp:Button ID="Calculator" runat="server" Text="計算" OnClick="Calculator_Click" />
    </div>
    </form>
</body>
</html>

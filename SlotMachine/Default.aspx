<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SlotMachine.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="leftImage" runat="server" Height="300px" Width="275px" />
        <asp:Image ID="middleImage" runat="server" Height="300px" Width="275px" />
        <asp:Image ID="rightImage" runat="server" Height="300px" Width="275px" />
        <br />
        <br />
        <br />
        YOUR BET:
        <asp:TextBox ID="betTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="spinButton" runat="server" Text="SPIN" OnClick="spinButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultsLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry = x2 your bet<br />
        2 Cherries = x3 your bet<br />
        3 Cherries = x4 your bet<br />
        3 7s&nbsp; JACKPOT = x100 your bet<br />
        <br />
        However; if there is one BAR you win nothing.
        <br />
    
    </div>
    </form>
</body>
</html>

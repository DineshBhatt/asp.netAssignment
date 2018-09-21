<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="_21st_Sep2018_1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 442px;
        }
        .auto-style2 {
            height: 71px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            position: relative;
            left: 172px;
            top: 33px;
            width: 588px;
            height: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <div class="auto-style2">
                <div class="auto-style3">
                    Home Page<br />
                User Data<br />
                <br />
                <br />
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <br />
                <br />
                <asp:Button ID="RegisterMe" runat="server" OnClick="RegisterMe_Click" Text="Register More" Width="108px" />
                </div>
                <div class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" CssClass="auto-style4">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

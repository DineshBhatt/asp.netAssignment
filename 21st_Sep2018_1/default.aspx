<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_21st_Sep2018_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 87px;
            position: relative;
            left: 0px;
            top: 0px;
        }
        .auto-style3 {
            width: 100%;
            height: 213px;
        }
        .auto-style4 {
            width: 288px;
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 288px;
            text-align: right;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            height: 23px;
            width: 190px;
        }
        .auto-style9 {
            width: 190px;
        }
        .auto-style10 {
            font-size: xx-large;
        }
        .auto-style11 {
            width: 288px;
            text-align: right;
            height: 26px;
        }
        .auto-style12 {
            width: 190px;
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            position: relative;
            left: 0px;
            top: 236px;
            height: 123px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 623px">
    <form id="form1" runat="server">
        <div>
            <div class="auto-style2">
                <div class="auto-style5" style="background-color: #FF5050">
                    <br />
                    <strong><span class="auto-style10" style="background-color: #FF5050">Register</span></strong><br />
                    <br />
                    <br />
                </div>
                <table class="auto-style3" style="background-color: #99FF99">
                    <tr>
                        <td class="auto-style6">First Name:</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="TextBox1" runat="server" Width="141px" OnDataBinding="Page_Load"></asp:TextBox>
                        </td>
                        <td class="auto-style7">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Required" OnDataBinding="Button1_Click" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Last Name:</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="TextBox2" runat="server" Width="140px" OnDataBinding="Button1_Click"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last name required" OnDataBinding="Button1_Click" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Age</td>
                        <td class="auto-style12">
                            <asp:TextBox ID="TextBox3" runat="server" Width="137px" OnDataBinding="Button1_Click"></asp:TextBox>
                        </td>
                        <td class="auto-style13">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Age Required" OnDataBinding="Button1_Click" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Mobile Number</td>
                        <td class="auto-style12">
                            <asp:TextBox ID="TextBox4" runat="server" OnDataBinding="Button1_Click"></asp:TextBox>
                        </td>
                        <td class="auto-style13">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Mobile no required" OnDataBinding="Button1_Click" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Gender</td>
                        <td class="auto-style9">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnDataBinding="Button1_Click">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Select Gender" OnDataBinding="Button1_Click" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Country</td>
                        <td class="auto-style12">
                            <br />
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="98px" OnDataBinding="Button1_Click">
                                <asp:ListItem>India</asp:ListItem>
                                <asp:ListItem>USA</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select country" OnDataBinding="Button1_Click" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style9">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="83px" OnDataBinding="Page_Load" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
    <div class="auto-style14" style="background-color: #CC0099">
    </div>
</body>
</html>

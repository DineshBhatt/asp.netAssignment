<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Assing21sept2018_registration.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 395px;
            position: relative;
            left: 0px;
            top: -122px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            height: 143px;
            position: relative;
            left: 0px;
            top: -149px;
        }
    </style>
</head>
<body style="margin-top: 166px">
    <form id="form1" runat="server">
        <div>
            <div class="auto-style4" style="background-color: #FF99FF; font-size: larger;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E_Commerce</h1></div>
            <table class="auto-style1">
                <tr>
                    <td>I.D.</td>
                    <td>
                        <asp:TextBox ID="RegistrationID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter Id"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>FirstName</td>
                    <td>
                        <asp:TextBox ID="FirstName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="enter the first name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>LastName</td>
                    <td>
                        <asp:TextBox ID="LastName" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter the last name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="Age" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="out of range " MaximumValue="18" MinimumValue="150"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="DateOfBirth" runat="server" OnTextChanged="DateOfBirth_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                        
                        </td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>Norway</asp:ListItem>
                            <asp:ListItem>Neitherland</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
    
</body>
</html>

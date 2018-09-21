<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_21sept2018_regtration_validation.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <center>
        <div >
            <table class="auto-style1">
                <tr>
                    <td>I.D.</td>
                    <td>
                        <asp:TextBox ID="RegistrationID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RegistrationID" ErrorMessage="enter the  I.D."></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>FirstName</td>
                    <td>
                        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FirstName" ErrorMessage="Enter the first name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>LastName</td>
                    <td>
                        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LastName" ErrorMessage="enter the last name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="Age" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Age" ErrorMessage="enter the age" ForeColor="#FF3300" MaximumValue="18" MinimumValue="150"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="DateOfBirth" runat="server" ></asp:TextBox>
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
                        <asp:DropDownList ID="DropDownList1" runat="server" >
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
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>

        </div>
           </center>
</asp:Content>

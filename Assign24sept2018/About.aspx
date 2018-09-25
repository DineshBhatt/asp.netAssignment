<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Assign24sept2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>.</h2>
 
    <h3>&nbsp;</h3>
    <h3>Your application description page.</h3>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
    <p>&nbsp;</p>
  <%--  <p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </p>--%>
    <p>
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>this area is to provide additional information.</p>
       <div style="height: 1072px">




         


            
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
           
           
          




































</div>
</asp:Content>

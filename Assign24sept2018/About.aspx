<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Assign24sept2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
 
    <h3>&nbsp;</h3>
    <h3>Our IJOX Products</h3>
    <p>&nbsp;</p>
    <p class="text-center">
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="176px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search Product" />
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
       <div style="height: 1072px">




         


            
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
           
           
          




































</div>
</asp:Content>

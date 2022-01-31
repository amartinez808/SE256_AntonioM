<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCalcW1.Backend.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Username: <asp:TextBox ID="txtUname" runat="server" />
        <br />
        <br />
        Password:<asp:TextBox ID="txtPW" runat="server" TextMode="Password" />
        <br />
        <br />
        <asp:Button ID="lblLogin" runat="server" OnClick="lblLogin_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblFeedback" runat="server" Text="" />
    </div>
</asp:Content>

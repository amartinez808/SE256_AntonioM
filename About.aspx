<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebCalcW1.About" %>
<%-- Placeholder for breaking new content. If there is no breaking news, clear the content between the DIV tags --%>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
   <div>

   </div>
<%-- close this content --%>
</asp:Content>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>

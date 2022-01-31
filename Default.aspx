<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCalcW1._Default" %>

<%-- Content is where we code the HTML/Form info for this specific page and will be placed in "MainContent" Placeholder--%>
<%-- Notice that there is no HTML nor Form open/close tags here .. thats all in master and are pasting this info in Content (metaphor) --%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Hey NOW!..
    </div>
</asp:Content>
 <%-- close this content --%>



<%-- placeholder for breaking new content. If there is no breaking news, clear the content between the 
    DIV tags--%>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <div>
        <h1>Breaking News:</h1>
        <p>
           Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
    </div>

<%-- close this content --%>
</asp:Content>
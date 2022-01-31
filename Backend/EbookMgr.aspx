<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EbookMgr.aspx.cs" Inherits="WebCalcW1.Backend.EbookMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <%--This is for later use... --%>
        <tr>
            <td>Book ID</td>
            <td><asp:TextBox ID="Ebook_ID" runat="server" /></td>
            
        </tr>

         <%--Book TItle... --%>
        <tr>
            <td>Book Title</td>
            <td><asp:TextBox ID="txtTitle" runat="server" MaxLength="255" /></td>
         </tr>

         <%--Author info... --%>
        <tr>
            <td>Author's First Name</td>
            <td><asp:TextBox ID="txtAuthorFirst" runat="server" MaxLength="20" /></td>
        </tr>
        <tr>
            <td>Author's Last Name</td>
            <td><asp:TextBox ID="txtAuthorLast" runat="server" MaxLength="40" /></td>
        </tr>

        <tr>
            <td>Author's Email</td>
            <td><asp:TextBox ID="txtAuthorEmail" runat="server" MaxLength="20" /></td>
        </tr>

        <%--Date Published--%>
        <tr>
            <td>Date Published</td>
            <td><asp:Calendar ID="DatePublished" runat="server"  /></td>
        </tr>

         <%--# of pages--%>
        <tr>
            <td>Number Pages</td>
            <td><asp:TextBox ID="txtPages" runat="server" MaxLength ="5" /></td>
        </tr>

         <%--Price--%>
        <tr>
            <td>Price per copy</td>
             <td>$<asp:TextBox ID="txtPrice" runat="server" MaxLength ="10" /></td>
        </tr>

        <%-- Button to add a book toDB.... but right now, we just want to see if wehave it--%>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="add" OnClick="btnAdd_Click" />

        <%--Feedback label is intented to help us see information, such as aerrors or confirmation of something --%>
        <br />
        <br />
        <asp:Label ID="lblFeedback" runat="server" />
    </table>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ellery Leung&#39;s TryIt</h1>
        <p class="lead">Why am I making this crappy page?</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Service #19 - Find the nearest venue</h2>
            <p>Enter your address:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Enter the Name of your venue:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                ; or select one from the dropdown:
                <asp:DropDownList ID="DropDownList1" 
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                    runat="server" DataTextField="description" 
                    DataValueField="value">
                    <asp:ListItem Selected="True">   </asp:ListItem>
                    <asp:ListItem Value="Arena"> Arena </asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

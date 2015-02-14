<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            width: 50%;
        }
        .auto-style9 {
            font-size: 30pt;
        }
        .auto-style10 {
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <span class="auto-style9"><strong>Login</strong></span><br />

    <table class="auto-style8" align="center">
        <tr>
            <td class="auto-style10" width="50%">Login ID:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember Me" />
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="2">
                <asp:Label ID="Label1" runat="server" ForeColor="#990000" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>


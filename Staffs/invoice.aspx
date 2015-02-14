<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="invoice.aspx.cs" Inherits="invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            color: #D79049;
        }
        .auto-style12 {
            width: 100%;
        }
        .auto-style14 {
            text-align: center;
            font-weight: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h4 class="auto-style11">
        <table class="auto-style12">
            <tr>
                <td style="text-align: right">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Logout</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Receipt" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
            </tr>
        </table>
        <em>Thank You For Choosing Us...
             
     <h4 class="auto-style11"> Your Appointment Has been fixed with the selected doctor</h4>  
                           <h4 class="auto-style11"> Get Well Soon.</h4>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Img/atslogo.jpg" />
</em>
</h4>
</asp:Content>


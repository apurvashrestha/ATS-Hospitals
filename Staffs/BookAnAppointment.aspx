<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookAnAppointment.aspx.cs" Inherits="RegistFormView2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style8 {
            width: 100%;
            background-color: #FFCC66;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            font-size: 30pt;
        }
    .auto-style11 {
        color: #000000;
    }
    .auto-style12 {
        text-align: left;
        color: #000000;
        align: center;
    }
        .auto-style13 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <span class="auto-style10"><strong>Book An Appointment</strong></span><br />

<p style="text-align: right">&nbsp;<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/LoginPage.aspx">Logout</asp:LinkButton>
        </p>
Enter ID:&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Data" />
<br />
<br />
<table class="auto-style8">
            <tr>
                <td class="auto-style12">Full Name:
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style12">Patient ID:
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style12">Contact Number:
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="2">Address:
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style13"><span class="auto-style11">Age:</span><asp:Label ID="Label5" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"><span class="auto-style11">Specialisation: </span><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>General Physician</asp:ListItem>
                    <asp:ListItem>Cardiologist</asp:ListItem>
                    <asp:ListItem>Neurologist</asp:ListItem>
                    <asp:ListItem>Nephrologist</asp:ListItem>
                    <asp:ListItem>Dermatologist</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style9"><span class="auto-style11">Doctor&#39;s Name:&nbsp; </span>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style13"><span class="auto-style11">Consultation Charges:</span><asp:Label ID="Label6" runat="server" CssClass="auto-style11"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="width: 70px" Text="Proceed" />
        <div height="150px">
            <br />
        </div>
      
</asp:Content>


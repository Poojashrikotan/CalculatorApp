<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calcualtion.aspx.cs" Inherits="Caculator.Calcualtion" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .cal {
            position: absolute;
            top: 100px;
            left: 150px;
            right: 400px;
            height: 500px;
            width:500px;
            bottom: 100px;
            background-color: Teal;
            padding-top: 20px;
            margin: 10px;
            text-align:center;
        }
    </style>
    <%--  <form id="form1" runat="server">  --%>
    <div class="cal">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblbasic" Text=" BASIC CALCULATOR" runat="server" Style="margin-left: 100px; color: white;text-align:center" 
                        Font-Bold="False" Font-Italic="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtnumber" runat="server" CssClass="form-control" Style="margin-left: 100px; margin-top: 24px;"
                        Width="335px" Height="41px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="padding-left:100px;padding-top: 10px;">
                    <asp:Button ID="btn1" Text="1" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn1_Click"
                        Width="57px" />
                    <asp:Button ID="btn2" Text="2" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn2_Click"
                        Width="57px" />
                    <asp:Button ID="btn3" Text="3" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn3_Click"
                        Width="57px" />
                    <asp:Button ID="btnadd" Text="+" runat="server" Height="37px" Style="margin-left: 0px;" OnClick="btnadd_Click"
                        Width="57px" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:100px">
                    <asp:Button ID="btn4" Text="4" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn4_Click"
                        Width="57px" />
                    <asp:Button ID="btn5" Text="5" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn5_Click"
                        Width="57px" />
                    <asp:Button ID="btn6" Text="6" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn6_Click"
                        Width="57px" />
                    <asp:Button ID="sub" Text="-" runat="server" Height="37px" Style="margin-left: 0px" OnClick="sub_Click"
                        Width="57px" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:100px">
                    <asp:Button ID="btn7" Text="7" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn7_Click"
                        Width="57px" />
                    <asp:Button ID="btn8" Text="8" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn8_Click"
                        Width="57px" />
                    <asp:Button ID="btn9" Text="9" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btn9_Click"
                        Width="57px" />
                    <asp:Button ID="btnmul" Text="*" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btnmul_Click"
                        Width="57px" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:100px">
                    <asp:Button ID="btn0" runat="server" Text="0" Height="37px" Style="margin-left: 0px" OnClick="btn0_Click"
                        Width="57px" />
                    <asp:Button ID="btnclr" runat="server" Text="CLR" Height="37px" Style="margin-left: 0px" OnClick="btnclr_Click"
                        Width="57px" />
                    <asp:Button ID="btneql" runat="server" Text="=" Height="37px" Style="margin-left: 0px" OnClick="btneql_Click"
                        Width="57px" />
                    <asp:Button ID="btndiv" Text="/" runat="server" Height="37px" Style="margin-left: 0px" OnClick="btndiv_Click"
                        Width="57px" />
                </td>
            </tr>
        </table>



    </div>
    <%--  </form>  --%>
</asp:Content>


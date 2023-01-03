<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Caculator.History" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
           .gridContainer {
            overflow: auto;
            padding: 10px;
            margin: auto;
            margin-top: 100px;
            padding-top:50px;
        }

        .grid {
            overflow: auto;
        }

            .grid th {
                padding: 10px;
                font-size: 15px;
                text-align: center;
                font-weight: bold;
                color: black;
                background-color: #EEEEEE;
            }

            .grid td {
                padding: 4px;
                font-size: 14px;
            }

            .grid th, .grid td {
                border: unset;
                border-bottom: 0.5px solid #cdcdcd !important;
                border-right: 0.5px solid #cdcdcd !important;
                border-top: 0.5px solid #cdcdcd !important;
                border-bottom: 0.5px solid #cdcdcd !important;
            }

            .grid tr th {
                position: sticky;
                top: -1px;
               /* left: -1px;
                right: -1px;*/
                z-index: 1;
            }

    </style>
    <asp:GridView runat="server" ID="gvDetails" ShowHeaderWhenEmpty="true" CssClass="grid" AutoGenerateColumns="false" EmptyDataText="No Data Found...!!" EmptyDataRowStyle-CssClass="empty-row-style" >
                <Columns>
                
                     <asp:TemplateField HeaderText="First Number">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblnum1" Text='<%# Eval("num1") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Second Number">
                        <ItemTemplate>
                             <asp:Label runat="server" ID="lblnum2" Text='<%# Eval("num2") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Operation">
                        <ItemTemplate>
                             <asp:Label runat="server" ID="lblopt" Text='<%# Eval("opt") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Result">
                        <ItemTemplate>
                             <asp:Label runat="server" ID="lblres" Text='<%# Eval("res") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="OnDate">
                        <ItemTemplate>
                             <asp:Label runat="server" ID="lbldate" Text='<%# Eval("ondate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                
                </Columns>
            </asp:GridView>
</asp:Content>
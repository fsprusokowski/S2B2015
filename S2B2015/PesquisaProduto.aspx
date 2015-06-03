<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PesquisaProduto.aspx.cs" Inherits="S2B2015.PesquisaProduto" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Pesquise o Produto Desejado</h3>
    <p>
        <asp:TextBox ID="TxtPesquisa" runat="server" Height="29px" Width="228px"></asp:TextBox>
        <asp:Button ID="btnPesquisar" runat="server" OnClick="btnPesquisar_Click" Text="Pesquisar" />
        <asp:RadioButtonList ID="rdioPesquisa" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Selected="True">Nome do Produto</asp:ListItem>
            <asp:ListItem>Nome do vendedor</asp:ListItem>
        </asp:RadioButtonList>
    
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Pesquisa por Categorias"></asp:Label>
        <asp:DropDownList ID="drplstCategoria" runat="server" OnSelectedIndexChanged="drplstCategoria_SelectedIndexChanged">
            <asp:ListItem Text="--Categoria--" Value="" />
            <asp:ListItem>Eletrodoméstico</asp:ListItem>
            <asp:ListItem>Games</asp:ListItem>
        </asp:DropDownList>
    
    </p>
    <p>
        &nbsp;</p>

</asp:Content>

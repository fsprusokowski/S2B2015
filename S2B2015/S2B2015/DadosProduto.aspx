﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DadosProduto.aspx.cs" Inherits="S2B2015.DadosProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gwDadosProd" runat="server"></asp:GridView>
    
    <div class="row">    
        <div class="row" >
            <asp:Label ID="lblTitulo" CssClass="h1" runat="server" Text="lbl"></asp:Label>
        </div>
        <div class="row" >
            <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
        </div>
    </div>
    
    <br />
    <br />

    <div class="container">
    <div class="row jumbotron">

        <div class="col-md-8" >
            <asp:Image ID="imgProduto" class="img-rounded img-responsive" runat="server" Height="400px" ImageUrl="http://www.gazette-ariegeoise.fr/IMG/jpg/test.jpg" Width="500px" />
        </div>

        <div class="col-md-4" >
            <div class="row">                           
                <asp:Label ID="lblPreco" CssClass="h1" runat="server" Text="$$$"></asp:Label>                
            </div>      
                          
            <div class="row">
                <asp:Button ID="btnComprar" CssClass="btn  btn-success col-md-6" runat="server" Text="COMPRAR" />                
            </div> 
        </div> 
    </div>
        <div id="desc">

        </div>
    </div>

    <div class="col-md-4">
        <asp:Label ID="lblDescricao" runat="server" Text="Descricao"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" Visible="false"></asp:TextBox>
        <ajaxToolkit:HtmlEditorExtender TargetControlID="txtDescricao" ID="HtmlEditorExtender1" runat="server"></ajaxToolkit:HtmlEditorExtender>
    </div>


</asp:Content>

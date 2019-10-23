<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="paginaperfil.aspx.cs" Inherits="Connection.paginaperfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div  runat="server" id="divizona" class="parallax3">
	<h4 style="color:indianred">
        <asp:Label ID="nome" runat="server" Text="Label"></asp:Label>
        </h4>        

	</div>

	<div class="divperfil">
   
   <div class="row" >
      	
		<div class="col s4" style="align:center; ">
			<div style="margin:auto;text-align:center">
				<p style="font-size: 90px;text-align:center" class="textoparalax">0</p>
				<p style="text-align:center" class="texto2">AÇÕES</p>
				<p style="text-align:center" class="texto2">ATÉ AGORA</p>
			</div>
		</div>
	
		<div class="col s4" style="text-align:center;">
			<div style="margin-top:25px; text-align:center">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/imagens/pessoa.jpg" CssClass="circle" />
                
				<p style="text-align:center" >@<asp:Label ID="user" runat="server" Text="Label"></asp:Label></p>
			</div>
		</div>
		
		<div class="col s4" style="align:center; ">
			<div style=" margin:auto;margin-top:50px;text-align:center">
				<p style="text-align:center"class="texto3">O CORAÇÃO DE <asp:Label ID="nome2" runat="server" Text="Label"></asp:Label></p>
				<p style="color:green;text-align:center"  class="texto3">50% Meio Ambiente</p>
				<p style="color:blue;text-align:center" class="texto3">50% Saúde</p>

			</div>
		</div>
		
	</div>
	
	<div style="width: 70%; text-align:center; margin: auto">
	<p style="color: grey;text-align:center" ><asp:Label ID="biografia" runat="server" Text="Label"></asp:Label></p>
	</div>
	
	
	</div>
	
	<div class="divgrande" style="margin-top: -30px;">

	<div style="width: 70%; margin: auto; text-align: center;">
	  <a class="waves-effect indigo darken-4 waves-light btn">CALENDÁRIO</a>
      <a class="waves-effect indigo darken-4 waves-light btn">MEUS DADOS</a>
      <a class="waves-effect indigo darken-4 waves-light btn">CADASTRAR AÇÃO</a>
      <a class="waves-effect indigo darken-4 waves-light btn">GRUPOS</a>
    <asp:Button ID="Button1" class="waves-effect red accent-4 waves-light btn" runat="server" Text="SAIR" OnClick="Button1_Click" />
	  </div>




</asp:Content>

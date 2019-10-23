<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre2.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Connection.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div id="centro">
        <div class="input-field col s4" style="color:#1a237e;">
          <i class="material-icons prefix">account_circle</i>
          <asp:TextBox ID="user" runat="server" MaxLength="12" ToolTip="Coloque o nome de usuário!"></asp:TextBox>
          <label for="icon_prefix" style="color:#1a237e;">Usuário</label>
		   <span class="helper-text" data-error="wrong" data-success="right">-</span>
        </div>

        <div class="input-field col s4" style="color:#1a237e;">
          <i class="material-icons prefix">vpn_key</i>
          <asp:TextBox ID="senha" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
          <label for="senha" style="color:#1a237e;">Senha</label>
		   <span class="helper-text" data-error="wrong" data-success="right">-</span>
        </div>

        <asp:Button ID="Button1" CssClass="waves-effect indigo darken-4 waves-light btn" runat="server" Text="LOGIN" OnClick="Button1_Click" />
    </div>






<!-- particles.js container -->
<div id="particles-js"></div>

<!-- scripts -->
<script src="../particles.js"></script>
<script src="js/app.js"></script>

<!-- stats.js -->
<script src="js/lib/stats.js"></script>



</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMestre.Master" AutoEventWireup="true" CodeBehind="cadastroperfil.aspx.cs" Inherits="Connection.cadastroperfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="divgrande" style="margin-top: -30px;">
  
     
	 <div class="row" style="padding: 0px; width: 70%">
		<form class="col s12">
			  <div class="row">
				<div style="text-align: left" class="input-field col s12">
					<h3 style="color:#1a237e">Faça parte do time!</h3>
				</div>
			</div>
	  
	  <div class="row">
		<div class="input-field col s6" style="color:#1a237e;">
          <input id="nome" runat="server" type="text" class="validate" contenteditable="oi">
          <label style="color:#1a237e" for="nome">Nome completo</label>
       </div>
	 	<div class="col s3" style="color:#1a237e;">
			<div class="input-field col " style="color: #1a237e">
			<select id="genero" runat="server">
			  <option value="" disabled selected>Gênero</option>
			  <option value="1">Masculino</option>
			  <option value="2">Feminino</option>
			  <option value="3">Outro</option>
			</select>
		</div>
       </div>  
	   	<div class="input-field col s3" style="color:#1a237e;">
          <input runat="server" id="profissao" type="text" class="validate">
          <label style="color:#1a237e" for="profissao">Profissão</label>
       </div>  
	</div>
	
	  <div class="row">
	  
	  <div class="col s4" style="color:#1a237e;">
          
          <asp:DropDownList ID="dropestado" runat="server" CssClass="input=-field" DataSourceID="ObjectDataSource1"  DataTextField="uf" DataValueField="id" AutoPostBack="True" OnSelectedIndexChanged="uf_SelectedIndexChanged" ></asp:DropDownList>
          <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="Connection.DAL.DALEstado"></asp:ObjectDataSource>
       </div> 
	  
	 	<div class="col s4" style="color:#1a237e;">
             <asp:DropDownList ID="DropDownListCidade" runat="server" CssClass="input=-field" DataSourceID="ObjectDataSource2" DataTextField="nome" DataValueField="id" ></asp:DropDownList>
                       <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SelectAll" TypeName="Connection.DAL.DALCidade">
                           <SelectParameters>
                               <asp:SessionParameter DefaultValue="uf" Name="uf" SessionField="uf" Type="String" />
                           </SelectParameters>
             </asp:ObjectDataSource>
       </div>  
	   	<div class="input-field col s4" style="color:#1a237e; left: 0px; right: 0px; top: -14px;">
               <asp:TextBox ID="bairro" runat="server"></asp:TextBox>
          <label style="color:#1a237e" for="bairro">Bairro</label>
       </div>  
	</div>	
	
	<div class="row">
		<div class="input-field col s6" style="color:#1a237e;">
          <input runat="server" id="tel" type="text" class="validate">
          <label style="color:#1a237e" for="tel">Telefone</label>
       </div> 
	   	<div class="input-field col s6" style="color:#1a237e;">
          <input runat="server" id="email" type="text" class="validate">
          <label style="color:#1a237e" for="email">E-mail</label>
       </div>  
	</div>
	
	<div class="row">
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
		
		<div class="input-field col s4" style="color:#1a237e;">
          <i class="material-icons prefix">vpn_key</i>
          <asp:TextBox ID="senhac" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
          <label for="senhac" style="color:#1a237e;">Confirmar Senha</label>
		   <span class="helper-text" data-error="wrong" data-success="right">-</span>
        </div>
	</div>
	
	<div class="row">
			<div class="input-field col s12" style="color:#1a237e;">
            <textarea runat="server" id="textarea2" class="materialize-textarea"></textarea>
          <label style="color:#1a237e" for="horai">Descrição</label>
       </div>
		</div>
   
   <div class="row">
		<div class="input-field col s12" style="color:#1a237e;">
          <label style="color:#1a237e">Minhas causas</label></br>
       </div>
		
		<div class="col s3" style="color:#1a237e;">
		<p>
		  <label>
			<input runat="server" id="check1" type="checkbox" />
			<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
		<p>
		  <label>
			<input runat="server" id="check2" type="checkbox" />
			<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
       </div>
	   
	   		<div class="col s3" style="color:#1a237e;">
		<p>
		  <label>
			<input runat="server" id="check3" type="checkbox" />
			<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
		<p>
		  <label>
			<input runat="server" id="check4" type="checkbox" />
			<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
       </div>
	   
	   	   <div class="col s3" style="color:#1a237e;">
		<p>
		  <label>
			<input runat="server" id="check5" type="checkbox" />
			<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
		<p>
		  <label>
			<input runat="server" id="check6" type="checkbox" />
			<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
		  </label>
		</p>
       </div>
	   	 
		 <div class="col s3" style="color:#1a237e;">
		
       </div>
	   
	</div>
   
   
   
	<div class="row">

          <p style="color:#1a237e">Foto:</p>
	          <asp:FileUpload CssClass="waves-effect indigo darken-4 waves-light btn" ID="FileUpload1" runat="server"  />

	
	          <br />

	
	<div class="row">
		        
        <div class="col s12" style="color:#1a237e; text-align: center;">

            <br />

        <asp:Button ID="Button1" CssClass="waves-effect indigo darken-4 waves-light btn" runat="server" Text="ENTRAR PARA O TIME" OnClick="Button1_Click" />
		</div>

    </div>
	
	  
	  
	 
	  
	</div>
        </div>



</asp:Content>

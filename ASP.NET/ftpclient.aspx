<%@ Page language="c#" Inherits="inetsuitedemocs.ftpclient" CodeFile="ftpclient.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ftpclient</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - FTP Client Demo</h1>
			<p>Manages files and directories on FTP server.</p>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="80px" Height="24px">Server</asp:label><asp:textbox id="edtServer" runat="server" Width="224px"></asp:textbox>&nbsp;</p>
            <p>
                <asp:Label ID="Label2" runat="server" Height="24px" Width="80px">Port</asp:Label><asp:TextBox
                    ID="edtPort" runat="server" Width="224px"></asp:TextBox>&nbsp;</p>
			<p><asp:label id="Label4" runat="server" Width="80px" Height="24px">User</asp:label><asp:textbox id="edtUser" runat="server" Width="224px"></asp:textbox></p>
			<p><asp:label id="Label3" runat="server" Width="80px" Height="24px">Password</asp:label><asp:textbox id="edtPassword" runat="server" Width="224px" TextMode="Password"></asp:textbox>&nbsp;</p>
            <p>
                <asp:Label ID="Label5" runat="server" Height="24px" Width="80px">Current Dir</asp:Label><asp:TextBox
                    ID="edtCurrentDir" runat="server" Width="224px"></asp:TextBox>&nbsp;</p>
			<p><asp:button id="Button1" runat="server" Width="152px" Text="List directory" onclick="Button1_Click"></asp:button></p>
			<p><asp:datagrid id="DataGrid1" runat="server" Width="568px" AutoGenerateColumns="False">
					<HeaderStyle CssClass="clsTableTh"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="filename" HeaderText="Directory listing"></asp:BoundColumn>
					</Columns>
				</asp:datagrid></p>
			<hr SIZE="1">
			<p>For more information about using this component please visit <a target="_blank" href="http://www.clevercomponents.com/products/inetsuite/">
					Clever Internet .NET suite</a></p>
			<p>For assistance from a human being, feel free to contact at <A target="_blank" href="http://www.clevercomponents.com/support/">
					Clever Components Support</A></p>
			<p>Copyright &copy; 1999 - 2017 <a class="copyHrefStyle" target="_blank" href="http://www.clevercomponents.com">
					http://www.clevercomponents.com</a></p>
		</form>
	</body>
</HTML>

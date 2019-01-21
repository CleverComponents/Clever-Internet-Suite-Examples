<%@ Page language="c#" Inherits="inetsuitedemocs.imap" CodeFile="imap.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>imap</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - IMAP4 Client Demo</h1>
			<p>A mail IMAP4 client with functionality similar to MS Outlook.</p>
			<hr SIZE="1">
			<p><asp:label id="Label5" runat="server" Width="80px" Height="24px">Server</asp:label><asp:textbox id="edtServer" runat="server" Width="224px">imap.yourdomain.com</asp:textbox></p>
			<p><asp:label id="Label6" runat="server" Width="80px" Height="24px">User</asp:label><asp:textbox id="edtUser" runat="server" Width="224px">CleverTester</asp:textbox></p>
			<p><asp:label id="Label7" runat="server" Width="80px" Height="24px">Password</asp:label><asp:textbox id="edtPassword" runat="server" Width="224px" TextMode="Password"></asp:textbox></p>
			<p><asp:label id="Label1" runat="server" Width="80px" Height="24px">MailBox</asp:label><asp:textbox id="edtMailBox" runat="server" Width="224px">INBOX</asp:textbox></p>
			<p><asp:button id="Button1" runat="server" Width="152px" Text="Check Mail" onclick="Button1_Click"></asp:button></p>
			<p><asp:datagrid id="Datagrid1" runat="server" Width="568px" AutoGenerateColumns="False">
					<HeaderStyle CssClass="clsTableTh"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="Subject" HeaderText="Subject"></asp:BoundColumn>
						<asp:BoundColumn DataField="From" HeaderText="From"></asp:BoundColumn>
						<asp:BoundColumn DataField="Date" HeaderText="Date"></asp:BoundColumn>
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

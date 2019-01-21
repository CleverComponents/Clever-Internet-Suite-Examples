<%@ Page language="c#" Inherits="inetsuitedemocs.smtp" CodeFile="smtp.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>smtp</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - SMTP Client Demo</h1>
			<p>Sends MIME emails via SMTP protocol.</p>
			<hr SIZE="1">
			<p><asp:label id="lblStatus" runat="server" Width="464px" Height="24px" Visible="False">MESSAGE STATUS</asp:label></p>
			<p><asp:label id="Label7" runat="server" Width="80px" Height="24px">Server</asp:label><asp:textbox id="edtServer" runat="server" Width="224px">smtp.yourdomain.com</asp:textbox></p>
			<p><asp:label id="Label8" runat="server" Width="80px" Height="24px">User</asp:label><asp:textbox id="edtUser" runat="server" Width="224px">CleverTester</asp:textbox></p>
			<p><asp:label id="Label9" runat="server" Width="80px" Height="24px">Password</asp:label><asp:textbox id="edtPassword" runat="server" Width="224px" TextMode="Password"></asp:textbox></p>
			<p><asp:label id="Label1" runat="server" Width="80px" Height="24px">From</asp:label><asp:textbox id="edtFrom" runat="server" Width="324px">myname@mailserver.com</asp:textbox></p>
			<p><asp:label id="Label2" runat="server" Width="80px" Height="24px">To</asp:label><asp:textbox id="edtTo" runat="server" Width="324px">vasya@domain.com</asp:textbox></p>
			<p><asp:label id="Label3" runat="server" Width="80px" Height="24px">Subject</asp:label><asp:textbox id="edtSubject" runat="server" Width="324px">Hi</asp:textbox></p>
			<p><asp:label id="Label4" runat="server" Width="80px" Height="24px">Message</asp:label><asp:textbox id="edtBody" runat="server" Width="324px" Height="104px" TextMode="MultiLine">Dear Vasya</asp:textbox></p>
			<p><asp:button id="Button1" runat="server" Width="152px" Text="Send Mail" onclick="Button1_Click"></asp:button></p>
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

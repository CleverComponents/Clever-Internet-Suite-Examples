<%@ Page language="c#" Inherits="inetsuitedemocs.smtprelay" CodeFile="smtprelay.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>smtprelay</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - SMTP Relay Demo</h1>
			<p>Sends emails directly to recipient's mailbox.</p>
			<hr SIZE="1">
			<p><asp:label id="Label7" runat="server" Width="94px" Height="24px">DNS server IP</asp:label><asp:textbox id="edtDns" runat="server" Width="324px"></asp:textbox>&nbsp;</p>
			<p><asp:label id="Label1" runat="server" Width="94px" Height="24px">Sender E-mail</asp:label><asp:textbox id="edtFrom" runat="server" Width="324px"></asp:textbox>&nbsp;</p>
			<p><asp:label id="Label2" runat="server" Width="94px" Height="24px">Recipients</asp:label><asp:textbox id="edtTo" runat="server" Width="324px">vasya@example.com</asp:textbox></p>
			<p><asp:label id="Label3" runat="server" Width="94px" Height="24px">Subject</asp:label><asp:textbox id="edtSubject" runat="server" Width="324px">Hi</asp:textbox></p>
			<p><asp:label id="Label4" runat="server" Width="94px" Height="24px">Message</asp:label><asp:textbox id="edtBody" runat="server" Width="324px" Height="104px" TextMode="MultiLine">Dear Vasya</asp:textbox></p>
			<p><asp:button id="Button1" runat="server" Width="152px" Text="Send Mail" onclick="Button1_Click"></asp:button></p>
            <asp:TextBox ID="edtResult" runat="server" Height="178px" ReadOnly="True" TextMode="MultiLine"
                Width="417px"></asp:TextBox><br />
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

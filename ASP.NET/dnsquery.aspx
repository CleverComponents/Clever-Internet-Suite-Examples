<%@ Page language="c#" Inherits="inetsuitedemocs.dnsquery" CodeFile="dnsquery.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>dnsquery</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - DNS Query Demo</h1>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="106px" Height="24px">Server</asp:label><asp:textbox id="edtServer" runat="server" Width="224px"></asp:textbox></p>
			<p><asp:label id="Label4" runat="server" Width="105px" Height="24px">Name to resolve</asp:label><asp:textbox id="edtName" runat="server" Width="224px"></asp:textbox></p>
			<p><asp:label id="Label3" runat="server" Width="103px" Height="24px">Query Type</asp:label><asp:DropDownList
                    ID="cbType" runat="server" Width="128px">
                    <asp:ListItem Value="MX">MX (mail servers)</asp:ListItem>
                    <asp:ListItem Value="A">A (IP addresses)</asp:ListItem>
                    <asp:ListItem Value="PTR">PTR (host names)</asp:ListItem>
                    <asp:ListItem Value="NS">NS (name servers)</asp:ListItem>
                </asp:DropDownList>&nbsp;</p>
			<p><asp:button id="Button1" runat="server" Width="152px" Text="Resolve" onclick="Button1_Click"></asp:button></p>
			<p>
                <asp:TextBox ID="edtResult" runat="server" Height="247px" ReadOnly="True" TextMode="MultiLine"
                    Width="562px"></asp:TextBox>&nbsp;</p>
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

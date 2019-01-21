<%@ Page language="c#" Inherits="inetsuitedemocs.emailvalidator" CodeFile="emailvalidator.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>emailvalidator</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - Validate E-mail address</h1>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="106px" Height="24px">E-mail to validate </asp:label><asp:textbox id="edtEmail" runat="server" Width="224px"></asp:textbox>&nbsp;</p>
            <p>
                <asp:label id="Label3" runat="server" Width="103px" Height="24px">Validation Level</asp:label><asp:DropDownList
                    ID="cbLevel" runat="server" Width="128px">
                    <asp:ListItem Value="0">Blacklist</asp:ListItem>
                    <asp:ListItem Value="1">Syntax</asp:ListItem>
                    <asp:ListItem Value="2">Domain</asp:ListItem>
                    <asp:ListItem Value="3">Smtp Server</asp:ListItem>
                <asp:ListItem Value="4">Mailbox</asp:ListItem>
                </asp:DropDownList>&nbsp;</p>
			<p><asp:label id="Label4" runat="server" Width="105px" Height="24px">DNS server</asp:label><asp:textbox id="edtDNS" runat="server" Width="224px"></asp:textbox>&nbsp;</p>
            <p>
                <asp:Label ID="Label2" runat="server" Height="24px" Width="105px">Blacklist</asp:Label>&nbsp;</p>
			<p>
                <asp:TextBox ID="edtBlackList" runat="server" Height="112px" TextMode="MultiLine"
                    Width="325px"></asp:TextBox>&nbsp;</p>
			<asp:button id="Button1" runat="server" Width="152px" Text="Validate" onclick="Button1_Click"></asp:button>
            <br />
            <br />
            <asp:TextBox ID="edtResult" runat="server" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
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

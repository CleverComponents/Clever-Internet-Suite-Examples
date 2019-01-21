<%@ Page language="c#" Inherits="inetsuitedemocs.encoder" CodeFile="encoder.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>encoder</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - Encoder Demo</h1>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="106px" Height="24px">Source</asp:label>
                <asp:textbox id="edtSource" runat="server" Width="368px"></asp:textbox></p>
            <p>
                <asp:label id="Label3" runat="server" Width="103px" Height="24px">Encoding method</asp:label>&nbsp;<asp:DropDownList
                    ID="cbMethod" runat="server" Width="128px">
                    <asp:ListItem Value="1">Quoted Printable</asp:ListItem>
                    <asp:ListItem Value="2">Base64</asp:ListItem>
                    <asp:ListItem Value="3">UUEncoding</asp:ListItem>
                </asp:DropDownList>&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;
                <asp:button id="Button1" runat="server" Width="152px" Text="Encode" onclick="Button1_Click"></asp:button></p>
			<p><asp:label id="Label4" runat="server" Width="105px" Height="24px">Result</asp:label><asp:textbox id="edtResult" runat="server" Width="371px" ReadOnly="True"></asp:textbox></p>
			<p>
                &nbsp;</p>
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

<%@ Page language="c#" Inherits="inetsuitedemocs.htmlparser" CodeFile="htmlparser.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>htmlparser</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - HTML Parser Demo</h1>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="176px" Height="24px">URL to download and parse</asp:label><asp:textbox id="edtUrl" runat="server" Width="391px"></asp:textbox>&nbsp;
                <asp:button id="Button1" runat="server" Width="47px" Text="GO" onclick="Button1_Click"></asp:button></p>
			<p><asp:datagrid id="DataGrid1" runat="server" Width="568px" AutoGenerateColumns="False">
					<HeaderStyle CssClass="clsTableTh"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="Url" HeaderText="Extracted URLs"></asp:BoundColumn>
					</Columns>
				</asp:datagrid>&nbsp;</p>
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

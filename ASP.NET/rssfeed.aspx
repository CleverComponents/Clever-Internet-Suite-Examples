<%@ Page language="c#" Inherits="inetsuitedemocs.rss" CodeFile="rssfeed.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>rss</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="cleverstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<h1>Clever Internet .NET suite - RSS Client Demo</h1>
			<p>Receives news feed via RSS protocol.</p>
			<hr SIZE="1">
			<p><asp:label id="Label1" runat="server" Width="80px" Height="24px">URL</asp:label><asp:textbox id="edtURL" runat="server" Width="224px"></asp:textbox>
                <asp:button id="Button1" runat="server" Width="39px" Text="GET" onclick="Button1_Click"></asp:button></p>
			<p><asp:label id="Label4" runat="server" Width="80px" Height="24px">Title</asp:label><asp:textbox id="edtTitle" runat="server" Width="319px" ReadOnly="True"></asp:textbox><br/>
			<asp:label id="Label3" runat="server" Width="80px" Height="24px">Link</asp:label><asp:textbox id="edtLink" runat="server" Width="318px" ReadOnly="True"></asp:textbox><br/>
            <asp:Label ID="Label2" runat="server" Height="24px" Width="80px">Description</asp:Label><asp:TextBox ID="edtDescription" runat="server" ReadOnly="True" Width="317px"></asp:TextBox>&nbsp;</p>
			<p><asp:datagrid id="DataGrid1" runat="server" Width="568px" AutoGenerateColumns="False">
					<HeaderStyle CssClass="clsTableTh"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="Title" HeaderText="Title"></asp:BoundColumn>
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

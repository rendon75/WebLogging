<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebLogging.Default" Trace="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ObjectDataSource ID="AuthorsObjectDataSource" runat="server" TypeName="PubsClasses.AuthorClass" SelectMethod="GetAuthors" />

        <asp:GridView ID="GridView1" runat="server" DataSourceID="AuthorsObjectDataSource" />
    </form>
</body>
</html>

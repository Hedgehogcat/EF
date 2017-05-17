<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>ShowSucess</title>
</head>
<body>
    <div>
        <%=ViewData["ok"] %>注册成功
    </div>
</body>
</html>

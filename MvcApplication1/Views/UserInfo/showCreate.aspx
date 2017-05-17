<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>showCreate</title>
</head>
<body>
    <div>
        <form action="/UserInfo/ProcessAdd" method="post">
            <table>
                <tr>
                    <td>
                        用户名：
                    </td>
                    <td>
                        <input type ="text" name="txtname" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp密码：
                    </td>
                    <td>
                        <input type ="password" name="password" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="添加" />
                    </td>
                </tr>
            </table>

        </form>
    </div>
</body>
</html>

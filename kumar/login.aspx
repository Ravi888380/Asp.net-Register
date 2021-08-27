<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="kumar.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
 <div>
            <label>Email</label>
        </div>
        <div>
            <input type="email" id="txt_email" runat="server" />
        </div>
        <div>
            <label>Password</label>
        </div>
        <div>
            <input type="password" runat="server" id="txt_password" />
        </div>
        <div>
            <button type="submit" runat="server" onserverclick="btn_login">Login</button>
        </div>
        <div>
            <label id="txt_label" runat="server" style="color:red"></label>
        </div>
    </form>
</body>
</html>

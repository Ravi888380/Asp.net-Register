<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="kumar.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div>
            <label>Name</label>
        </div>
        <div>
            <input type="text" id="txt_name" runat="server" />
        </div>
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
            <button type="submit" runat="server" onserverclick="btn_register">Register</button>
        </div>
        <div>
            <label runat="server" id="txt_label" style="color:red"></label>
        </div>
    </form>
</body>
</html>

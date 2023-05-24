<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginSignUp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Helper/css/style.default.css" rel="stylesheet" />
    <link href="Helper/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class=" page-holder d-flex align-items-center">
            <div class="container">
                <div class="row align-items-center py-5">
                    <div class="col-lg-5 px-lg-4">
                        <h1 class="text-base text-primary text-uppercase mb-4">Login Here</h1>
                        <h2 class="mb-4">Welcome</h2>

                        <div class ="form-group mb-4">
                            <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" id="txtEmailLogin" placeholder="Email" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Email is Required" ControlToValidate="txtEmailLogin" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ErrorMessage="Email is Invalid" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </div>

                             <div class ="form-group mb-4">
                            <asp:TextBox required= "true" TextMode="Password" CssClass="form-control border-0 shadow form-control-lg text-base" id="txtPassword" placeholder="Password" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Password is Required" ControlToValidate="txtPassword" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group mb-4">
                            <div class="custom-control custom-checkbox">
                                <asp:CheckBox Text="&nbsp&nbsp&nbspRemember Me" runat="server" />
                            </div>
                        </div>
                        <asp:Button Text="LOGIN" CssClass="btn btn-primary" Height="50px" Width="400px" runat="server" OnClick="btnLogin" />
                        <a href="HomePage.aspx" type="button" class="btn btn-warning"  Height="20px" Width="100px">Go Back To HomePage</a>
                    </div>
                </div>
            </div>
            
        </div>
    </form>
</body>
</html>

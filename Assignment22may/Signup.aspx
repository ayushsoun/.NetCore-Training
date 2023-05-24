<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="LoginSignUp.Signup" %>

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
                        <h1 class="text-base text-primary text-uppercase mb-4">Sign up Here</h1>
                        <h2 class="mb-4">Welcome Back!</h2>

                        <div class ="form-group mb-4">
                            <asp:TextBox required="true" CssClass="form-control border-0 shadow form-control-lg text-base"
                                ID="txtFname" placeholder="First Name" runat="server" OnTextChanged="txtFname_TextChanged">

                            </asp:TextBox><asp:RequiredFieldValidator runat="server" ControlToValidate="txtFname" ErrorMessage="First Name is Required" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                        </div>
                        <div class ="form-group mb-4">
                            <asp:TextBox required="true" CssClass="form-control border-0 shadow form-control-lg text-base" 
                                id ="txtLname" placeholder="Last Name" runat="server" OnTextChanged="Unnamed2_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Last Name is Required" ControlToValidate="txtLname" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>
                         <div class ="form-group mb-4">
                             <asp:TextBox required="true" TextMode="Email" CssClass="form-control border-0 shadow form-control-lg text-base"
                                 ID="txtEmail" placeholder="Email Id" runat="server" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Email is Required" ControlToValidate="txtEmail" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                         <asp:RegularExpressionValidator runat="server" ErrorMessage="Email is Invalid" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </div>

                        <div class ="form-group mb-4">
                        <asp:TextBox required= "true" TextMode="Number" CssClass="form-control border-0 shadow form-control-lg text-base" 
                            id ="txtAge" placeholder="Age" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Age is Required" ControlToValidate="txtAge" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>

                        <div class ="form-group mb-4">
                        <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base" 
                            id="txtCity" placeholder="City" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="City is Required" ControlToValidate="txtcity" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>
                        
                        <div class ="form-group mb-4">
                        <asp:TextBox required= "true" CssClass="form-control border-0 shadow form-control-lg text-base"
                            id ="txtGender" placeholder="Gender" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Gender is Required" ControlToValidate="txtGender" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                        </div>

                        <h3 class="text-base text text-uppercase mb-2">SKills-:</h3>
                         <div class="form-check" id ="txtSkill1">
                              <input class="form-check-input" type="checkbox" id="check1" name="option1" value="something" checked>
                              <label class="form-check-label">ABC</label>
                         </div>
                         <div class="form-check" id ="txtSkill1">
                             <input class="form-check-input" type="checkbox" id="check2" name="option2" value="something" checkedchecked>
                              <label class="form-check-label">XYZ</label>
                         </div>
                        <div class="form-check mb-4" id ="txtSkill1">
                             <input class="form-check-input" type="checkbox" id="check3" name="option3" value="something" checked>
                              <label class="form-check-label">PQR</label>
                        </div> 
                       
                        <asp:Button Text="Sign up" CssClass="btn btn-primary" Height="50px" Width="400px" runat="server" OnClick="btnRegister" />
                        <a href="HomePage.aspx" type="button" class="btn btn-warning"  Height="20px" Width="100px">Go Back To HomePage</a>
                    </div>
                </div>
            </div>
            
        </div>
    </form>
</body>
</html>

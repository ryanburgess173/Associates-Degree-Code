<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="css/style1.css" type="text/css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="icon" href="images/favicon.gif" type="image">
        <title>Pet Shop Home</title>
    </head>
    
    <body>
        <header>
            <img id="paw" src="images/pawPrint.gif">
            <span>Pet Shop</span>
            <div class="navbar" id="responsiveNavBar">
                <ul>
                    <li><a href="index.html" >HOME</a></li>
                    <li><a href="about.html">ABOUT</a></li>
                    <li><a href="store.html">STORE</a></li>
                    <li><a href="contactForm.html" >CONTACT</a></li>
                    
                    <li><a href="login.html" class="active">LOGIN</a></li>
                    <a href="#" class="icon" onclick="myFunction()">
                        <i class="fa fa-bars"></i></a>
                </ul>
            </div>
        </header>
        
        <main>
            <br>
            
            <form>
                <fieldset>
                    <legend>Login</legend>
                    <label>UserName:  </label><br>
                    <input type="username" name="username"><br><br>
                    <label>Password:  </label><br>
                    <input type="password" name="password"><br><br>
                    
                    <button type="submit" value="Submit">Submit</button><br><br>
                </fieldset>
            </form>
        </main>
        
        <!--including my js file-->
        <script src="js/navbar.js"></script>
        
    </body>
    

</html>

















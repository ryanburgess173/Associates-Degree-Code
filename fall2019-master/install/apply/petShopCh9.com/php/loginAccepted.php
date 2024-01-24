<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/style1.css" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="icon" href="../images/favicon.gif" type="image">
    <title>Pet Shop Home</title>
</head>

<body>
<header>
</header>

<main>
    <img id="paw" src="../images/pawPrint.gif">
    <span>Pet Shop</span>
    <div id="accounts"><a href="../login.html">login</a>&nbsp;|&nbsp;<a href="../signup.html">signup</a></div>
    <div class="navbar" id="responsiveNavBar">
        <ul>
            <li><a href="../index.html" class="active">HOME</a></li>
            <li><a href="../about.html">ABOUT</a></li>
            <li><a href="../store.html">STORE</a></li>
            <li><a href="contactForm.html">CONTACT</a></li>
            <a href="#" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i></a>
        </ul>
    </div>
    <br>
    <p>Welcome, <?php session_start(); echo $_SESSION["customer_name"];  ?> </p>

    <div>
        <a href="#">Purchase History</a>
        <br>
        <a href='#'>Change Password</a>
        <br>
        <a href='#'>Update Account Information</a>
        <br>
        <a href="#">Delete Account</a>
    </div>
    <br><br><br>
    <img id="pets" src="../images/pets2.jpeg">
</main>

<!--including my js file-->
<script src="../js/navbar.js"></script>

</body>


</html>

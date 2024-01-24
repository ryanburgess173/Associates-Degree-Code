<?php $pageName = "Home"; ?>
<html>

<head>
    <link rel="stylesheet" href="../../css/styles.css" type="text/css">
    <link rel="stylesheet" href="../../css/GoogleFonts.css" type="text/css">
    <link rel="stylesheet" href="../../css/bootstrap.min.css" type="text/css">
    <script rel="script" src="js/jquery.min.js" type="text/javascript"></script>
    <script rel="stylesheet" src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.min.js"></script>
</head>

<body class="container-fluid">

<header>
    <div class="header-contents">
        <a href="../../index.php">
            <div id="logo-outer">
                <div id="logo-middle">
                    <div id="logo-inner">
                    </div>
                </div>
            </div>
        </a>
        <h1 id="title">Burgess CDs, Tapes, & Vinyl</h1>
        <h2 id="subtitle">High-Quality Music in the Most Classic Formats</h2>
    </div>
</header>

<nav class="navbar navbar-inverse">
    <div class="container-fluid">
        <ul class="nav navbar-nav">
            <li><a href="../../index.php"><?php echo $pageName; ?></a></li>
            <li><a href="../../about.php">About</a></li>
            <li><a href="../../store.php">Store</a></li>
            <li><a href="../../contact.php">Contact Us</a></li>
        </ul>
        <ul class="nav navbar-nav navbar-right">
            <li><a href="../../customerLogin.php"><span class="glyphicon glyphicon-log-in"></span> Login</a>
            </li>
            <li><a href="../../registerAccount.php"><span class="glyphicon glyphicon-log-in"></span> Register</a>
            </li>
            <li><a href="accountManagement.php"><span class="glyphicon glyphicon-log-in"></span> Account
                </a></li>
            <li><a href="logoutPage.php"><span class="glyphicon glyphicon-log-in"></span> Logout
                </a></li>
        </ul>
    </div>
</nav>

<?php
if (!isset($page_title)) {
    $page_title = 'Staff Area';
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>GBI</title>
    <link href="https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/darkly/bootstrap.min.css" rel="stylesheet"
          integrity="sha384-w+8Gqjk9Cuo6XH9HKHG5t5I1VR4YBNdPt/29vwgfZR485eoEJZ8rJRbm3TR32P6k" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
            integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
            crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <link href="<?php echo url_for('../stylesheets/staff.css'); ?>" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Sumana&display=swap" rel="stylesheet">
<body>
<div class="container-fluid">
    <header>
        <h1>GBI <?php echo $page_title; ?></h1>
    </header>
    <nav>
        <ul>
            <li><a href="<?php echo url_for("../index.php"); ?>">Menu</a></li>
        </ul>
    </nav>
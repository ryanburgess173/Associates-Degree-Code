<?php include('../account-header.php'); ?>
<main>
    <?php session_start(); ?>
    <?php if (isset($_SESSION["admin_name"])) {
        echo "<p>Welcome, ";
        echo $_SESSION["admin_name"];
        echo " </p >";
        echo "<div><a href = \"#\">Inventory</a>";
        echo "<br><a href='changeAdminPasswordPage.php'>Change Password</a><br><a href='#'>Update Account Information</a><br>
<a href='deleteAccountPage.php'>Delete Account</a><br><a href='#'>Create New Administrator</a><br><a href='#'>Contact Requests</a>
</div>";
    } else {
        echo "<h3>You must login as an administrator first!</h3>";
    } ?>
</main>
<?php include('../account-footer.php'); ?>

<?php include('../account-header.php'); ?>
<main>
    <?php session_start();?>
    <?php if (isset($_SESSION["customer_name"])) {
        echo "<p>Welcome, ";
        echo $_SESSION["customer_name"];
        echo " </p ><div > ";
        echo "<a href = \"#\">Purchase History</a>";
        echo "<br><a href='changePasswordPage.php'>Change Password</a><br><a href='#'>Update Account Information</a><br>
<a href='deleteAccountPage.php'>Delete Account</a>
</div>";
    } else {
        echo "<h3>You must login first!</h3>";
    } ?>
</main>
<?php include('../account-footer.php'); ?>

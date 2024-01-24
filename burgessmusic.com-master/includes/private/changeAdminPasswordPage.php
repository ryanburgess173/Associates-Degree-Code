<?php include('../account-header.php'); ?>
<?php session_start(); ?>
<?php if(isset($_SESSION['admin_id'])){
    echo '<main>
        <script>
            function validate(){
                var a = document.getElementById("newPassword").value;
                var b = document.getElementById("newPasswordConfirm").value;
                if (a!=b) {
                    alert("Passwords do no match");
                    return false;
                }
            }
        </script>
        <h3>Change/Reset Admin Password</h3>
        <form method="post" action="scripts/changeAdminPassword.php" onsubmit="return validate();">
            <label class="form-group">
                Username: &nbsp;<input type="text" name="username" id="username" required>
            </label><br>
            <label class="form-group">
                Old Password: &nbsp;<input type="password" name="oldPassword" id="oldPassword" required>
            </label><br>
            <label class="form-group">
                New Password: &nbsp;<input type="password" name="newPassword" id="newPassword" required>
            </label><br>
            <label class="form-group">
                Confirm New Password: &nbsp;<input type="password" name="newPasswordConfirm" id="newPasswordConfirm" required>
            </label><br>
            <input type="submit" class="cyanButton btn btn-primary btn-lg">
        </form>
    </main>';
}
?>
<?php include('../account-footer.php'); ?>

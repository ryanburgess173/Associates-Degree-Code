<?php include('../account-header.php'); ?>
<script>
    function redirectHome(){
        window.location = "accountManagement.php";
    }
</script>
<main>
    <?php session_start();?>
    <h3>Are you sure you want to delete your account <?php echo $_SESSION['customer_name'];?>?</h3>
    <form action="scripts/deleteAccount.php">
        <input type="submit" value="Yes" class="cyanButton btn btn-primary btn-lg">
        <input type="button" value="No" class="cyanButton btn btn-primary btn-lg" onclick="redirectHome();">
    </form>
</main>
<?php include('../account-footer.php'); ?>

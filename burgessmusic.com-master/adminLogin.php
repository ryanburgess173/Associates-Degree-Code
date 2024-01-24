<?php include("includes/home-header.php"); ?>
<main>
    <h3 class="fadeInContent">Admin Login</h3><br><hr class="fadeInContent">
    <form method="post" action="includes/private/scripts/adminLoginValidation.php" class="fadeInContent">
        <fieldset>
            <label>UserName:  </label><br>
            <input type="username" name="username" required><br><br>
            <label>Password:  </label><br>
            <input type="password" name="password" required><br><br>
            <input type="submit" value="Submit"/><br><br>
        </fieldset>
    </form>
    <script src="js/fadeInContent.js"></script>
</main>
<?php include("includes/home-footer.php"); ?>

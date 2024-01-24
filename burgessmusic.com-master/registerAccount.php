<?php include('includes/home-header.php'); ?>
<main>
    <h3 class="fadeInContent">Register for Customer Account</h3><br><hr>
    <form method="post" action="includes/scripts/registerStandardUser.php" class="fadeInContent">
        <fieldset>
            <label>First Name: </label><br>
            <input type="text" name="fname" required><br><br>
            <label>Last Name:  </label><br>
            <input type="text" name="lname" required><br><br>
            <label>Email:  </label><br>
            <input type="email" name="email" required><br><br>
            <label>Phone:  </label><br>
            <input type="phone" name="phone"><br><br>
            <label>UserName:  </label><br>
            <input type="username" name="username" required><br><br>
            <label>Password:  </label><br>
            <input type="password" name="password" required><br><br>

            <input type="submit" value="Submit" class="cyanButton btn btn-primary btn-lg"/><br><br>
        </fieldset>
    </form>
    <script src="js/fadeInContent.js"></script>
</main>
<?php include('includes/home-footer.php'); ?>

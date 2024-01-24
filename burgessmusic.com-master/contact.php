<?php include('includes/home-header.php'); ?>
<main>
    <h2 class="fadeInContent">Contact Us</h2>
    <hr>
    <form method="post" action="includes/scripts/insertContactRecord.php" class="fadeInContent">
        <div class="form-group">
            <label for="fname">First Name: </label><input type="text" id="fname" name="fname" required><br><br>
        </div>
        <div class="form-group">
            <label for="lname">Last Name: </label><input type="text" id="lname" name="lname" required><br><br>
        </div>
        <div class="form-group">
            <label for="email">Email: </label><input type="email" id="email" name="email" required><br><br>
        </div>
        <div class="form-group">
            <label for="phone">Phone: </label><input type="text" id="phone" name="phone"><br><br>
        </div>
        <div class="form-group">
            <label for="message">Message: </label><br><textarea id="message" name="message" rows="12" cols="60"></textarea><br><br>
        </div>
        <input type="submit" class="cyanButton btn btn-primary btn-lg">
    </form>
    <script src="js/fadeInContent.js"></script>
</main>
<?php include('includes/home-footer.php'); ?>


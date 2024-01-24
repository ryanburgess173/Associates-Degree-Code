<?php include('../private/shared/form1_header.php');?>
<main>
    <form action="../private/form1_process.php">
        <label>
            <h5 class="fieldLabel">First Name:</h5>
            <input name="firstName" type="text">
        </label><br>
        <label>
            <h5 class="fieldLabel">Last Name:</h5>
            <input name="lastName" type="text">
        </label><br>
        <label>
            <h5 class="fieldLabel">Phone Number:</h5>
            <input name="phone" type="text">
        </label><br>
        <label>
            <h5 class="fieldLabel">Email Address:</h5>
            <input name="email" type="text">
        </label><br>
        <label>
            <h5 class="fieldLabel">Comments:</h5>
            <textarea name="comments" rows="5" cols="35">
            </textarea>
        </label><br>
        <input type="submit">
    </form>
</main>
<?php include('../private/shared/form1_footer.php');?>
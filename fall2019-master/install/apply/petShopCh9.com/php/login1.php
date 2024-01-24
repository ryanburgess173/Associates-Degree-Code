<?php
//check to see if this form has been submitted
//if form has been submitted
if ($_SERVER['REQUEST_METHOD'] == 'POST') {

    //collect entered username and password
    $username = $_POST['username'];
    $password = $_POST['password'];

    include "../db_connect.php";

    //collect password from database if there is a username that matches the username entered
    $sql = "SELECT hashed_password FROM customeraccounts WHERE username='$username'";

    //run query and display results
    $r = mysqli_query($db_connection, $sql);
    if ($r) {
        while ($hashed_password = mysqli_fetch_array($r, MYSQLI_BOTH)){
            //echo $hashed_password["hashed_password"];
            $pp = $hashed_password["hashed_password"];
        }
        //verify password
        if (password_verify($password, $pp)) {
            echo '<p>Matched</p>';
            //collect customers name from the database
            $sql2 = "SELECT firstName FROM customeraccounts WHERE username='$username'";

            //run the query
            $r2 = mysqli_query($db_connection, $sql2);

            //store customers name
            $customer_name = mysqli_fetch_array($r2, MYSQLI_BOTH);

            //start session to send data across all pages
            session_start();
            //set session variables
            $_SESSION["customer_name"] = $customer_name["firstName"];

            //open loginAccepted.html page
            $url = 'loginAccepted.php';
            header('Location: ' . $url);
        } else {
            echo '<p>Not a Match</p>';
        }

    } else {
        echo "Error: " . $sql . "<br>" . mysqli_error($db_connection);
    }
    mysqli_close($db_connection);
}
?>

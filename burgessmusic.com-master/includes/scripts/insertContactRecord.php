<?php

// include our connection to our database
include('db_connect.php');

// attempt to retrieve our data
$fname = $_POST['fname'];
$lname = $_POST['lname'];
$email = $_POST['email'];
if(isset($_POST['phone'])){
    $phone = $_POST['phone'];
}else{
    $phone = "";
}
if(isset($_POST['message'])){
    $message = $_POST['message'];
}else{
    $message = "";
}

// create an SQL script
$sql = "INSERT INTO contacts(fname, lname, email, phone, message) VALUES
('$fname', '$lname', '$email', '$phone', '$message')";

//run our insert and display the server's returned message
if(mysqli_query($db_connection, $sql)){
    echo"<br><br>New Record added successfully.";
}else{
    echo "Database Error: ".$sql."<br>".mysqli_error($db_connection);
}

mysqli_close($db_connection);
?>

<br><br><br>
<a href="../../index.php">Back to Home Page</a><br><br>
<a href="../../contact.php">Back to Contact Us Page</a>

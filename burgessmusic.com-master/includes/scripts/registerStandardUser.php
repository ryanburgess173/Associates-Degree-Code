<?php

//connect to the petShop Database
include "db_connect.php";

$firstName = $_POST['fname'];
$lastName = $_POST['lname'];
$email = $_POST['email'];
$phone = $_POST['phone'];
$username = $_POST['username'];
$password = $_POST['password'];

//hash the password
$hashed_password = password_hash($password, PASSWORD_BCRYPT);

//sql insert command
$sql = "
INSERT INTO standard_users(firstName, lastName, email, phone, username, password) 
VALUES('$firstName', '$lastName', '$email', '$phone', '$username', '$hashed_password')";

//run query and display results
if (mysqli_query($db_connection, $sql)){
    $url = '../private/createdAccountSuccessfully.php';
    header('Location: '.$url);
}
else{
    echo "Error: ".$sql."<br>".mysqli_error($db_connection);
}

//close the database
mysqli_close($db_connection);

?>

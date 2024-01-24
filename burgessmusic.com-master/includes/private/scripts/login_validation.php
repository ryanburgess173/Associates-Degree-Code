<?php
session_start();
include('../scripts/db_connect.php');

if(isset($_SESSION['id'])){
    header('Location: myaccount.php');
}

$error_message = '';
if(isset($_POST['submit'])){

    extract($_POST);

    if(!empty($email) && !empty($password)){
        $sql = "SELECT id, status FROM users WHERE email = '"
            .$db_connection->real_escape_string($email)."' AND password = '"
            .md5($db_connection->real_escape_string($password))."'";
        $result = $db_connection->query($sql);

        if($result->num_rows > 0){
            $row = $result->fetch_assoc();
            if($row['status']){
                $_SESSION['id'] = $row['id'];
                header('Location: myaccount.php');
            }else{
                $error_message = 'Your account is not active yet.';
            }
        }else{
            $error_message = 'Incorrect email or password.';
        }
    }
}
?>

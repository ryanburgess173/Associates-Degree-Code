<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
    $username = $_POST['username'];
    $password = $_POST['password'];
    include '../../scripts/db_connect.php';

    $sql_script = "SELECT password FROM standard_users WHERE username='$username'";
    $query_result = mysqli_query($db_connection, $sql_script);

    if($query_result){
        while($hashed_password = mysqli_fetch_array($query_result, MYSQLI_BOTH)){
            $pp = $hashed_password["password"];
        }
        if(password_verify($password, $pp)){
            $sql_script_2 = "SELECT userID, firstName FROM standard_users WHERE username='$username'";
            $query_result_2 = mysqli_query($db_connection, $sql_script_2);
            $customer_name = mysqli_fetch_array($query_result_2, MYSQLI_BOTH);
            session_start();
            $_SESSION["customer_name"] = $customer_name["firstName"];
            $_SESSION["user_id"] = $customer_name["userID"];
            $success_url = '../accountManagement.php';
            header('Location: '.$success_url);
        }else{
            $failure_url = '../../../loginFailed.php';
            header('Location: '.$failure_url);
        }
    }
}

<?php
if($_SERVER['REQUEST_METHOD']=='POST'){
    $username = $_POST['username'];
    $password = $_POST['password'];
    include '../../scripts/db_connect.php';

    $sql = "SELECT password FROM administrators WHERE username='$username'";
    $query = mysqli_query($db_connection, $sql);

    if($query){
        while($hashed_password = mysqli_fetch_array($query, MYSQLI_BOTH)){
            $pp = $hashed_password["password"];
        }
        if(password_verify($password, $pp)){
            $sql_2 = "SELECT adminID, firstName, role FROM administrators WHERE username='$username'";
            $query_2 = mysqli_query($db_connection, $sql_2);
            $admin_name = mysqli_fetch_array($query_2, MYSQLI_BOTH);
            session_start();
            $_SESSION["admin_name"] = $admin_name["firstName"];
            $_SESSION["admin_id"] = $admin_name["adminID"];
            $_SESSION["role"] = $admin_name["role"];
            $success_url = '../adminManagement.php';
            header('Location: '.$success_url);
        }else{
            $failure_url = '../../../loginFailed.php';
            header('Location: '.$failure_url);
        }
    }
}
?>

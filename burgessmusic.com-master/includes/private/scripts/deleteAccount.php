<?php

session_start();
$userID = $_SESSION['user_id'];

include '../../scripts/db_connect.php';
$sql_script_delete_account = "DELETE FROM standard_users WHERE userID = '$userID';";
$execute_script_result = mysqli_query($db_connection, $sql_script_delete_account);

if($execute_script_result){
    $url = "../deleteAccountSuccess.php";
}else{
    //echo $execute_script_result;
    $url = "../deleteAccountFail.php";
}
header("Location: ".$url);

?>

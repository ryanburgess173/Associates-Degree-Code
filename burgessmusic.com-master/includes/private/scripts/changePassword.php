<?php
if ($_SERVER['REQUEST_METHOD'] == "POST") {
    // I'm checking it on the backend in case browser has javascript disabled.
    if (isset($_POST['username'])) {
        $username = $_POST['username'];
    }
    if (isset($_POST['oldPassword'])) {
        $oldPassword = $_POST['oldPassword'];
    }
    if (isset($_POST['newPassword'])) {
        $newPassword = $_POST['newPassword'];
    }
    if (isset($_POST['newPasswordConfirm'])) {
        $newPasswordConfirm = $_POST['newPasswordConfirm'];
    }
    include '../../scripts/db_connect.php';

    $sql_script = "SELECT password FROM standard_users WHERE username='$username'";
    $query_result = mysqli_query($db_connection, $sql_script);

    if ($query_result) {

        while ($hashed_password = mysqli_fetch_array($query_result, MYSQLI_BOTH)) {
            $pp = $hashed_password["password"];
        }

        if (password_verify($oldPassword, $pp)) {

            if ($newPassword == $newPasswordConfirm){

                $encryptedPassword = password_hash($newPassword,PASSWORD_BCRYPT);

                $sql_change_password_script = "UPDATE standard_users SET password = '$encryptedPassword' WHERE username = '$username'";
                $script_result = mysqli_query($db_connection, $sql_change_password_script);

                if($script_result){

                    $url="../passwordChangeSuccess.php";
                    header("Location:".$url);
                }
            }else{
                echo "<p>Passwords do not match!</p>";
            }
        } else {
            echo "<p>Incorrect old password.</p>";
        }
    }
}
?>

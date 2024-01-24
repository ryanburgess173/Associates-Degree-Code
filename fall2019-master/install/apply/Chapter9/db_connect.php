<?php

//connect to database
$db_connection = mysqli_connect('localhost', 'root', '', 'petShop')
OR
die(mysqli_connect_error());

// check connection
if (!$db_connection){
    die("Connection failed: ".mysqli_connect_error());
}

echo "<p>Connected successfully</p>";

//display MySQL version and host
if(mysqli_ping($db_connection)){
    echo 'MySQL Server '.mysqli_get_server_info($db_connection).' on '.
    mysqli_get_host_info($db_connection);
}

?>

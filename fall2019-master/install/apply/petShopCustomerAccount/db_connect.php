<?php

$db_connection = mysqli_connect('localhost', 'root', '', 'petshop');

if($db_connection){
    echo '<h1> Connected to the petShop database </h1>';
}
else{
    echo '<h1> Not Connected to MySQL </h1>';
}
    
?>

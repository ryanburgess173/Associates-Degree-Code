<?php

// adds reference to the db_connect.php file
include "db_connect.php";

// defines our SQL script
$sql = "SHOW TABLES";

// holds returned value from SQL script
$result = mysqli_query($db_connection, $sql);

// if SQL script returned something
if($result){
    // h1 tag to explain tables were found in the PetShop database
    echo "<h1>Tables found in the PetShop database</h1>";
    // opening header-3 tag and opening unordered-list tag
    echo "<h3><ul>";

    // print out each element of an array equal to the result of our script
    while($row = mysqli_fetch_array($result, MYSQLI_NUM)){
        // outputs current element of our row array
        echo "<li>".$row[0]."</li>";
    }

    // outputs html closing h3 and ul tags
    echo "</h3></ul>";

// if SQL script didn't return anything:
}else{
    // outputs error
    echo "<p>".mysqli_error($db_connection)."</p>";
}

// closes the database connection
mysqli_close($db_connection);

?>

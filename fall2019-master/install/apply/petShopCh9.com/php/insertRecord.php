<?php
//connect to the PetShop database
include "../db_connect.php";

// sql command string
$sql = "INSERT INTO message(fname, lname, email, phone, message)
VALUES('Judy', 'Garland', 'jgarland@gtcc.edu', '111-222-1234', 'I love your site')";

// run query and display results
if (mysqli_query($db_connection, $sql)){
    // outputs a message saying the sql query executed successfully on the server
    echo "<br><br>New Record created successfully";
}else{
    // outputs an error message
    echo "Error: " . $sql . "<br>" . mysqli_error($db_connection);
}

// close the database
mysqli_close($db_connection);

?>

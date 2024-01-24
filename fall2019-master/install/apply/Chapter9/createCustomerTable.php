<?php
// connect to the PetShop database
include "db_connect.php";

// sql to create the customers table in the PetShop database
$sql = "CREATE TABLE customers(
customer_id INT(30) AUTO_INCREMENT PRIMARY KEY,
first_name VARCHAR(30) NOT NULL,
last_name VARCHAR(30) NOT NULL,
email VARCHAR(50),
address VARCHAR(100),
zipcode INT(5)
)";

// if the SQL Script executes correctly on the MySQL server connection we defined in db_connect.php
if(mysqli_query($db_connection, $sql)){
    echo "The customer table has been successfully added to the PetShop database";
}else{
    // if the SQL script fails then display an error to the user
    echo "There was an error creating the customers table:
    ".mysqli_error($db_connection);
}
// close database
mysqli_close($db_connection);

?>

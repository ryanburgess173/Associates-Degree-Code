<?php

// checks the super-variable first - default '1' if it's not set
$id = $_GET['id'] ?? '1';

echo $id;

?>
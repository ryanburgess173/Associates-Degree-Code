<?php

if (isset($_POST['submit'])) {
    if (isset($_POST['groceries'])) {
        $groceries = $_POST['groceries'];
    } else {
        echo "error";
    }
}

?>
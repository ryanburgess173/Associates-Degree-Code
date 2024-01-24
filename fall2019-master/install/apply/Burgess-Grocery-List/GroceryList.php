<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="https://bootswatch.com/4/solar/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
<div class="container-fluid">
    <header>
        <h1>Grocery List</h1>
    </header>
    <nav></nav>
    <main>
        <ul>
            <?php
            $grocery_list = array("Bananas", "Grapes", "Cucumbers", "Carrots");

            foreach ($grocery_list as &$item) {
                echo "<li>" . $item . "</li>";
            }
            ?>
        </ul>
    </main>
    <footer></footer>
</div>
</body>
</html>
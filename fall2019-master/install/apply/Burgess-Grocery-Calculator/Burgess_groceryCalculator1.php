<!--

Johnathan R. Burgess
WEB-250 Database Driven Websites
10/20/2019
This is my own and original work.

-->
<!DOCTYPE html>

<html>

<head>
    <link rel="stylesheet" href="stylesheets/styles.css">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/darkly/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

</head>

<body>
<div class="container-fluid">
    <header>

    </header>
    <nav></nav>
    <?php

    $page_title = "Grocery Store Calculator";
    $grocery_items = ["Grapes" => 4.00,
        "Bananas" => 3.00,
        "Cucumbers" => 2.00,
        "Carrots" => 2.00];
    $choices = array();

    function create_checkboxes($groceries)
    {
        foreach ($groceries as $key => $value) {
            echo '<div class="checkbox"><input type="checkbox" name="' . $key .
                '" value="' . $value .
                '">' . $key . '<br></div>';
        }
    }

    // this function calculates your tax and total from the subtotal
    function calculate_and_output($item_chosen, $subtotal, $choices, $grocery_items)
    {
        if ($item_chosen) {
            // assumes a sales tax of 6.5% which is common in Alamance County which is where I live.
            $tax = $subtotal * 0.065;
            $total = $subtotal + $tax;
            echo "<h3>Receipt</h3>";
            echo '<p>For: ' . $_POST['firstName'] . ' ' . $_POST['lastName'] . '</p>';
            foreach ($choices as $i) {
                echo '<p>' . $i . " $" . $grocery_items[$i] . "</p>";
            }
            echo "<table class='table table-striped'><tr><td>Subtotal:</td><td>" . "$" . number_format($subtotal, 2) . "</td></tr>";
            echo "<tr><td>Tax:</td><td>" . "$" . number_format($tax, 2) . "</td></tr>";
            echo "<tr><td>Total:</td><td>" . "$" . number_format($total, 2) . "</td></tr></table>";
        } else {
            // Error handling
            echo '<p class="error">Please choose at least 1 grocery item.</p>';
        }
    }

    function test_for_selections($grocery_items, $choices)
    {
        $subtotal = 0.0;
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $item_chosen = false;
            if (isset($_POST["Grapes"])) {
                $item_chosen = true;
                $subtotal += $grocery_items["Grapes"];
                array_push($choices, "Grapes");
            }
            if (isset($_POST["Bananas"])) {
                $item_chosen = true;
                $subtotal += $grocery_items["Bananas"];
                array_push($choices, "Bananas");
            }
            if (isset($_POST["Cucumbers"])) {
                $item_chosen = true;
                $subtotal += $grocery_items["Cucumbers"];
                array_push($choices, "Cucumbers");
            }
            if (isset($_POST["Carrots"])) {
                $item_chosen = true;
                $subtotal += $grocery_items["Carrots"];
                array_push($choices, "Carrots");
            }
            calculate_and_output($item_chosen, $subtotal, $choices, $grocery_items);
        }
    }

    ?>
    <main>
        <div class="jumbotron">
            <?php echo "<h1>$page_title</h1>"; ?>
        </div>
        <form method="post" action="Burgess_groceryCalculator1.php">
            <h4 class="thingy">Enter Name:</h4>
            <label>First:&nbsp&nbsp<input type="text" name="firstName" required></label><br><br>
            <label>Last:&nbsp&nbsp<input type="text" name="lastName" required></label>
            <h4>Choose Groceries:</h4>
            <?php create_checkboxes($grocery_items); ?>
            <br><input type="submit" value="Calculate Total">
        </form>
        <div class="outputBox">
            <?php
            test_for_selections($grocery_items, $choices);
            ?>
        </div>
    </main>
    <footer>

    </footer>
</div>
</body>

</html>

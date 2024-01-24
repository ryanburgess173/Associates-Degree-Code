<?php
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

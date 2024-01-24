<!--

Johnathan R. Burgess
WEB-250 Database Driven Websites
10/20/2019
This is my own and original work.

-->
<?php
include('includes/initialize.php');
?>
<main>
    <div class="jumbotron">
        <?php echo "<h1>$page_title</h1>"; ?>
    </div>
    <form method="post" action="Burgess_groceryCalculator2.php">
        <h4 class="thingy">Enter Name:</h4>
        <label>First:&nbsp&nbsp<input type="text" name="firstName" required></label><br><br>
        <label>Last:&nbsp&nbsp<input type="text" name="lastName" required></label>
        <h4>Choose Groceries:</h4>
        <?php create_checkboxes($grocery_items); ?>
        <br><input type="submit" value="Calculate Total">
    </form>
    <div class="outputBox">
        <?php
        test_for_selections($grocery_items, $choices, $grocery_items);
        ?>
    </div>
</main>
<?php include('includes/main-footer.html'); ?>

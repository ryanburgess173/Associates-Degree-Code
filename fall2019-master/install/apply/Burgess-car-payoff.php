<!DOCTYPE html>
<!-- This website template was created by: Johnathan R. Burgess -->
<html lang="en">
<head>
    <link rel="stylesheet" href="css/applystyles07.css">
    <title></title>
    <meta charset="utf-8">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Abril+Fatface|Noto+Serif|Raleway&display=swap" rel="stylesheet">
</head>
<body>

<div class="container-fluid">

    <header>
        <img id="headerImage" src="images/435917.jpg">
        <h1>Lorem Ipsum</h1>
    </header>

    <nav>
        <ul class="navigationLinks">
            <li><a href="apply07.php">Home</a></li>
            <li><a href="BurgessHelloWorld.php">Link2</a></li>
            <li><a href="Burgess-car-payoff.php">Link3</a></li>
            <li><a href="link4.html">Link4</a></li>
        </ul>
    </nav>
    <div class="row">

        <div class="col-lg-9">
            <main>
                <?php
                function main()
                {
                    $favoriteCar = "1966 Ford Mustang";
                    $cost = 70000;
                    $results = calculate($cost);
                    output($favoriteCar, $cost, $results);
                }

                function calculate($cost)
                {
                    $noInterestMonthlyOneYear = $cost / 12;
                    $noInterestMonthlyTwoYear = $cost / 24;
                    $results = array($noInterestMonthlyOneYear, $noInterestMonthlyTwoYear);
                    return $results;
                }

                function output($favoriteCar, $cost, $results)
                {
                    echo "<h3>My favorite car is a " . $favoriteCar . ".</h3><br>";
                    echo "<h4 class='fieldLabel'>It costs approximately $" . number_format($cost, 2) . "</h4><br>";
                    echo "<h4 class='fieldLabel'>If I don't have to pay interest it would take $" . number_format($results[0], 2) . " a month to<br>pay the car off in a year.</h4><br>";
                    echo "<h4 class='fieldLabel'>If I don't have to pay interest it would take $" . number_format($results[1], 2) . " a month to<br>pay the car off in two years.</h4>";
                }

                main();
                ?>
            </main>
        </div>

        <div class="col-lg-3">
            <aside>
                <h3>Practice Makes Perfect</h3>
                <p>Webpage design is a skill learned over time. You must practice to improve.</p>
            </aside>
        </div>
    </div>
    <footer>
        <br>
        <p>Designed by: Johnathan R. Burgess</p>
    </footer>

</div>

</body>
</html>
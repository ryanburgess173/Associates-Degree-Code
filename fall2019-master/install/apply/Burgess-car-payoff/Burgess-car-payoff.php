<?php
function main()
{
    $input_data = getInput();
    if ($input_data != null) {
        $installments = calculateInstallments($input_data[3]);
        outputResults($input_data, $installments);
    } else {
        error_log("invalid data input");
    }
}
function getInput()
{
    if (!empty($_POST['year'])) {
        $year = $_POST['year'];
        if (!empty($_POST['make'])) {
            $make = $_POST['make'];
            if (!empty($_POST['model'])) {
                $model = $_POST['model'];
                if (!empty($_POST['price'])) {
                    $price = $_POST['price'];
                    if ($price > 0) {
                        return array($year, $make, $model, $price);
                    } else {
                        echo "<p style='color:red; font-weight:bold;'>* Price must be greater than 0.</p>";
                        return null;
                    }
                } else {
                    echo "<p style='color:red;'>* Price is Required.</p>";
                    return null;
                }
            } else {
                echo "<p style='color:red;'>* Model is Required.</p>";
                return null;
            }
        } else {
            echo "<p style='color:red;'>* Make is Required.</p>";
            return null;
        }
    } else {
        echo "<p style='color:red;'>* Year is Required.</p>";
        return null;
    }
}

function calculateInstallments($price)
{
    $twelveMonths = $price / 12;
    $twentyFourMonths = $price / 24;
    return array($twelveMonths, $twentyFourMonths);
}

function outputResults($input_data, $installments)
{
    echo "<h1>My favorite car is a " . $input_data[0] . " " . $input_data[1] . " " . $input_data[2] . ".</h1>";
    echo "<p>It costs approximately $" . number_format($input_data[3], 2) . "</p>";
    echo "<p>If I don't have to pay interest it would take $" . number_format($installments[0], 2) .
        " a month to pay the car off in a year.</p>";
    echo "<p>If I don't have to pay interest it would take $" . number_format($installments[1], 2) .
        " a month to pay the car off in 2 years.</p>";
}

main();
?>
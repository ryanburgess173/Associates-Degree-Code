<html>

<body>
<?php
/*
$username = "Ryan Burgess";
$htmlTagString = "<p>".$username."</p>";
echo $htmlTagString;
date_default_timezone_set('UTC');
echo date('h:i:s:u a, l F jS Y e');*/

$userName = $_POST['username'];
$address = $_POST['address'];
$city = $_POST['city'];
/*
echo "<hr>";
echo $userName . "<hr>";
echo $address . "<hr>";
echo $city . "<hr>";

$str = <<<EOD
The Customers name is
$userName and they live
at $address in $city</br>
EOD;

echo $str;

define('PI', 3.1415926);
echo "The value of pi is " . PI;
*/
echo "</br>5 + 2 = " . (5+2);
echo "</br>5 - 2 = " . (5-2);
echo "</br>5 * 2 = " . (5*2);
echo "</br>5 / 2 = " . (integer)(5/2);
echo "</br>5 % 2 = " . (5%2);
?>
</body>
</html>

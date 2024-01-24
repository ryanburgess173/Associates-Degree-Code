<?php
/*
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);*/

$fName = "";
$lName = "";
$email = "";
$phone = "";
$message = "";

$to_email_address = "johnathan.r.burgess@gmail.com";
if (isset($_POST['fName'])) {
    $fName = $_POST['fName'];
}
if (isset($_POST['lName'])) {
    $lName = $_POST['lName'];
}
if (isset($_POST['email'])) {
    $email = $_POST['email'];
}
if (isset($_POST['phone'])) {
    $phone = $_POST['phone'];
}
if (isset($_POST['message'])) {
    $message = $_POST['message'];
}
/*
$from = 'johnathan.r.burgess@gmail.com';
$subject = "[burgessmusic.com] contact us form";
$headers = "From: $from\n";
$headers .= "MIME-Version: 1.0\n";
$headers .= "Content-type: text/html; charset=iso-8859-1\n";
mail($to_email_address, $subject, $message, $headers); */


$string = file_get_contents('C:\xampp\PHPMailer\email_config.json');
$option = json_decode($string);

define("MAIL_USERNAME", $option->MAIL_USERNAME);
define("MAIL_PASSWORD", $option->MAIL_PASSWORD);

use PHPMailer\PHPMailer\Exception;
use PHPMailer\PHPMailer\PHPMailer;

require('C:\xampp\PHPMailer\src\Exception.php');
require('C:\xampp\PHPMailer\src\PHPMailer.php');
require('C:\xampp\PHPMailer\src\SMTP.php');

$Mail = new PHPMailer();
$Mail->IsSMTP(); // Use SMTP
$Mail->Host = "smtp.gmail.com"; // Sets SMTP server
$Mail->SMTPDebug = 2; // 2 to enable SMTP debug information
$Mail->SMTPAuth = TRUE; // enable SMTP authentication
$Mail->SMTPSecure = "tls"; //Secure conection
$Mail->Port = 587; // set the SMTP port
$Mail->Username = MAIL_USERNAME; // SMTP account username
$Mail->Password = MAIL_PASSWORD; // SMTP account password
$Mail->Priority = 1; // Highest priority - Email priority (1 = High, 3 = Normal, 5 = low)
$Mail->CharSet = 'UTF-8';
$Mail->Encoding = '8bit';
$Mail->Subject = 'Test Email Using Gmail';
$Mail->ContentType = 'text/html; charset=utf-8\r\n';
$Mail->From = MAIL_USERNAME;
$Mail->FromName = 'GMail Test';
$Mail->WordWrap = 900; // RFC 2822 Compliant for Max 998 characters per line

$Mail->AddAddress(MAIL_USERNAME); // To:
$Mail->isHTML(TRUE);
$Mail->Body = $message;
$Mail->AltBody = $message;
$Mail->Send();
$Mail->SmtpClose();

if ($Mail->IsError()) { // ADDED - This error checking was missing
    return FALSE;
} else {
    return TRUE;
}

?>


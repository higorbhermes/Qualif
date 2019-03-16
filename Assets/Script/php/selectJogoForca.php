<?php
$servername = "localhost";
$username = "id8750832_qualif";
$password = "abcd1234";
$dbname = "id8750832_qualif";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$id_forca = mysqli_real_escape_string($conn, $_GET['id']);
$opcao = mysqli_real_escape_string($conn, $_GET['opcao']);

$query = "SELECT * FROM Forca WHERE id_forca = '$id_forca'";

$statement = $conn->prepare($query);
$statement = execute();
$result = $statement->get_result();
$forcaArray = $result->fetch_assoc();

if ($forcaArray != null){
    if ($opcao == "1") {
        echo $forcaArray['id_forca'];
    } 
    if ($opcao == "2") {
        echo $forcaArray['num_letras'];
    } 
    if ($opcao == "3") {
        echo $forcaArray['letra_1'];
    } 
    if ($opcao == "4") {
        echo $forcaArray['letra_2'];
    } 
    if ($opcao == "5") {
        echo $forcaArray['letra_3'];
    } 
    if ($opcao == "6") {
        echo $forcaArray['letra_4'];
    } 
    if ($opcao == "7") {
        echo $forcaArray['letra_5'];
    } 
    if ($opcao == "8") {
        echo $forcaArray['letra_6'];
    } 
    if ($opcao == "9") {
        echo $forcaArray['letra_7'];
    } 
    if ($opcao == "10") {
        echo $forcaArray['letra_8'];
    } 
    if ($opcao == "11") {
        echo $forcaArray['letra_9'];
    } 
    if ($opcao == "12") {
        echo $forcaArray['letra_10'];
    } 
    if ($opcao == "13") {
        echo $forcaArray['letra_11'];
    } 
    if ($opcao == "14") {
        echo $forcaArray['letra_12'];
    } 
    if ($opcao == "15") {
        echo $forcaArray['letra_13'];
    } 

}

$conn->close();
?>



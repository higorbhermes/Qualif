<?php
$servername = "localhost";
$username = "id8750832_qualif";
$password = "abcd1234";
$dbname = "id8750832_qualif";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$email = mysqli_real_escape_string($conn, $_GET['email']);
$opcao = mysqli_real_escape_string($conn, $_GET['opcao']);


if ($opcao == "1"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "2"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "3"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "4"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "5"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "6"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "7"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "8"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "9"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
if ($opcao == "10"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 0;
    }
    else{
        echo 1;
    }
}
$conn->close();
?>



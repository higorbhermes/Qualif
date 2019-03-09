<?php
$servername = "localhost";
$username = "id8750832_qualif";
$password = "abcd1234";
$dbname = "id8750832_qualif";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$nome = mysqli_real_escape_string($conn, $_GET['nome']);
$sobrenome = mysqli_real_escape_string($conn, $_GET['sobrenome']);
$email = mysqli_real_escape_string($conn, $_GET['email']);
$senha = mysqli_real_escape_string($conn, $_GET['senha']);
$sql = "INSERT INTO Usuario (primeiro_nome, sobrenome, email, senha) VALUES ('$nome', '$sobrenome', '$email', '$senha')";

if ($conn->query($sql) === TRUE) {
    echo "1";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>



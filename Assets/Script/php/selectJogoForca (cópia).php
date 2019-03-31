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
$email = mysqli_real_escape_string($conn, $_GET['email']);
$resposta = mysqli_real_escape_string($conn, $_GET['resposta']);
if ($resposta == 1){
    $num_erros = 0;
    $num_acertos = 1;
}
else{
    $num_erros = 1;
    $num_acertos = 0;
}

$query = "SELECT * FROM Jogador-Forca WHERE id_forca = '$id_forca' && email = '$email'";

$statement = $conn->prepare($query);
$statement = execute();
$result = $statement->get_result();
$forcaArray = $result->fetch_assoc();

if ($forcaArray == null){
    $sql = "INSERT INTO Jogador-Forca (email, id_forca, Acertou, Num_erros, Num_acertos) VALUES ('$email', '$id_forca', '$resposta', '$num_erros', '$num_acertos')";
    if ($conn->query($sql) === TRUE) {
        echo "1";
    } 
    else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}
else{
    $num_erros = $num_erros + $forcaArray['Num_erros'];
    $num_acertos = $num_acertos + $forcaArray['Num_acertos'];
    $sql = "UPDATE Jogador-Forca SET Num_erros='$num_erros'&& Num_acertos='$num_acertos' && Acertou='$resposta' WHERE id_forca = '$id_forca' && email = '$email'";
    if ($conn->query($sql) === TRUE) {
        echo "1";
    } 
    else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

$conn->close();
?>



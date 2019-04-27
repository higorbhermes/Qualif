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

$query = "SELECT * FROM Jogador-Forca WHERE id_forca = '$id_forca' && email = '$email'";

$statement = $conn->prepare($query);
$statement = execute();
$result = $statement->get_result();
$forcaArray = $result->fetch_assoc();

if ($opcao == "1"){
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    echo $soma;
    }
}
if ($opcao == "2"){
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
}
if ($opcao == "3"){
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    echo $soma;
    }
}
if ($opcao == "4"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'] + $forcaArray['Num_acertos'];
    }
    echo $soma;
    }
}
if ($opcao == "5"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma +  $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_acertos'];
    }
    echo $soma;
    }
}
if ($opcao == "6"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = 0;
    }
    else{
        $soma = $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement = execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        $soma = $soma + 0;
    }
    else{
        $soma = $soma + $forcaArray['Num_erros'];
    }
    echo $soma;
    }
}
if (opcao = 7){
    $sql = "DELETE FROM JogadorQuiz WHERE email = '$email'";
    if ($conn->query($sql) === true){
        echo "1";
    }
}
if (opcao = 8){
    $sql = "DELETE FROM JogadorForca WHERE email = '$email'";
    if ($conn->query($sql) === true){
        echo "1";
    }
}
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



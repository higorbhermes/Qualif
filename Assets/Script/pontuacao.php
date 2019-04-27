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
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == "2"){
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == "3"){
    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == "4"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == "5"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == "6"){
    $query = "SELECT * FROM JogadorForca WHERE id_forca = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
    $statement->execute();
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
if ($opcao == 7){
    $sql = "DELETE FROM JogadorQuiz WHERE email = '$email'";
    if ($conn->query($sql) === true){
        echo "1";
    }
}
if ($opcao == 8){
    $sql = "DELETE FROM JogadorForca WHERE email = '$email'";
    if ($conn->query($sql) === true){
        echo "1";
    }
}
$conn->close();
?>



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

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '1' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '2' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '3' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '4' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '5' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '6' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '7' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '8' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '9' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

    $query = "SELECT * FROM JogadorQuiz WHERE id_quiz = '10' && email = '$email'";
    $statement = $conn->prepare($query);
    $statement->execute();
    $result = $statement->get_result();
    $forcaArray = $result->fetch_assoc();
    if ($forcaArray == null){
        echo 2;
    }
    else{
        echo $forcaArray['Acertou'];
    }

$conn->close();
?>



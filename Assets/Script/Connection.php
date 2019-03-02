<?

$servidor = 'localhost';
$banco = 'id8750832_qualif';
$usuario = 'id8750832_qualif';
$senha = 'abcd1234';
$link = mysql_connect($servidor, $usuario, $senha);
$db = mysql_select_db('user');
if(!$link)
{
    echo "erro ao conectar ao banco de dados!";exit();
}


?>
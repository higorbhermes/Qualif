<?

require_once(Connection.php);

$insere = mysql_query("INSERT INTO User (nome. email, senha, avatar) VALUES ('Pedro', 'pedrinho@gmail.com', 'abc', '1')");

if ($insere) echo "Cadastro Realizado";
else echo ("Cadastro Não Realizado")

?>
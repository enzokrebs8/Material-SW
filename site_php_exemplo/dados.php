<?php
    $nome = $_POST['nome'];
    $idade = $_POST['idade'];
    // caso use GET os dados aparecem na URL
    echo "Bem vindo <b>$nome</b>! <br>";
    echo "Você tem <b style=\"color:red\">$idade</b>";

?>
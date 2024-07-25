<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Site PHP</title>
</head>
<body>
    <h1>Hello World</h1>
    <?php  
        $nome = 'Enzo';
        echo "<p>Bem vindo $nome</p>";
        $a = 10;
        $b = 20;
        $soma = $a + $b;
        echo "A soma de $a com $b é igual a $soma";
        echo "<br>";
        $status = "baby kiss me through the phone";

        if($status){
            echo "Está ativo";
        }
        else{
            echo "Está desligada";
        }

        echo "<hr>";
        
        for($i=1;$i<=100;$i++){
            
            if($i % 2 == 0){
                echo "$i <br>";
            }
        }


    ?>
</body>
</html>
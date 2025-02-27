<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h3>Odczyt z pliku</h3>
    <?php
    $file = fopen("data.txt", "r");
    if($file){
        while($line = fgets($file)){
            echo $line . "<br>";
        }
        fclose($file);
    }
    ?>
</body>
</html>
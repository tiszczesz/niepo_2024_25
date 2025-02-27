<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Zapis do pliku z tablicy</h1>
    <a href="readFromFile.php">Odczyt z pliku tekstowego</a>
    <?php
    $texts = ["ala ma kota", "kot ma ale", "pies ma kota", "kot ma psa"];
    echo count($texts) . "<br>";
    $file = fopen("plik.txt", "w");
    if($file){
        //zapisanie do pliku jednej linii tekstu
        //fwrite($file,$texts[0]);
        foreach($texts as $elem){
            fwrite($file,$elem .PHP_EOL);
        }
        fclose($file);
    }
    ?>
</body>
</html>
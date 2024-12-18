<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>pliki</title>
</head>

<body>
    <h1>Operacje na plikach</h1>
    <?php
    const FILE_NAME = "info.txt";
    $file = fopen(FILE_NAME, "r");
    if ($file) {
        while (($line = fgets($file))) {
            echo $line . "<br>";
        }
        fclose($file);
    } else {
        echo "Nie udało się otworzyć pliku";
    }
    $words = ["Ala", "ma", "kota"];
    $file = fopen("output.txt", "a");
    if ($file) {
        foreach ($words as $word) {
            fwrite($file, $word . "-");
        }
        fwrite($file, PHP_EOL);
        fclose($file);
    } else {
        echo "Nie udało się otworzyć pliku";
    }
    ?>
</body>

</html>
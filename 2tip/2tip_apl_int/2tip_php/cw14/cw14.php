<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    require_once 'functions.php';
    newLine("Ala ma kota");
    newLine("Żółta łódź");
    echo strlen("Ala") . "<br>";
    echo strlen("łódź") . "<br>";
    echo mb_strlen("łódź") . "<br>";
    echo mb_strlen("łódź", "UTF-8") . "<br>";

    ?>
</body>

</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    require_once "functions.php";

    $books = GetFromFile("dane.txt");
    var_dump($books);
    ?>
</body>
</html>
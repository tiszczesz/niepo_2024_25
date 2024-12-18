<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <!-- formularz w postaci input firstname textarea komentarz submit
     do pliku  -->
     <!--
     dla ambitnych zapisz z datą
-->
     date("Y-m-d H:i:s")
    <form action="result.php" method="post">
        <input type="text" name="firstname" placeholder="Imię">
        <textarea name="comment" placeholder="Komentarz"></textarea>
        <input type="submit" value="Wyślij">
</body>
</html>
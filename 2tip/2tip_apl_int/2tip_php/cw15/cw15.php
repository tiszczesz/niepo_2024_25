<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $myDate = mktime(14, 30, 0, 3, 15, 2021);
    echo date("Y-m-d H:i:s")."<br>";
    echo date("Y-m-d H:i:s",1234567890)."<br>";
    ?>
</body>
</html>
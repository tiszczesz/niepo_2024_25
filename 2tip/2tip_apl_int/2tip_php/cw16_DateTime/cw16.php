<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Użycie DateTime</h1>
    <?php
    $date = new DateTime();
    $date2 = new DateTime("2021-03-15 14:30:00");
    var_dump($date);
    var_dump($date2);
    echo "<br>";
    $date3 = new DateTime(date("Y-m-d H:i:s",0));
    var_dump($date3);
    echo "<br>";
    $date3->setTimestamp(100000000);
    var_dump($date3);
    echo "<br>";
    $mydiff = $date3->diff($date2);
    var_dump($mydiff);
    echo "<br>".$date3->format("Y/M/d");
    ?>
</body>

</html>
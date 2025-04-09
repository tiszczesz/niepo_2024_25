<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw20.css">
    <title>Wypożyczalnia samochodów</title>
</head>

<body>
    <header>
        <h1>Dostępne samochody do wypożyczenia</h1>
    </header>
    <main>
    <?php
    require_once 'functions.php';
    $cars = getCars();
   // var_dump($cars);
    echo carsToTable($cars);
    ?>
    </main>
    <footer>

    </footer>
</body>

</html>
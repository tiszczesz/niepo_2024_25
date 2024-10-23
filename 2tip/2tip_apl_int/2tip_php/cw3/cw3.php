<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw3.css">
    <title>Document</title>
</head>

<body>
    <h1>Ćwiczenie 3</h1>
    <?php
    const IMIE = "Janusz"; //definicja stałej
    define("WIEK", 18); //definicja stałej po staremu !!!!!
    $a = 2345;
    echo "a = $a <br>";
    $age = 13;
    if ($age >= WIEK) {
        echo "Jesteś pełnoletni <br>";
    } else {
        echo "Nie jesteś pełnoletni <br>";
    }
    ?>
    <h3>Obliczenia</h3>
    <div class="border">
        <?php
        $a = 2;
        $b = 10;
        echo "<p>{$a} + {$b} = " . ($a + $b) . "</p>";
        echo "<p>{$a} - {$b} = " . ($a - $b) . "</p>";
        echo "<p>{$a} * {$b} = " . ($a * $b) . "</p>";
        $error = $b == 0 ? "class='error'" : "";
        echo "<p {$error}>{$a} / {$b} = "
            . ($b != 0 ? round($a / $b, 2) : "BRAK WYNIKU") . "</p>";
        ?>
    </div>
</body>

</html>
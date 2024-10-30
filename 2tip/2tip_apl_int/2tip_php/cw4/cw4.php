<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Ćwiczenie 4 - pętle</h1>
    <h3>Pętla for</h3>
    <?php
    for ($i = 1; $i <= 6; $i++) { //pętla for generująca nagłówki h1-h6
        echo "<h{$i}>Nagłówek h{$i}</h{$i}>";
    }
    ?>
    <h3>Pętla while</h3>
    <?php
    //proszę napisać pętle while generującą losowe liczby z zakresu 1-10
    //dopóki suma liczb nie przekroczy 100
    $liczba = rand(1, 10); //losowanie liczby z zakresu 1-10
    //6 + 7 + 8 + 9 + 10 + 3 +... = 96
    $sum = 0;
    while ($sum <= 100) {
        $number = rand(1, 10);
        $sum += $number;
        $char = $sum <= 100 ? " + " : " = ";
        echo $number . $char;
    }
    echo $sum;
    ?>
    <h3>Pętla do-while</h3>
    <?php
    //proszę napisać pętle do-while generującą losowe liczby z zakresu 0-10
    //dopóki NIE WYLOSUJEMY liczby 0
    //wylosowano 3 7 0
    do {
        $number = rand(0, 10);
        echo $number . " ";
    } while ($number != 0);
?>
</body>

</html>
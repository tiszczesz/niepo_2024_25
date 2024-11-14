<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Ćwiczenie 6 - tablice</h1>
    <h3>Definiowanie tablicy w php</h3>
    <pre>
    <?php
    $tab = array(1, 2, 3, 4, 5); // tablica indeksowana numerycznie
    var_dump($tab);
    $tab2 = [1, 2, 3, 4, 5, 6]; // tablica indeksowana numerycznie nowszym sposobem
    var_dump($tab2);
    ?>
    <h3>Tablica asocjacyjne</h3>
    <?php
    $tAsoc = [       //key => value
        'imie' => 'Jan',
        'nazwisko' => 'Kowalski',
        'wiek' => 30
    ];
    var_dump($tAsoc);
    ?>  
    <h3>Wyświetlanie tablic</h3>
    <?php
    print_r($tab);
    print_r(($tAsoc));
    echo "Za pomocą pętli for:  niezalecane<br>";
    for ($i = 0; $i < count($tab2); $i++) {
        echo "elem tab o indeksie: " . $i . " => " . $tab2[$i] . "<br>";
    }
    echo "Za pomocą pętli foreach: <br>";
    foreach ($tAsoc as $k => $v) {
        echo "klucz: " . $k . " => wartość: " . $v . "<br>";
    }
    foreach ($tAsoc as $elem) {
        echo " element tablicy: " . $elem . "<br>";
    }
    $tab[10] = "nowy element";
    print_r($tab);
    //error
    for ($i = 0; $i < count($tab); $i++) {
        echo "elem tab o indeksie: " . $i . " => " . $tab[$i] . "<br>";
    }
    // unset($tab2[2]);
    $tab2[3] = null;
    var_dump($tab2);
    ?>
</pre>
</body>

</html>
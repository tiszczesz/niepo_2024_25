<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dziedziczenie w PHP</title>
</head>
<body>
    <?php
    require_once 'Animal.php';
    require_once 'Dog.php';
    require_once 'Cat.php';
    //utworzenie obiektu klasy Animal
    $animal1 = new Animal('Burek', 5, 'biały');
    var_dump($animal1);
    //uzycie metody __toString()
    echo "<p>$animal1</p>";
    echo "<hr>";

    //utworzenie obiektu klasy Dog
    $dog1 = new Dog('Azor', 3, 'czarny');
    $dog2 = new Dog('Reksio', 2, 'brązowy', 'pisk pisk');
    var_dump($dog1);
    //uzycie metody __toString()
    echo "<p>$dog1</p>";
    echo "<p>$dog2</p>";
    echo "Podaj nazwę psa: " . $dog1->getName() . "<br>";
    echo "Podaj nazwę psa: " . $dog2->getName() . "<br>";
    echo "<hr>";
    $c1 = new Cat('Mruczek', 4, 'czarny', 'po podłodze');
    $c2 = new Cat('Kicia', 1, 'czarno-biały', 'po drzewach');
    echo "<p>$c1</p>";
    echo "<p>$c2</p>";
    ?>
</body>
</html>
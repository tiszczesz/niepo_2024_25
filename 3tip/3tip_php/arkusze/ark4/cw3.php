<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    require_once 'Person.php';
    setcookie('name', 'Jan', time() + 60);
    $person1 = new Person(
        'Jan',
        20,
        'm',
        ['sport', 'muzyka']
    );
    $person2 = new Person('Anna', 25, 'k');
    var_dump($person1);
    echo $person1;
    echo "<hr>";
    echo $person2;
    if (isset($_COOKIE['name'])) {
        echo $_COOKIE['name'];
    } else {
        echo "Brak ciasteczka";
    }
    ?>
</body>

</html>
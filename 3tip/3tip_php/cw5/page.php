<?php
session_start();

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Strona page.php</h1>
    <div>Sprawdzienie czy sesja jest otwarta</div>
    <?php
    if (isset($_SESSION['user'])) {
        echo "<p>Witaj " . $_SESSION['user'] . " Sesja jest otwarta</p>";
        echo "<p><a href='logout.php'>Wyloguj</a></p>";
    } else {
        echo "<p>Sesja nie jest otwarta</p>";
        echo "<p><a href='login.php'>Zaloguj</a></p>";
    }
    ?>


</body>

</html>
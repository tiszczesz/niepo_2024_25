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
    <h2>Inna strona</h2>
    <div style="border:solid 1px black;padding:10px; background-color: lightblue;">
        <?php
        // Sprawdzanie, czy sesja jest otwarta
        if (isset($_SESSION['user'])) {
            echo "Sesja jest otwarta. Witaj, " . $_SESSION['user'] . "!";
            echo "<br><a href='logout.php'>Zamknij sesję</a>";
        } else {
            echo "Sesja nie jest otwarta.";
            echo "<br><a href='login.php'>Otwórz sesję</a>";
        }
        ?>
    </div>
</body>

</html>
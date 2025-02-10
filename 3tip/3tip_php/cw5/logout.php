<?php
session_start();

//zamknięcie sesji
session_unset();
session_destroy();

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>logout.php</h1>
    <h3>Sesja została zamknięta</h3>
    <div>
        <a href="index.php">Strona główna</a>
        <a href="login.php">Zaloguj</a>
        <a href="logout.php">Wyloguj</a>
    </div>
</body>

</html>
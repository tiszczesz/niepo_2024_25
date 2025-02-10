<?php
session_start();

//otwarcie sesji
$_SESSION['user'] = 'Janusz';

echo "<p>Sesja otwarta</p>";
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>login.php</h1>
    <div>
        <a href="index.php">Strona główna</a>
        <a href="login.php">Zaloguj</a>
        <a href="logout.php">Wyloguj</a>
    </div>
</body>

</html>
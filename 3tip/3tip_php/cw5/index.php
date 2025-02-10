<?php
session_start();

//sprawdzenie czy sesja jest otwarta
if(isset($_SESSION['user'])){
    echo "<p>Witaj ".$_SESSION['user']."</p>";
    echo "<p><a href='logout.php'>Wyloguj</a></p>";
}else{
    echo "<p>Sesja nie jest otwarta</p>";
    echo "<p><a href='login.php'>Zaloguj</a></p>";
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Strona index.php</h1>
    <div>
        <a href="page.php">Strona główna</a>
        <a href="login.php">Zaloguj</a>
        <a href="logout.php">Wyloguj</a>
    </div>
</body>
</html>
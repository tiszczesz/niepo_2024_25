<?php
session_start();

// Sprawdzanie, czy sesja jest otwarta
if (isset($_SESSION['user'])) {
    echo "Sesja jest otwarta. Witaj, " . $_SESSION['user'] . "!";
    echo "<br><a href='logout.php'>Zamknij sesję</a>";
} else {
    echo "Sesja nie jest otwarta.";
    echo "<br><a href='login.php'>Otwórz sesję</a>";
}
echo "<br><a href='page.php'>Inna strona</a>";

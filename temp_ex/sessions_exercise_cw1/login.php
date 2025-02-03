<?php
session_start();

// Otwieranie sesji
$_SESSION['user'] = 'Użytkownik123';

echo "Sesja została otwarta.";
echo "<br><a href='index.php'>Wróć do strony głównej</a>";
?>
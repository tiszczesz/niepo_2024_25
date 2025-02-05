<?php
session_start();

// Zamknięcie sesji
session_unset();
session_destroy();

echo "Sesja została zamknięta.";
echo "<br><a href='index.php'>Wróć do strony głównej</a>";
?>
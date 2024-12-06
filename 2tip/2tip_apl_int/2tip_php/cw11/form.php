<?php
if (!isset($_GET['page']) || $_GET['page'] !== 'form') {
    header('Location: layout.php?page=home');
    exit();
}


$html = <<<html
<h1>Formularz 2024</h1>
<h1>
    <form method="post">
        <input type="text" placeholder="podaj imię" name="name">
        <input type="submit" value="Zapisz">
    </form>
</h1>
html;

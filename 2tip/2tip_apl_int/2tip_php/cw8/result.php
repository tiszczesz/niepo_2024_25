<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2>Resultat działania formularza</h2>
    <pre>
    <?php
    // var_dump($_GET);
    // var_dump($_POST);
    // var_dump($_REQUEST);
    // var_dump($_SERVER);
    //pobieranie danych z formularza GET
    $name = $_GET['name'];
    $age = $_GET['age'];
    $data = $_GET['data'];
    echo "<div>imię: {$name} wiek: {$age} data: {$data}</div>"
    ?>
    </pre>
</body>
</html>
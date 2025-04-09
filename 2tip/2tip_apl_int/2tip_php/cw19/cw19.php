<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Użytkownicy</title>
</head>
<?php
require_once 'functions.php';
?>

<body>
    <h1>Lista użytkowników ilość: <?php echo usersCount() ?> </h1>
    <?php
    $users = getUsers();
    //echo "<pre>";
    //var_dump($users);
    //echo "</pre>";
    echo usersToTable($users);
    ?>
</body>

</html>
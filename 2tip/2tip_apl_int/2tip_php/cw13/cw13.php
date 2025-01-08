<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Zbiór książek</title>
</head>

<body>
    <div class="container">
        <h1>Zbiór książek</h1>
        <div>
            <a href="addBook.php" class="btn btn-primary">Dodaj książkę</a>
        </div>
        <?php
        require_once 'functions.php';
        //var_dump(readBooks("books.txt"));
        echo booksToTable(readBooks("books.txt"));
        ?>
    </div>


</body>

</html>
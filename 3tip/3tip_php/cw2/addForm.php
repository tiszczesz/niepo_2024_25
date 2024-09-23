<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="cw2.css">
    <title>Lista klas</title>
</head>

<body>
    <main class="container">
        <h1>Dodaj nowego ucznia</h1>
        <form action="addToDb.php" method="post">
            <div class="row m-2">
                <input type="text" name="firstname" class="col-6" placeholder="Podaj imię">
                <span class="col-3 text-danger"></span>
            </div>
            <div class="row m-2">
                <input type="text" name="lastname" class="col-6" placeholder="Podaj nazwisko">
                <span class="col-3 text-danger"></span>
            </div>
            <div class="row m-2">
                <label for="group" class="col-3">Wybierz klasę</label>
                <select name="group" id="group" class="col-3">
                    <?php
                    require_once 'functions.php';
                    echo getGroupsOptions(getGroups());
                    ?>
                </select>
            </div>
            <div class="row m-2">
                <input type="submit" value="Zapisz" class="btn btn-primary col-6">
            </div>
        </form>

    </main>
</body>
</main>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>
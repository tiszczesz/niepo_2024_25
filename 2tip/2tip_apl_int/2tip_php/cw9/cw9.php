<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title>Document</title>
</head>

<body>
    <div class="container">
        <h1>Formularz zgłoszeniowy metodą POST</h1>
        <form action="result.php" method="post">
            <div class="row m-2">
                <label class="col-3 text-end" for="firstname">Podaj imię</label>
                <input class="col-6" type="text" id="firstname" name="firstname" required>
            </div>
            <div class="row m-2">
                <label for="lastname" class="col-3 text-end">Podaj nazwisko</label>
                <input class="col-6" type="text" id="lastname" name="lastname" required>
            </div>
            <div class="row m-2">
                <label for="birthDate" class="col-3 text-end">Podaj datę urodzenia</label>
                <input class="col-6" type="date" id="birthDate" name="birthDate" required>
            </div>
            <div class="row m-2">
                <label class="col-3 text-end" for="division">Wybierz dział</label>
                <select class="col-6" name="division" id="division">
                    <option value="Dział IT">Dział IT</option>
                    <option value="Dział Księgowości">Dział Księgowości</option>
                    <option value="Dział Kadr">Dział Kadr</option>
                    <option value="Dział Marketingu">Dział Marketingu</option>
                </select>
            </div>
            <div class="row m-2">
                <label class="col-3 text-end">Wybierz płeć:</label>
            </div>
            <div class="row m-2">
                <div class="col-6 offset-3" style="padding: 0px;">
                    <input type="radio" id="m" value="m" name="gender">
                    <label for="m">Mężczyzna</label>
                </div>
                <div class="col-6 offset-3" style="padding: 0px;">
                    <input type="radio" id="k" value="k" name="gender">
                    <label for="m">Kobieta</label>
                </div>
            </div>
            <div class="row m-2">
                <label class="col-3 text-end" for="hobby">Zainteresowania:</label>
            </div>
            <div class="col-6 offset-3">
                <input type="checkbox" name="hobby[]" value="książki">
                <label for="">książki</label>
            </div>
            <div class="col-6 offset-3">
                <input type="checkbox" name="hobby[]" value="muzyka">
                <label for="">muzyka</label>
            </div>
            <div class="col-6 offset-3">
                <input type="checkbox" name="hobby[]" value="sport">
                <label for="">sport</label>
            </div>

    </div>
    <div class="row m-2">
        <label class="col-3 text-end" for="color">wybierz kolor</label>
        <input class="col-6" type="color" name="color">
    </div>
    <div class="row m-2">
        <input type="submit" class="col-6 offset-3 btn btn-primary">
    </div>

    </form>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>
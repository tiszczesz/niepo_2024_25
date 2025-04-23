<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <header>
        <h1>Wypożyczalnia samochodów</h1>
    </header>
    <main>
        <?php
        // if(filter_has_var(INPUT_GET,'id')){}
        if (!isset($_GET['id'])) {
            echo "<div clas='info'>Nie podano id samochodu do wypożyczenia.</div>";
            exit;
        }
        require_once 'functions.php';
        $id = $_GET['id'];
        // $id = filter_input(INPUT_GET, 'id', FILTER_VALIDATE_INT);
        $car = getCarById($id);
        if ($car == null) {
            echo "<div class='info'>Nie znaleziono samochodu o id $id.</div>";
            exit;
        }
        ?>
        <h2>Wypożycz samochód</h2>
        <h3>Parametry samochodu</h3>
        <?php
        echo "<p>Marka: {$car['marka']}</p>";
        echo "<p>Model: {$car['model']}</p>";
        echo "<p>Rocznik: {$car['rocznik']}</p>";
        echo "<p>Stan: {$car['stan']}</p>";

        ?>
        <hr>

        <h3>Formularz wypożyczenia</h3>
        <form method="post">
            <label for="klient">Nazwa klienta</label><br>
            <input type="text" id="klient" name="klient" required><br>
            <label for="phone">Telefon:</label><br>
            <input type="tel" id="phone" name="phone" required><br>
            
            <label for="date">Data zamówienia:</label><br>
            <input type="date" id="date" name="date" required><br>
            <input type="hidden" name="id" value="<?php echo $car['id']; ?>">
            <input type="submit" value="Wypożycz">
        </form>
        <?php
        if(filter_has_var(INPUT_POST,'klient')){
           var_dump($_POST);
        }
        ?>
    </main>
    <footer>

    </footer>

</body>

</html>
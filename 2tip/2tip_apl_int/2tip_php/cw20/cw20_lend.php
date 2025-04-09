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
        if (!isset($_GET['id'])) {
            echo "<div clas='info'>Nie podano id samochodu do wypożyczenia.</div>";
            exit;
        }
        require_once 'functions.php';
        //formularz do wypożyczenia samochodu
        ?>

    </main>
    <footer>
       
    </footer>
   
</body>
</html>
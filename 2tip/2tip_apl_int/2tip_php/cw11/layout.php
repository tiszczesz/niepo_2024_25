<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="layout.css">
    <title>Document</title>
</head>

<body>
    <header>
        <h1>Menu</h1>
        <nav>
            <a href="layout.php?page=home">Strona główna</a>
            <a href="layout.php?page=form">Formularz</a>
            <a href="layout.php?page=about">O firmie</a>
        </nav>
    </header>
    <main>
    <?php
     include 'router.php';
        $page = $_GET['page'] ?? 'home';
        //var_dump($page);
        echo getPage($page);
    ?>
    </main>
    <footer>
        Wykoanł i skonał &copy; 2024
    </footer>
</body>

</html>
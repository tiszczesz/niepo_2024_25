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
        <h1>Lista klas</h1>
        <table class="table table-striped">
            <tr>
                <th>Lp</th>
                <th>Nazwa klasy</th>
                <th>Rodzaj klasy</th>
                <th>Wychowawca klasy</th>
                <th>Operacje</th>
            </tr>
            <?php
            require_once 'functions.php';
            $groups = getGroups();
            // var_dump($groups);
            $lp = 0;
            foreach ($groups as $g) {
                $lp++;
                echo "<tr>";
                echo "<td>{$lp}</td>";
                echo "<td>{$g[1]}</td>";
                echo "<td>{$g[2]}</td>";
                echo "<td>{$g[3]}</td>";
                echo "<td><a class='btn btn-outline-secondary' href='listByGroup.php?id={$g[0]}'>"
                    . "Lista uczniów klasy</a></td>";
                echo "</tr>";
            }
            ?>
        </table>
    </main>
</body>
</main>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>
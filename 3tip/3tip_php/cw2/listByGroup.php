<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="cw2.css">
    <title>Lista uczniów</title>
</head>

<body>
    <main class="container">
        <?php
        require_once 'functions.php';

        if (isset($_GET['id'])) {
            $group = getGroupById($_GET['id']);
            echo "<h2 class='mt-3'>Lista uczniów klasy {$group[1]} {$group[2]} wychowawca: {$group[3]}</h2>";
        }

        ?>
        <table class="table table-striped">
            <tr>
                <th>Lp</th>
                <th>Imię</th>
                <th>Nazwisko</th>
                <th>Operacje</th>
            </tr>
            <?php
            $students = getStudentsByGroupId($_GET['id']);
            $lp = 0;
            foreach ($students as $s) {
                $lp++;
                echo "<tr>";
                echo "<td>{$lp}</td>";
                echo "<td>{$s[1]}</td>";
                echo "<td>{$s[2]}</td>";
                echo "<td><a class='btn btn-danger' href='delete.php?id={$s[0]}'>USUŃ</a></td>";
                echo "</tr>";
            }
            ?>
        </table>
        <a class="btn btn-outline-secondary" href="cw2.php">Powrót</a>
    </main>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>
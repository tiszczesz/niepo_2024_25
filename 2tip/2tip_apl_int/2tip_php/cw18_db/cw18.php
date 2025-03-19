<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista uzytkowników</title>
</head>

<body>
    <h1>Lista uzytkowników</h1>
    <?php
    //utworzyc obiekt mysqli
    $conn = new mysqli(
        'localhost',
        'root',
        null,
        '2tip_2025_cw1'
    );
    echo "<pre>";
    if ($conn->connect_errno) {
        echo "Błąd połączenia: $conn->connect_error";
        die("Błąd połączenia: $conn->connect_error");
    }
    // $conn->set_charset('utf8');
    // $conn->query('SET NAMES utf8');
    var_dump($conn);
    echo "</pre>";
    //zapytanie do bazy danych
    $sql = "SELECT * FROM users";
    //wykonanie zapytania
    $result = $conn->query($sql);
    var_dump($result);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $conn->close();
    ?>
</body>

</html>
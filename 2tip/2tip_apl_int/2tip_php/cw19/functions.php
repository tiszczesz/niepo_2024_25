<?php
function connect(): ?mysqli
{
    $conn = new mysqli(
        'localhost',
        'root',
        null,
        '2tip_2025_cw1'
    );
    if ($conn->connect_errno) {
        echo "Błąd połączenia: $conn->connect_error";
        return null;
    }
    return $conn;
}
function getUsers(): array
{
    $conn = connect();
    if ($conn === null) {
        return [];
    }
    $sql = "SELECT * FROM users";
    $result = $conn->query($sql);
    $users = [];
    while ($row = $result->fetch_assoc()) {
        $users[] = $row;
    }
    $conn->close();
    return $users;
}
function usersToTable(array $users): string
{
    $html = "<table class='table table-striped'>\n";
    $html .= "<thead><tr><th>lp</th><th>Imię</th><th>Nazwisko</th>" .
        "<th>Wiek</th></tr></thead>\n<tbody>";
    $lp = 0;
    foreach ($users as $user) {
        $lp++;
        $html .= "\t<tr><td>$lp</td><td>{$user['firstname']}</td>" .
            "<td>{$user['lastname']}</td><td>{$user['age']}</td></tr>\n";
    }
    return $html . "</tbody></table>";
}
function usersCount(): int
{
    $conn = connect();
    if ($conn === null) {
        return 0;
    }
    $sql = "SELECT COUNT(*) as count FROM users";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
    //var_dump($row);
    $conn->close();
    return (int)$row['count'];
}

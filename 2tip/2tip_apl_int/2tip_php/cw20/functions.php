<?php
require_once 'config.php';
function getConnection(string $dbName): mysqli|null
{
    $conn = new mysqli("localhost", "root", null, $dbName);
    if ($conn->connect_error) {
        return null;
    }
    return $conn;
}
function getCars(): array
{
    $conn = getConnection(DB_NAME);
    if ($conn == null) return [];
    $sql = "SELECT * FROM samochody";
    $result = $conn->query($sql);
    $cars = [];
    while ($row = $result->fetch_assoc()) {
        $cars[] = $row;
    }
    $conn->close();
    return $cars;
}
function carsToTable(array $data): string
{
    $html = "<table>";
    $html .= "<tr><th>Lp</th><th>Marka</th><th>Model</th><th>Rocznik</th><th>Stan</th><th></th></tr>";
    $lp = 0;
    foreach ($data as $row) {
        $lp++;
        $html .= "<tr>\n";
        $html .= "\t<td>$lp</td>\n";
        $html .= "\t<td>{$row['marka']}</td>\n";
        $html .= "\t<td>{$row['model']}</td>\n";
        $html .= "\t<td>{$row['rocznik']}</td>\n";
        $html .= "\t<td>{$row['stan']}</td>\n";
        $html .= "\t<td><a href=\"cw20_lend.php?id={$row['id']}\">Wypożycz</a></td>\n";
        $html .= "</tr>\n";
    }
    $html .= "</table>";
    return $html;
}
function getCarById(int $id): array | null {
    $conn = getConnection(DB_NAME);
    if ($conn == null) return null;
    $sql = "SELECT * FROM samochody WHERE id = $id";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
    $conn->close();
    return $row;
}
function addOrder(array $data){
    //czy tablica $data zawiera wszystkie wymagane pola
    if(!isset($data['klient']) || !isset($data['phone']) || !isset($data['date']) || !isset($data['id'])) {
        return false;
    }
    $conn = getConnection(DB_NAME);
    if ($conn == null) return false;
    $sql = "INSERT INTO zamowienia (Klient, telefon, dataZam, Samochody_id) "
        ." VALUES ('{$data['klient']}', '{$data['phone']}', '{$data['date']}', {$data['id']})";
    $result = $conn->query($sql);
    $conn->close();
    return $result; //zwraca true lub false
}

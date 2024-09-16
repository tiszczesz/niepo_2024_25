<?php

function getConnection(): ?mysqli
{
    $conn = new mysqli('localhost', 'root',
null, '3ti_2024_25_cw1');//wywołanie konstruktora klasy mysqli
    if($conn->connect_errno!=0) return null;
    return $conn;
}
function getGroups():array {
    $conn = getConnection();//pobranie połączenia
    if($conn==null) return [];//jeśli nie udało się połączyć z bazą danych to zwracamy pustą tablicę
    $sql = "SELECT * FROM groups";//zapytanie do bazy danych
    $result = $conn->query($sql);//wykonanie zapytania
    $groups = [];
    while($row = $result->fetch_row()){//pobieranie wiersza z wyniku zapytania
        $groups[] = $row;//dodanie wiersza do tablicy groups
    }
    $conn->close();//zamknięcie połączenia
    return $groups;
}
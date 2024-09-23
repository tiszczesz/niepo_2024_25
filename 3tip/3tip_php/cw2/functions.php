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
//napisać funkcję getGroupById($id) informacje o danej klasie
function getGroupById(int $id ) : array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT * FROM groups WHERE id={$id}";
    $result = $conn->query($sql);
    $group = $result->fetch_row();
    $conn->close();
    return $group;    
}
//napisać funkcję getStudentsByGroupId(int $id) informacje o uczniach danej klasy
function getStudentsByGroupId(int $id) : array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT * FROM students WHERE group_id={$id}";
    $result = $conn->query($sql);
    $students = [];
    while($row = $result->fetch_row()){
        $students[] = $row;
    }
    $conn->close();
    return $students;
}
function getGroupsOptions(array $groups) : ?string {
   $html = '';
    foreach($groups as $g){
         $html .= "<option value='{$g[0]}'>{$g[1]}</option>";
    }
    return $html;
}
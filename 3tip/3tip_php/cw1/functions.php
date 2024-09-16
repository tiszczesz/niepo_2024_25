<?php
function GetFromFile($filename)
{
    //pobiera z pliku do tablicy
    $data = file($filename, FILE_IGNORE_NEW_LINES);
    $licznik = 0;
    $books = [];
    $book = [];
    foreach ($data as $row) {
        if (trim($row) === "") {
            $licznik = 0;
            $books[] = $book;
            $book = [];
            continue;
        }
        $book[$licznik++] = $row;
    }
    $books[] = $book;
    return $books;
}

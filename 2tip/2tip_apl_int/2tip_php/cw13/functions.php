<?php

//metoda wczytująca plik books.txt do tablicy tablic fopen fgets fclose
function readBooks(string $filname): array
{
    //return file($filname);
    $file = fopen($filname, "r");
    if (!$file) return []; //jeśli nie udało się otworzyć pliku to zwracamy pustą tablicę  
    $books = [];
    while ($line = fgets($file)) {
        $books[] = explode(";", $line);
    }
    fclose($file);
    return $books;
}

function booksToTable(array $books): string
{
    $html = "<table class='table table-striped'>";
    $html .= "<thead><tr><th>Tytuł</th><th>Autor</th><th>Cena</th><th>Rok</th></tr></thead>";
    $html .= "<tbody>";
    foreach ($books as $book) {
        $html .= "<tr>";
        foreach ($book as $value) {
            $html .= "<td>$value</td>";
        }
        $html .= "</tr>";
    }
    $html .= "</tbody></table>";
    return $html;
}

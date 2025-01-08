<?php
//napusać funkcję która zwróci napis każda litera w nowej lini
function newLine(string $text): void
{
    //echo
    for ($i = 0; $i < mb_strlen($text); $i++) {
        echo mb_substr($text, $i, 1) . "<br>";
        // echo $text[$i] . "<br>";
    }
    echo " -------------------------------------------- <br>";
}

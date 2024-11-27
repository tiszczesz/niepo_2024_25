<?php
function getDrinks():array { //do select
    return [
        'Coca Cola' => 5.99,
        'Pepsi' => 4.99,
        'Sprite' => 3.99,
        'Fanta' => 2.99,
        'Mirinda' => 1.99
    ];    
}
function getFood():array { //do checkboxes
    return [
        'Pizza' => 15.99,
        'Kebab' => 14.99,
        'Burger' => 13.99,
        'HotDog' => 12.99,
        'Frytki' => 11.99,
        'Kurczak' => 10.99,
        'Kotlet' => 9.99
    ];
}
function generSelect(array $data, string $name):string{
    $html = "<select name=\"{$name}\">";
    foreach($data as $key => $value){
        $html .= "<option value=\"{$value}\">{$key}</option>";
    }
    $html .= "</select>";
    return $html;
}

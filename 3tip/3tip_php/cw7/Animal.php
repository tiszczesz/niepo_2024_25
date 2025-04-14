<?php

class Animal{
    public function __construct(
        protected string $name,
        protected int $age,       
        protected string $color = 'black'
    ){
        echo "Wywołanie konstruktora Animal<br>";
    }
    public function __destruct(){
        echo "Wywołanie destruktora Animal<br>";
    }
    public function __toString(){
        return "Imię: $this->name, wiek: $this->age, kolor: $this->color<br>";
    }
}